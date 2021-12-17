
namespace MatrizDesafio2_SomaMediaMultip
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
            this.btnMult = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(37, 109);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(246, 23);
            this.btnMult.TabIndex = 5;
            this.btnMult.Text = "Multiplicar elemento linha 3";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(37, 79);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(246, 23);
            this.btnMedia.TabIndex = 4;
            this.btnMedia.Text = "Média da linha 2";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(37, 49);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(246, 23);
            this.btnSoma.TabIndex = 3;
            this.btnSoma.Text = "Soma linha 1";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(37, 158);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(246, 108);
            this.lstResultado.TabIndex = 6;
            // 
            // btnMatriz
            // 
            this.btnMatriz.Location = new System.Drawing.Point(37, 20);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(246, 23);
            this.btnMatriz.TabIndex = 7;
            this.btnMatriz.Text = "Exibir Matriz";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 307);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnSoma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Button btnMatriz;
    }
}

