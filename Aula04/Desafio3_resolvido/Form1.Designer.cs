
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
            this.lblRes = new System.Windows.Forms.Label();
            this.btnPares = new System.Windows.Forms.Button();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(23, 162);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(38, 15);
            this.lblRes.TabIndex = 9;
            this.lblRes.Text = "label2";
            // 
            // btnPares
            // 
            this.btnPares.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPares.Location = new System.Drawing.Point(23, 82);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(327, 42);
            this.btnPares.TabIndex = 8;
            this.btnPares.Text = "Quantidade de Pares";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(250, 29);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 23);
            this.txtN2.TabIndex = 7;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(141, 29);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 23);
            this.txtN1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite dois números:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 204);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label label1;
    }
}

