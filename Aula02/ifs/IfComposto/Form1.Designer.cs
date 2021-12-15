
namespace IfComposto
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
            this.textDoacao = new System.Windows.Forms.TextBox();
            this.btnInvestimento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da Doação:";
            // 
            // textDoacao
            // 
            this.textDoacao.Location = new System.Drawing.Point(102, 28);
            this.textDoacao.Name = "textDoacao";
            this.textDoacao.Size = new System.Drawing.Size(118, 23);
            this.textDoacao.TabIndex = 1;
            // 
            // btnInvestimento
            // 
            this.btnInvestimento.Location = new System.Drawing.Point(4, 75);
            this.btnInvestimento.Name = "btnInvestimento";
            this.btnInvestimento.Size = new System.Drawing.Size(216, 23);
            this.btnInvestimento.TabIndex = 2;
            this.btnInvestimento.Text = "Calcular Investimento";
            this.btnInvestimento.UseVisualStyleBackColor = true;
            this.btnInvestimento.Click += new System.EventHandler(this.btnInvestimento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 136);
            this.Controls.Add(this.btnInvestimento);
            this.Controls.Add(this.textDoacao);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDoacao;
        private System.Windows.Forms.Button btnInvestimento;
    }
}

