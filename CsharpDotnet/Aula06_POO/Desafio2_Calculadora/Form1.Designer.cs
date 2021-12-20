
namespace Desafio2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRes = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cmbOperacoes = new System.Windows.Forms.ComboBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(27, 158);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(35, 13);
            this.lblRes.TabIndex = 9;
            this.lblRes.Text = "label1";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(27, 117);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(206, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cmbOperacoes
            // 
            this.cmbOperacoes.FormattingEnabled = true;
            this.cmbOperacoes.Items.AddRange(new object[] {
            "somar",
            "subtrair",
            "multiplicar",
            "dividir"});
            this.cmbOperacoes.Location = new System.Drawing.Point(27, 89);
            this.cmbOperacoes.Name = "cmbOperacoes";
            this.cmbOperacoes.Size = new System.Drawing.Size(121, 21);
            this.cmbOperacoes.TabIndex = 7;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(133, 49);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 20);
            this.txtN2.TabIndex = 6;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(27, 49);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 20);
            this.txtN1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 220);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cmbOperacoes);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cmbOperacoes;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
    }
}

