
namespace ResolucaoExer1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textNota1 = new System.Windows.Forms.TextBox();
            this.textNota2 = new System.Windows.Forms.TextBox();
            this.textNota3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textNota3);
            this.groupBox1.Controls.Add(this.textNota2);
            this.groupBox1.Controls.Add(this.textNota1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digite 3 notas:";
            // 
            // textNota1
            // 
            this.textNota1.Location = new System.Drawing.Point(55, 22);
            this.textNota1.Name = "textNota1";
            this.textNota1.Size = new System.Drawing.Size(100, 23);
            this.textNota1.TabIndex = 0;
            // 
            // textNota2
            // 
            this.textNota2.Location = new System.Drawing.Point(55, 53);
            this.textNota2.Name = "textNota2";
            this.textNota2.Size = new System.Drawing.Size(100, 23);
            this.textNota2.TabIndex = 1;
            // 
            // textNota3
            // 
            this.textNota3.Location = new System.Drawing.Point(55, 82);
            this.textNota3.Name = "textNota3";
            this.textNota3.Size = new System.Drawing.Size(100, 23);
            this.textNota3.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 142);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(200, 23);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Verificar Situação";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 188);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textNota3;
        private System.Windows.Forms.TextBox textNota2;
        private System.Windows.Forms.TextBox textNota1;
        private System.Windows.Forms.Button btnCalcular;
    }
}

