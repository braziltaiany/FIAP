
namespace OperaoesComVetores
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
            this.btnTamanho = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnInverter = new System.Windows.Forms.Button();
            this.btnBuscaBinaria = new System.Windows.Forms.Button();
            this.btnIndice = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTamanho
            // 
            this.btnTamanho.Location = new System.Drawing.Point(43, 26);
            this.btnTamanho.Name = "btnTamanho";
            this.btnTamanho.Size = new System.Drawing.Size(246, 23);
            this.btnTamanho.TabIndex = 0;
            this.btnTamanho.Text = "Tamanho do Array";
            this.btnTamanho.UseVisualStyleBackColor = true;
            this.btnTamanho.Click += new System.EventHandler(this.btnTamanho_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(43, 56);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(246, 23);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar o Array";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnInverter
            // 
            this.btnInverter.Location = new System.Drawing.Point(43, 86);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(246, 23);
            this.btnInverter.TabIndex = 2;
            this.btnInverter.Text = "Inverter o Array";
            this.btnInverter.UseVisualStyleBackColor = true;
            this.btnInverter.Click += new System.EventHandler(this.btnInverter_Click);
            // 
            // btnBuscaBinaria
            // 
            this.btnBuscaBinaria.Location = new System.Drawing.Point(43, 116);
            this.btnBuscaBinaria.Name = "btnBuscaBinaria";
            this.btnBuscaBinaria.Size = new System.Drawing.Size(246, 23);
            this.btnBuscaBinaria.TabIndex = 3;
            this.btnBuscaBinaria.Text = "Busca Binária";
            this.btnBuscaBinaria.UseVisualStyleBackColor = true;
            this.btnBuscaBinaria.Click += new System.EventHandler(this.btnBuscaBinaria_Click);
            // 
            // btnIndice
            // 
            this.btnIndice.Location = new System.Drawing.Point(43, 146);
            this.btnIndice.Name = "btnIndice";
            this.btnIndice.Size = new System.Drawing.Size(246, 23);
            this.btnIndice.TabIndex = 4;
            this.btnIndice.Text = "Obtendo o Indice";
            this.btnIndice.UseVisualStyleBackColor = true;
            this.btnIndice.Click += new System.EventHandler(this.btnIndice_Click);
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(43, 187);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(246, 160);
            this.lstResultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 368);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.btnIndice);
            this.Controls.Add(this.btnBuscaBinaria);
            this.Controls.Add(this.btnInverter);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnTamanho);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTamanho;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.Button btnBuscaBinaria;
        private System.Windows.Forms.Button btnIndice;
        private System.Windows.Forms.ListBox lstResultado;
    }
}

