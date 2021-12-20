
namespace Desafio3_resolvido
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOpcao = new System.Windows.Forms.ComboBox();
            this.textValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(12, 131);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(179, 23);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Digite o valor: ";
            // 
            // cmbOpcao
            // 
            this.cmbOpcao.FormattingEnabled = true;
            this.cmbOpcao.Items.AddRange(new object[] {
            "Depósito",
            "Saque",
            "Ver saldo"});
            this.cmbOpcao.Location = new System.Drawing.Point(15, 86);
            this.cmbOpcao.Name = "cmbOpcao";
            this.cmbOpcao.Size = new System.Drawing.Size(179, 23);
            this.cmbOpcao.TabIndex = 6;
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(15, 44);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(179, 23);
            this.textValor.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 182);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOpcao);
            this.Controls.Add(this.textValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOpcao;
        private System.Windows.Forms.TextBox textValor;
    }
}

