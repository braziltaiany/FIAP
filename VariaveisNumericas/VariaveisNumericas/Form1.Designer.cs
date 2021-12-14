
namespace VariaveisNumericas
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
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(12, 35);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(103, 23);
            this.textNum1.TabIndex = 1;
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(148, 35);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(103, 23);
            this.textNum2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número 2";
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(12, 90);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(239, 23);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(11, 208);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(59, 15);
            this.lblRes.TabIndex = 5;
            this.lblRes.Text = "Resultado";
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(11, 119);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(239, 23);
            this.btnSubtrair.TabIndex = 10;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(12, 148);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(239, 23);
            this.btnMultiplicar.TabIndex = 16;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(12, 177);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(239, 23);
            this.btnDividir.TabIndex = 17;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 240);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cálculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
    }
}

