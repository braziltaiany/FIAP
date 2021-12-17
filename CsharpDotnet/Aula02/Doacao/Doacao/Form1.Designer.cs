
namespace Doacao
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
            this.textDoacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConversao = new System.Windows.Forms.Label();
            this.btnConversao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textDolar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textDoacao
            // 
            this.textDoacao.Location = new System.Drawing.Point(12, 40);
            this.textDoacao.Name = "textDoacao";
            this.textDoacao.Size = new System.Drawing.Size(115, 23);
            this.textDoacao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite valor em dolar:";
            // 
            // lblConversao
            // 
            this.lblConversao.AutoSize = true;
            this.lblConversao.Location = new System.Drawing.Point(97, 136);
            this.lblConversao.Name = "lblConversao";
            this.lblConversao.Size = new System.Drawing.Size(83, 15);
            this.lblConversao.TabIndex = 2;
            this.lblConversao.Text = "Valor em Reais";
            // 
            // btnConversao
            // 
            this.btnConversao.Location = new System.Drawing.Point(12, 84);
            this.btnConversao.Name = "btnConversao";
            this.btnConversao.Size = new System.Drawing.Size(253, 23);
            this.btnConversao.TabIndex = 3;
            this.btnConversao.Text = "Converter para reais";
            this.btnConversao.UseVisualStyleBackColor = true;
            this.btnConversao.Click += new System.EventHandler(this.btnConversao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cotação do Dolar:";
            // 
            // textDolar
            // 
            this.textDolar.Location = new System.Drawing.Point(150, 40);
            this.textDolar.Name = "textDolar";
            this.textDolar.Size = new System.Drawing.Size(115, 23);
            this.textDolar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 180);
            this.Controls.Add(this.textDolar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConversao);
            this.Controls.Add(this.lblConversao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDoacao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDoacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConversao;
        private System.Windows.Forms.Button btnConversao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDolar;
    }
}

