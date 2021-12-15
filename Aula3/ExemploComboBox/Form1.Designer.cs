
namespace Aula3
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
            this.btnEscolha = new System.Windows.Forms.Button();
            this.cbmEscolha = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEscolha
            // 
            this.btnEscolha.Location = new System.Drawing.Point(12, 66);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(226, 23);
            this.btnEscolha.TabIndex = 1;
            this.btnEscolha.Text = "Confirmar Escolha";
            this.btnEscolha.UseVisualStyleBackColor = true;
            this.btnEscolha.Click += new System.EventHandler(this.btnEscolha_Click);
            // 
            // cbmEscolha
            // 
            this.cbmEscolha.FormattingEnabled = true;
            this.cbmEscolha.Items.AddRange(new object[] {
            "Ferrari",
            "Mercedes",
            "Redbull",
            "McLaren"});
            this.cbmEscolha.Location = new System.Drawing.Point(12, 27);
            this.cbmEscolha.Name = "cbmEscolha";
            this.cbmEscolha.Size = new System.Drawing.Size(226, 23);
            this.cbmEscolha.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 101);
            this.Controls.Add(this.cbmEscolha);
            this.Controls.Add(this.btnEscolha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEscolha;
        private System.Windows.Forms.ComboBox cbmEscolha;
    }
}

