
namespace IfEncadeado
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
            this.btnChecar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textIdade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChecar
            // 
            this.btnChecar.Location = new System.Drawing.Point(35, 75);
            this.btnChecar.Name = "btnChecar";
            this.btnChecar.Size = new System.Drawing.Size(158, 23);
            this.btnChecar.TabIndex = 0;
            this.btnChecar.Text = "Checar embarque";
            this.btnChecar.UseVisualStyleBackColor = true;
            this.btnChecar.Click += new System.EventHandler(this.btnChecar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Idade:";
            // 
            // textIdade
            // 
            this.textIdade.Location = new System.Drawing.Point(93, 36);
            this.textIdade.Name = "textIdade";
            this.textIdade.Size = new System.Drawing.Size(100, 23);
            this.textIdade.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 132);
            this.Controls.Add(this.textIdade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChecar);
            this.Name = "Form1";
            this.Text = "Checar embarque";
            this.TransparencyKey = System.Drawing.Color.MistyRose;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChecar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIdade;
    }
}

