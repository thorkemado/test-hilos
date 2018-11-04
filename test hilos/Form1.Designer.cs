using System.Threading;


namespace test_hilos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }




        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnInitProc = new System.Windows.Forms.Button();
            this.BtShowMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblProgres = new System.Windows.Forms.Label();
            this.PrbProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // BtnInitProc
            // 
            this.BtnInitProc.Location = new System.Drawing.Point(68, 83);
            this.BtnInitProc.Name = "BtnInitProc";
            this.BtnInitProc.Size = new System.Drawing.Size(104, 23);
            this.BtnInitProc.TabIndex = 0;
            this.BtnInitProc.Text = "Init process";
            this.BtnInitProc.UseVisualStyleBackColor = true;
            this.BtnInitProc.Click += new System.EventHandler(this.BtnInitProc_Click);
            // 
            // BtShowMessage
            // 
            this.BtShowMessage.Location = new System.Drawing.Point(68, 138);
            this.BtShowMessage.Name = "BtShowMessage";
            this.BtShowMessage.Size = new System.Drawing.Size(104, 23);
            this.BtShowMessage.TabIndex = 1;
            this.BtShowMessage.Text = "Show message";
            this.BtShowMessage.UseVisualStyleBackColor = true;
            this.BtShowMessage.Click += new System.EventHandler(this.BtShowMessage_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thread tutorial";
            // 
            // LblProgres
            // 
            this.LblProgres.AutoSize = true;
            this.LblProgres.Location = new System.Drawing.Point(68, 193);
            this.LblProgres.Name = "LblProgres";
            this.LblProgres.Size = new System.Drawing.Size(49, 13);
            this.LblProgres.TabIndex = 3;
            this.LblProgres.Text = "Progreso";
            // 
            // PrbProgress
            // 
            this.PrbProgress.Location = new System.Drawing.Point(68, 245);
            this.PrbProgress.Name = "PrbProgress";
            this.PrbProgress.Size = new System.Drawing.Size(100, 23);
            this.PrbProgress.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 280);
            this.Controls.Add(this.PrbProgress);
            this.Controls.Add(this.LblProgres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtShowMessage);
            this.Controls.Add(this.BtnInitProc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInitProc;
        private System.Windows.Forms.Button BtShowMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblProgres;
        private System.Windows.Forms.ProgressBar PrbProgress;
    }
}

