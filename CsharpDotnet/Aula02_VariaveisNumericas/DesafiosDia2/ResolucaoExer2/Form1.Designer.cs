
namespace ResolucaoExer2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.btnCredito = new System.Windows.Forms.Button();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo médio:";
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(12, 101);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(38, 15);
            this.lblCredito.TabIndex = 1;
            this.lblCredito.Text = "label2";
            // 
            // btnCredito
            // 
            this.btnCredito.Location = new System.Drawing.Point(14, 52);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(181, 29);
            this.btnCredito.TabIndex = 2;
            this.btnCredito.Text = "Ver Crédito";
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(95, 10);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(100, 23);
            this.textSaldo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 135);
            this.Controls.Add(this.textSaldo);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.TextBox textSaldo;
    }
}

