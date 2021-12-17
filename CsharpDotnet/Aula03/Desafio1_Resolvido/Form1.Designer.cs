
namespace Desafio1_Resolvido
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
            this.btnVerificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLado3 = new System.Windows.Forms.TextBox();
            this.textLado2 = new System.Windows.Forms.TextBox();
            this.textLado1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(13, 137);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(232, 28);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar Triângulo";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textLado3);
            this.groupBox1.Controls.Add(this.textLado2);
            this.groupBox1.Controls.Add(this.textLado1);
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digite os valores dos lados do triangulo: ";
            // 
            // textLado3
            // 
            this.textLado3.Location = new System.Drawing.Point(7, 83);
            this.textLado3.Name = "textLado3";
            this.textLado3.Size = new System.Drawing.Size(232, 23);
            this.textLado3.TabIndex = 2;
            // 
            // textLado2
            // 
            this.textLado2.Location = new System.Drawing.Point(7, 54);
            this.textLado2.Name = "textLado2";
            this.textLado2.Size = new System.Drawing.Size(232, 23);
            this.textLado2.TabIndex = 1;
            // 
            // textLado1
            // 
            this.textLado1.Location = new System.Drawing.Point(7, 23);
            this.textLado1.Name = "textLado1";
            this.textLado1.Size = new System.Drawing.Size(232, 23);
            this.textLado1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 172);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textLado3;
        private System.Windows.Forms.TextBox textLado2;
        private System.Windows.Forms.TextBox textLado1;
    }
}

