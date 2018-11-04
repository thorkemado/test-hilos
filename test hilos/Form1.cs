using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace test_hilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInitProc_Click(object sender, EventArgs e)
        {

            //Creamos el delegado 
            ThreadStart delegado = new ThreadStart(CorrerProceso);
            //Creamos la instancia del hilo 
            Thread hilo = new Thread(delegado);
            //Iniciamos el hilo 
            hilo.Start();
            
        }

        private void CorrerProceso()
        {
            ////Hacer que se tarde 10000 milisegundos (10 segundos) 
            //Thread.Sleep(10000);
            //MessageBox.Show("Proceso finalizado");

            CambiarProgreso("Iniciando proceso...", 0);
            //hagamos un ciclo que se repita 100 veces 
            for (int i = 0; i < 100; i++)
            {
                //esperaremos medio segundo en cada iteración 
                Thread.Sleep(500);
                //notificamos el avance al usuario 
                CambiarProgreso(string.Format("Posición {0}...", i), i);
            }
            CambiarProgreso("Completado :D", 100);
            MessageBox.Show("Proceso finalizado");
        }

        delegate void CambiarProgresoDelegado(string texto, int valor);

        private void CambiarProgreso(string texto, int valor)
        {
            if (this.InvokeRequired) //preguntamos si la llamada se hace desde un hilo 
            {
                //si es así entonces volvemos a llamar a CambiarProgreso pero esta vez a través del delegado 
                //instanciamos el delegado indicandole el método que va a ejecutar 
                CambiarProgresoDelegado delegado = new CambiarProgresoDelegado(CambiarProgreso);
                //ya que el delegado invocará a CambiarProgreso debemos indicarle los parámetros 
                object[] parametros = new object[] { texto, valor };
                //invocamos el método a través del mismo contexto del formulario (this) y enviamos los parámetros 
                this.Invoke(delegado, parametros);
            }
            else
            {
                //en caso contrario, se realiza el llamado a los controles 
                LblProgres.Text = texto;
                PrbProgress.Value = valor;
            }
        }

        
        private void BtShowMessage_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Edwin");
        }
    }
}
