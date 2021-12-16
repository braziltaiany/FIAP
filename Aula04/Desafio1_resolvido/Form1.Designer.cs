
namespace Desafio1_resolvido
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblFatorial = new System.Windows.Forms.Label();
            this.btnDec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(42, 52);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(133, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Fatorial";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(42, 23);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(133, 23);
            this.txtNum.TabIndex = 4;
            // 
            // lblFatorial
            // 
            this.lblFatorial.AutoSize = true;
            this.lblFatorial.Location = new System.Drawing.Point(42, 128);
            this.lblFatorial.Name = "lblFatorial";
            this.lblFatorial.Size = new System.Drawing.Size(38, 15);
            this.lblFatorial.TabIndex = 6;
            this.lblFatorial.Text = "label1";
            // 
            // btnDec
            // 
            this.btnDec.Location = new System.Drawing.Point(42, 81);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(133, 23);
            this.btnDec.TabIndex = 7;
            this.btnDec.Text = "Fatorial desc";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 152);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.lblFatorial);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblFatorial;
        private System.Windows.Forms.Button btnDec;
    }
}

