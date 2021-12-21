
namespace Livraria_Heranca
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabPageLivro = new System.Windows.Forms.TabPage();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtEdicao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.Editora = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.Autor = new System.Windows.Forms.Label();
            this.tabPageCD = new System.Windows.Forms.TabPage();
            this.btnVenderCD = new System.Windows.Forms.Button();
            this.btnComprarCD = new System.Windows.Forms.Button();
            this.btnCadastrarCD = new System.Windows.Forms.Button();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGravadora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageDVD = new System.Windows.Forms.TabPage();
            this.btnVenderDVD = new System.Windows.Forms.Button();
            this.btnComprarDVD = new System.Windows.Forms.Button();
            this.btnCadastrarDVD = new System.Windows.Forms.Button();
            this.txtCensura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiretor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCompraVenda = new System.Windows.Forms.TextBox();
            this.tabPage.SuspendLayout();
            this.tabPageLivro.SuspendLayout();
            this.tabPageCD.SuspendLayout();
            this.tabPageDVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição do Produto:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(16, 30);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(346, 20);
            this.txtDesc.TabIndex = 1;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(16, 87);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(346, 20);
            this.txtGenero.TabIndex = 2;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(16, 144);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(163, 20);
            this.txtEstoque.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gênero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Qtde em Estoque:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(205, 144);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(157, 20);
            this.txtPreco.TabIndex = 7;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabPageLivro);
            this.tabPage.Controls.Add(this.tabPageCD);
            this.tabPage.Controls.Add(this.tabPageDVD);
            this.tabPage.Location = new System.Drawing.Point(16, 234);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(350, 227);
            this.tabPage.TabIndex = 8;
            // 
            // tabPageLivro
            // 
            this.tabPageLivro.Controls.Add(this.btnVender);
            this.tabPageLivro.Controls.Add(this.btnComprar);
            this.tabPageLivro.Controls.Add(this.btnCadastrar);
            this.tabPageLivro.Controls.Add(this.txtEdicao);
            this.tabPageLivro.Controls.Add(this.label7);
            this.tabPageLivro.Controls.Add(this.txtEditora);
            this.tabPageLivro.Controls.Add(this.Editora);
            this.tabPageLivro.Controls.Add(this.txtAutor);
            this.tabPageLivro.Controls.Add(this.Autor);
            this.tabPageLivro.Location = new System.Drawing.Point(4, 22);
            this.tabPageLivro.Name = "tabPageLivro";
            this.tabPageLivro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLivro.Size = new System.Drawing.Size(342, 201);
            this.tabPageLivro.TabIndex = 0;
            this.tabPageLivro.Text = "Livro";
            this.tabPageLivro.UseVisualStyleBackColor = true;
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(249, 158);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 23);
            this.btnVender.TabIndex = 8;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(130, 158);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 7;
            this.btnComprar.Text = "comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(7, 158);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtEdicao
            // 
            this.txtEdicao.Location = new System.Drawing.Point(7, 114);
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.Size = new System.Drawing.Size(317, 20);
            this.txtEdicao.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Edição:";
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(7, 67);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(317, 20);
            this.txtEditora.TabIndex = 3;
            // 
            // Editora
            // 
            this.Editora.AutoSize = true;
            this.Editora.Location = new System.Drawing.Point(4, 50);
            this.Editora.Name = "Editora";
            this.Editora.Size = new System.Drawing.Size(40, 13);
            this.Editora.TabIndex = 2;
            this.Editora.Text = "Editora";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(7, 24);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(317, 20);
            this.txtAutor.TabIndex = 1;
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.Location = new System.Drawing.Point(4, 7);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(35, 13);
            this.Autor.TabIndex = 0;
            this.Autor.Text = "Autor:";
            // 
            // tabPageCD
            // 
            this.tabPageCD.Controls.Add(this.btnVenderCD);
            this.tabPageCD.Controls.Add(this.btnComprarCD);
            this.tabPageCD.Controls.Add(this.btnCadastrarCD);
            this.tabPageCD.Controls.Add(this.txtOrigem);
            this.tabPageCD.Controls.Add(this.label5);
            this.tabPageCD.Controls.Add(this.txtGravadora);
            this.tabPageCD.Controls.Add(this.label6);
            this.tabPageCD.Controls.Add(this.txtArtista);
            this.tabPageCD.Controls.Add(this.label8);
            this.tabPageCD.Location = new System.Drawing.Point(4, 22);
            this.tabPageCD.Name = "tabPageCD";
            this.tabPageCD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCD.Size = new System.Drawing.Size(342, 201);
            this.tabPageCD.TabIndex = 1;
            this.tabPageCD.Text = "CD";
            this.tabPageCD.UseVisualStyleBackColor = true;
            // 
            // btnVenderCD
            // 
            this.btnVenderCD.Location = new System.Drawing.Point(241, 164);
            this.btnVenderCD.Name = "btnVenderCD";
            this.btnVenderCD.Size = new System.Drawing.Size(75, 23);
            this.btnVenderCD.TabIndex = 17;
            this.btnVenderCD.Text = "Vender";
            this.btnVenderCD.UseVisualStyleBackColor = true;
            // 
            // btnComprarCD
            // 
            this.btnComprarCD.Location = new System.Drawing.Point(131, 164);
            this.btnComprarCD.Name = "btnComprarCD";
            this.btnComprarCD.Size = new System.Drawing.Size(75, 23);
            this.btnComprarCD.TabIndex = 16;
            this.btnComprarCD.Text = "comprar";
            this.btnComprarCD.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarCD
            // 
            this.btnCadastrarCD.Location = new System.Drawing.Point(14, 164);
            this.btnCadastrarCD.Name = "btnCadastrarCD";
            this.btnCadastrarCD.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarCD.TabIndex = 15;
            this.btnCadastrarCD.Text = "cadastrar";
            this.btnCadastrarCD.UseVisualStyleBackColor = true;
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(14, 120);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(317, 20);
            this.txtOrigem.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "País de Origem:";
            // 
            // txtGravadora
            // 
            this.txtGravadora.Location = new System.Drawing.Point(14, 73);
            this.txtGravadora.Name = "txtGravadora";
            this.txtGravadora.Size = new System.Drawing.Size(317, 20);
            this.txtGravadora.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gravadora:";
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(14, 30);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(317, 20);
            this.txtArtista.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Artista:";
            // 
            // tabPageDVD
            // 
            this.tabPageDVD.Controls.Add(this.btnVenderDVD);
            this.tabPageDVD.Controls.Add(this.btnComprarDVD);
            this.tabPageDVD.Controls.Add(this.btnCadastrarDVD);
            this.tabPageDVD.Controls.Add(this.txtCensura);
            this.tabPageDVD.Controls.Add(this.label9);
            this.tabPageDVD.Controls.Add(this.txtDuracao);
            this.tabPageDVD.Controls.Add(this.label10);
            this.tabPageDVD.Controls.Add(this.txtDiretor);
            this.tabPageDVD.Controls.Add(this.label11);
            this.tabPageDVD.Location = new System.Drawing.Point(4, 22);
            this.tabPageDVD.Name = "tabPageDVD";
            this.tabPageDVD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDVD.Size = new System.Drawing.Size(342, 201);
            this.tabPageDVD.TabIndex = 2;
            this.tabPageDVD.Text = "DVD";
            this.tabPageDVD.UseVisualStyleBackColor = true;
            // 
            // btnVenderDVD
            // 
            this.btnVenderDVD.Location = new System.Drawing.Point(256, 164);
            this.btnVenderDVD.Name = "btnVenderDVD";
            this.btnVenderDVD.Size = new System.Drawing.Size(75, 23);
            this.btnVenderDVD.TabIndex = 26;
            this.btnVenderDVD.Text = "Vender";
            this.btnVenderDVD.UseVisualStyleBackColor = true;
            // 
            // btnComprarDVD
            // 
            this.btnComprarDVD.Location = new System.Drawing.Point(142, 164);
            this.btnComprarDVD.Name = "btnComprarDVD";
            this.btnComprarDVD.Size = new System.Drawing.Size(75, 23);
            this.btnComprarDVD.TabIndex = 25;
            this.btnComprarDVD.Text = "comprar";
            this.btnComprarDVD.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarDVD
            // 
            this.btnCadastrarDVD.Location = new System.Drawing.Point(14, 164);
            this.btnCadastrarDVD.Name = "btnCadastrarDVD";
            this.btnCadastrarDVD.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarDVD.TabIndex = 24;
            this.btnCadastrarDVD.Text = "cadastrar";
            this.btnCadastrarDVD.UseVisualStyleBackColor = true;
            // 
            // txtCensura
            // 
            this.txtCensura.Location = new System.Drawing.Point(14, 120);
            this.txtCensura.Name = "txtCensura";
            this.txtCensura.Size = new System.Drawing.Size(317, 20);
            this.txtCensura.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Censura:";
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(14, 73);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(317, 20);
            this.txtDuracao.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Duração:";
            // 
            // txtDiretor
            // 
            this.txtDiretor.Location = new System.Drawing.Point(14, 30);
            this.txtDiretor.Name = "txtDiretor";
            this.txtDiretor.Size = new System.Drawing.Size(317, 20);
            this.txtDiretor.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Diretor:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Qtde do produto vendido:";
            // 
            // txtCompraVenda
            // 
            this.txtCompraVenda.Location = new System.Drawing.Point(16, 195);
            this.txtCompraVenda.Name = "txtCompraVenda";
            this.txtCompraVenda.Size = new System.Drawing.Size(163, 20);
            this.txtCompraVenda.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 482);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCompraVenda);
            this.Controls.Add(this.tabPage);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage.ResumeLayout(false);
            this.tabPageLivro.ResumeLayout(false);
            this.tabPageLivro.PerformLayout();
            this.tabPageCD.ResumeLayout(false);
            this.tabPageCD.PerformLayout();
            this.tabPageDVD.ResumeLayout(false);
            this.tabPageDVD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabPageLivro;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtEdicao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label Editora;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.TabPage tabPageCD;
        private System.Windows.Forms.Button btnVenderCD;
        private System.Windows.Forms.Button btnComprarCD;
        private System.Windows.Forms.Button btnCadastrarCD;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGravadora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPageDVD;
        private System.Windows.Forms.Button btnVenderDVD;
        private System.Windows.Forms.Button btnComprarDVD;
        private System.Windows.Forms.Button btnCadastrarDVD;
        private System.Windows.Forms.TextBox txtCensura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiretor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCompraVenda;
    }
}

