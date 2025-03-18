namespace VarejoConnect.View
{
    partial class ProdutoPage
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
            BtnEditar = new Button();
            label6 = new Label();
            PesquisarTextBox = new TextBox();
            BtnPesquisar = new Button();
            BtnExcluir = new Button();
            BtnSalvar = new Button();
            groupBox1 = new GroupBox();
            label10 = new Label();
            RelatorioTextBox = new TextBox();
            button1 = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            SearchOptions = new ComboBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            quantidadeTextBox = new TextBox();
            btnAtt = new Button();
            groupBox3 = new GroupBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.FromArgb(121, 182, 201);
            BtnEditar.FlatAppearance.BorderSize = 0;
            BtnEditar.FlatStyle = FlatStyle.Popup;
            BtnEditar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditar.ForeColor = Color.White;
            BtnEditar.Location = new Point(13, 22);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(107, 36);
            BtnEditar.TabIndex = 28;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 32);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 13;
            label6.Text = "Pesquisar:";
            // 
            // PesquisarTextBox
            // 
            PesquisarTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PesquisarTextBox.Location = new Point(88, 30);
            PesquisarTextBox.Name = "PesquisarTextBox";
            PesquisarTextBox.Size = new Size(308, 20);
            PesquisarTextBox.TabIndex = 4;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.BackColor = Color.FromArgb(121, 182, 201);
            BtnPesquisar.FlatAppearance.BorderSize = 0;
            BtnPesquisar.FlatStyle = FlatStyle.Popup;
            BtnPesquisar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPesquisar.ForeColor = Color.White;
            BtnPesquisar.Location = new Point(428, 22);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(130, 35);
            BtnPesquisar.TabIndex = 26;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = false;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // BtnExcluir
            // 
            BtnExcluir.BackColor = Color.FromArgb(250, 90, 110);
            BtnExcluir.FlatAppearance.BorderSize = 0;
            BtnExcluir.FlatStyle = FlatStyle.Popup;
            BtnExcluir.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExcluir.ForeColor = Color.White;
            BtnExcluir.Location = new Point(129, 22);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(107, 36);
            BtnExcluir.TabIndex = 25;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = false;
            BtnExcluir.Click += BtnInativar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = Color.FromArgb(100, 250, 140);
            BtnSalvar.FlatAppearance.BorderSize = 0;
            BtnSalvar.FlatStyle = FlatStyle.Popup;
            BtnSalvar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalvar.ForeColor = Color.White;
            BtnSalvar.Location = new Point(244, 22);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(107, 36);
            BtnSalvar.TabIndex = 24;
            BtnSalvar.Text = "Cadastrar";
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(BtnEditar);
            groupBox1.Controls.Add(RelatorioTextBox);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(BtnExcluir);
            groupBox1.Controls.Add(BtnSalvar);
            groupBox1.Location = new Point(24, 434);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 201);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(89, 92);
            label10.Name = "label10";
            label10.Size = new Size(180, 15);
            label10.TabIndex = 36;
            label10.Text = "Gerar Relatorio PDF Por Nome:";
            // 
            // RelatorioTextBox
            // 
            RelatorioTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RelatorioTextBox.Location = new Point(59, 110);
            RelatorioTextBox.Name = "RelatorioTextBox";
            RelatorioTextBox.Size = new Size(240, 20);
            RelatorioTextBox.TabIndex = 35;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(121, 182, 201);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(104, 150);
            button1.Name = "button1";
            button1.Size = new Size(149, 33);
            button1.TabIndex = 34;
            button1.Text = "Gerar Relatorio";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(121, 182, 201);
            label2.Location = new Point(26, 14);
            label2.Name = "label2";
            label2.Size = new Size(230, 29);
            label2.TabIndex = 22;
            label2.Text = "Cadastro Produtos";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(980, 373);
            dataGridView1.TabIndex = 21;
            // 
            // SearchOptions
            // 
            SearchOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            SearchOptions.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchOptions.FormattingEnabled = true;
            SearchOptions.Items.AddRange(new object[] { "SEM FILTRO", "NOME", "ID", "MARCA" });
            SearchOptions.Location = new Point(241, 66);
            SearchOptions.Name = "SearchOptions";
            SearchOptions.Size = new Size(160, 23);
            SearchOptions.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 69);
            label7.Name = "label7";
            label7.Size = new Size(184, 15);
            label7.TabIndex = 19;
            label7.Text = "Selecione um metodo de busca:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SearchOptions);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(BtnPesquisar);
            groupBox2.Controls.Add(PesquisarTextBox);
            groupBox2.Location = new Point(387, 434);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(617, 112);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pesquisa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(253, 49);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 28;
            label8.Text = "Quantidade:";
            // 
            // quantidadeTextBox
            // 
            quantidadeTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantidadeTextBox.Location = new Point(325, 47);
            quantidadeTextBox.Name = "quantidadeTextBox";
            quantidadeTextBox.Size = new Size(93, 20);
            quantidadeTextBox.TabIndex = 27;
            // 
            // btnAtt
            // 
            btnAtt.BackColor = Color.FromArgb(121, 182, 201);
            btnAtt.FlatAppearance.BorderSize = 0;
            btnAtt.FlatStyle = FlatStyle.Popup;
            btnAtt.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtt.ForeColor = Color.White;
            btnAtt.Location = new Point(424, 43);
            btnAtt.Name = "btnAtt";
            btnAtt.Size = new Size(175, 27);
            btnAtt.TabIndex = 29;
            btnAtt.Text = "Atualizar Quantidade";
            btnAtt.UseVisualStyleBackColor = false;
            btnAtt.Click += btnAtt_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(btnAtt);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(quantidadeTextBox);
            groupBox3.Location = new Point(387, 552);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(617, 83);
            groupBox3.TabIndex = 30;
            groupBox3.TabStop = false;
            groupBox3.Text = "Quantidade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 19);
            label9.Name = "label9";
            label9.Size = new Size(204, 30);
            label9.TabIndex = 30;
            label9.Text = "Atualize a quantidade inserindo o \r\nnumero de itens a mais ou a menos";
            // 
            // ProdutoPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 647);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProdutoPage";
            Text = "ProdutoPage";
            Load += ProdutoPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEditar;
        private Label label6;
        private TextBox PesquisarTextBox;
        private Button BtnPesquisar;
        private Button BtnExcluir;
        private Button BtnSalvar;
        private GroupBox groupBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private ComboBox SearchOptions;
        private Label label7;
        private GroupBox groupBox2;
        private Label label8;
        private TextBox quantidadeTextBox;
        private Button btnAtt;
        private GroupBox groupBox3;
        private Label label9;
        private Label label10;
        private TextBox RelatorioTextBox;
        private Button button1;
    }
}