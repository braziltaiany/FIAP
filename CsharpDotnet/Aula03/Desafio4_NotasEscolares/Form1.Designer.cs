
namespace Desafio4_NotasEscolares
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textNota1 = new System.Windows.Forms.TextBox();
            this.textNota2 = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textAulasDadas = new System.Windows.Forms.TextBox();
            this.textAulasAssistidas = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textNota2);
            this.groupBox1.Controls.Add(this.textNota1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digite suas notas: ";
            // 
            // textNota1
            // 
            this.textNota1.Location = new System.Drawing.Point(7, 23);
            this.textNota1.Name = "textNota1";
            this.textNota1.Size = new System.Drawing.Size(187, 23);
            this.textNota1.TabIndex = 0;
            // 
            // textNota2
            // 
            this.textNota2.Location = new System.Drawing.Point(7, 62);
            this.textNota2.Name = "textNota2";
            this.textNota2.Size = new System.Drawing.Size(187, 23);
            this.textNota2.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(19, 257);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(187, 23);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar Situação";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantidade de aulas dadas: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade de aulas assistidas: ";
            // 
            // textAulasDadas
            // 
            this.textAulasDadas.Location = new System.Drawing.Point(19, 149);
            this.textAulasDadas.Name = "textAulasDadas";
            this.textAulasDadas.Size = new System.Drawing.Size(187, 23);
            this.textAulasDadas.TabIndex = 4;
            // 
            // textAulasAssistidas
            // 
            this.textAulasAssistidas.Location = new System.Drawing.Point(19, 199);
            this.textAulasAssistidas.Name = "textAulasAssistidas";
            this.textAulasAssistidas.Size = new System.Drawing.Size(187, 23);
            this.textAulasAssistidas.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 304);
            this.Controls.Add(this.textAulasAssistidas);
            this.Controls.Add(this.textAulasDadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textNota2;
        private System.Windows.Forms.TextBox textNota1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAulasDadas;
        private System.Windows.Forms.TextBox textAulasAssistidas;
    }
}

