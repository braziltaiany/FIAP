
namespace Desafio1_OrdemInversa
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lstVetorB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 96);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(107, 64);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Inverter";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lstVetorB
            // 
            this.lstVetorB.FormattingEnabled = true;
            this.lstVetorB.Location = new System.Drawing.Point(157, 8);
            this.lstVetorB.Name = "lstVetorB";
            this.lstVetorB.Size = new System.Drawing.Size(120, 238);
            this.lstVetorB.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 274);
            this.Controls.Add(this.lstVetorB);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ListBox lstVetorB;
    }
}

