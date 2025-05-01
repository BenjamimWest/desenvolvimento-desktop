namespace MultApps.Windows
{
    partial class Gestao_de_Produtos
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmCategoria = new System.Windows.Forms.ComboBox();
            this.btnNovo_Produto = new System.Windows.Forms.Button();
            this.btnAtualizar_Grid = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome_do_ProdutoCadrastro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategoria_Cadastro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUrl_da_Imagem = new System.Windows.Forms.TextBox();
            this.chkInativo = new System.Windows.Forms.CheckBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Imagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTÃO DE PRODUTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cmbStatus.Location = new System.Drawing.Point(19, 96);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(116, 24);
            this.cmbStatus.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoria";
            // 
            // cbmCategoria
            // 
            this.cbmCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbmCategoria.FormattingEnabled = true;
            this.cbmCategoria.Items.AddRange(new object[] {
            "Todas",
            " Eletrônicos ",
            "Roupas"});
            this.cbmCategoria.Location = new System.Drawing.Point(203, 96);
            this.cbmCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbmCategoria.Name = "cbmCategoria";
            this.cbmCategoria.Size = new System.Drawing.Size(121, 24);
            this.cbmCategoria.TabIndex = 4;
            // 
            // btnNovo_Produto
            // 
            this.btnNovo_Produto.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo_Produto.Location = new System.Drawing.Point(358, 96);
            this.btnNovo_Produto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNovo_Produto.Name = "btnNovo_Produto";
            this.btnNovo_Produto.Size = new System.Drawing.Size(150, 26);
            this.btnNovo_Produto.TabIndex = 5;
            this.btnNovo_Produto.Text = "+ NOVO PRODUTO ";
            this.btnNovo_Produto.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar_Grid
            // 
            this.btnAtualizar_Grid.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar_Grid.Location = new System.Drawing.Point(552, 96);
            this.btnAtualizar_Grid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizar_Grid.Name = "btnAtualizar_Grid";
            this.btnAtualizar_Grid.Size = new System.Drawing.Size(172, 26);
            this.btnAtualizar_Grid.TabIndex = 6;
            this.btnAtualizar_Grid.Text = "ATUALIZAR GRID";
            this.btnAtualizar_Grid.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 339);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "CADASTRO/EDIÇÃO DO PRODUTO";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalvar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(4, 817);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(125, 39);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(135, 817);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "LIMPAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(280, 817);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 39);
            this.button2.TabIndex = 11;
            this.button2.Text = "EXCLUIR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 390);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nome do Produto*";
            // 
            // txtNome_do_ProdutoCadrastro
            // 
            this.txtNome_do_ProdutoCadrastro.Location = new System.Drawing.Point(64, 413);
            this.txtNome_do_ProdutoCadrastro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNome_do_ProdutoCadrastro.Multiline = true;
            this.txtNome_do_ProdutoCadrastro.Name = "txtNome_do_ProdutoCadrastro";
            this.txtNome_do_ProdutoCadrastro.Size = new System.Drawing.Size(364, 39);
            this.txtNome_do_ProdutoCadrastro.TabIndex = 13;
            this.txtNome_do_ProdutoCadrastro.Text = "\" \"";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(616, 390);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Categoria*";
            // 
            // cmbCategoria_Cadastro
            // 
            this.cmbCategoria_Cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCategoria_Cadastro.FormattingEnabled = true;
            this.cmbCategoria_Cadastro.Items.AddRange(new object[] {
            "Eletrônica",
            "Lazer",
            "Eletro-Domestico"});
            this.cmbCategoria_Cadastro.Location = new System.Drawing.Point(620, 413);
            this.cmbCategoria_Cadastro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbCategoria_Cadastro.Name = "cmbCategoria_Cadastro";
            this.cmbCategoria_Cadastro.Size = new System.Drawing.Size(259, 24);
            this.cmbCategoria_Cadastro.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 493);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Descrição*";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(68, 517);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(798, 106);
            this.txtDescricao.TabIndex = 17;
            this.txtDescricao.Text = "\" \"";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 642);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Preço*";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(64, 671);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPreco.Multiline = true;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(364, 38);
            this.txtPreco.TabIndex = 19;
            this.txtPreco.Text = "\" \"";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(538, 642);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Estoque*";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(541, 671);
            this.txtEstoque.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEstoque.Multiline = true;
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(325, 38);
            this.txtEstoque.TabIndex = 22;
            this.txtEstoque.Text = "\" \"";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(77, 727);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "URL da Imagem";
            // 
            // txtUrl_da_Imagem
            // 
            this.txtUrl_da_Imagem.Location = new System.Drawing.Point(78, 753);
            this.txtUrl_da_Imagem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUrl_da_Imagem.Multiline = true;
            this.txtUrl_da_Imagem.Name = "txtUrl_da_Imagem";
            this.txtUrl_da_Imagem.Size = new System.Drawing.Size(350, 38);
            this.txtUrl_da_Imagem.TabIndex = 24;
            this.txtUrl_da_Imagem.Text = "\" \"";
            // 
            // chkInativo
            // 
            this.chkInativo.AutoSize = true;
            this.chkInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInativo.ForeColor = System.Drawing.Color.Gray;
            this.chkInativo.Location = new System.Drawing.Point(660, 771);
            this.chkInativo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkInativo.Name = "chkInativo";
            this.chkInativo.Size = new System.Drawing.Size(136, 41);
            this.chkInativo.TabIndex = 26;
            this.chkInativo.Text = "Inativo";
            this.chkInativo.UseVisualStyleBackColor = true;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.ForeColor = System.Drawing.Color.Orange;
            this.chkAtivo.Location = new System.Drawing.Point(523, 771);
            this.chkAtivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(112, 41);
            this.chkAtivo.TabIndex = 25;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(458, 790);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 18);
            this.label11.TabIndex = 27;
            this.label11.Text = "Status:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imagem,
            this.Id,
            this.Nome,
            this.Categoria,
            this.Preço,
            this.Estoque,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(122, 158);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 131);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Imagem
            // 
            this.Imagem.HeaderText = "IMAGEM";
            this.Imagem.Name = "Imagem";
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "NOME";
            this.Nome.Name = "Nome";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "CATEGORIA";
            this.Categoria.Name = "Categoria";
            // 
            // Preço
            // 
            this.Preço.HeaderText = "PREÇO";
            this.Preço.Name = "Preço";
            // 
            // Estoque
            // 
            this.Estoque.HeaderText = "ESTOQUE";
            this.Estoque.Name = "Estoque";
            // 
            // Status
            // 
            this.Status.HeaderText = "STATUS";
            this.Status.Name = "Status";
            // 
            // Gestao_de_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 749);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chkInativo);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.txtUrl_da_Imagem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCategoria_Cadastro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNome_do_ProdutoCadrastro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAtualizar_Grid);
            this.Controls.Add(this.btnNovo_Produto);
            this.Controls.Add(this.cbmCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Gestao_de_Produtos";
            this.Text = "Gestao_de_Produtos";
            this.Load += new System.EventHandler(this.Gestao_de_Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmCategoria;
        private System.Windows.Forms.Button btnNovo_Produto;
        private System.Windows.Forms.Button btnAtualizar_Grid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome_do_ProdutoCadrastro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCategoria_Cadastro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUrl_da_Imagem;
        private System.Windows.Forms.CheckBox chkInativo;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}