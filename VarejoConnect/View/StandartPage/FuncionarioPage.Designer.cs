namespace VarejoConnect.View
{
    partial class FuncionarioPage
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label10 = new Label();
            RelatorioTextBox = new TextBox();
            button1 = new Button();
            LoginTextBox = new TextBox();
            label9 = new Label();
            BtnEditar = new Button();
            ConfirmarSenhaTextBox = new TextBox();
            label8 = new Label();
            SalarioTextBox = new TextBox();
            BtnInativar = new Button();
            label5 = new Label();
            BtnSalvar = new Button();
            CargoTextBox = new TextBox();
            label4 = new Label();
            SenhaTextBox = new TextBox();
            label3 = new Label();
            NomeTextBox = new TextBox();
            label1 = new Label();
            PesquisarTextBox = new TextBox();
            label6 = new Label();
            BtnPesquisar = new Button();
            groupBox2 = new GroupBox();
            SearchOptions = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(352, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(652, 373);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(121, 182, 201);
            label2.Location = new Point(25, 3);
            label2.Name = "label2";
            label2.Size = new Size(276, 29);
            label2.TabIndex = 9;
            label2.Text = "Cadastro Funcionários";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(RelatorioTextBox);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(LoginTextBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(BtnEditar);
            groupBox1.Controls.Add(ConfirmarSenhaTextBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(SalarioTextBox);
            groupBox1.Controls.Add(BtnInativar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(BtnSalvar);
            groupBox1.Controls.Add(CargoTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(SenhaTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(NomeTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 580);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(76, 478);
            label10.Name = "label10";
            label10.Size = new Size(180, 15);
            label10.TabIndex = 36;
            label10.Text = "Gerar Relatorio PDF Por Nome:";
            // 
            // RelatorioTextBox
            // 
            RelatorioTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RelatorioTextBox.Location = new Point(46, 496);
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
            button1.Location = new Point(91, 536);
            button1.Name = "button1";
            button1.Size = new Size(149, 33);
            button1.TabIndex = 34;
            button1.Text = "Gerar Relatorio";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginTextBox.Location = new Point(76, 121);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(237, 20);
            LoginTextBox.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(23, 123);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 31;
            label9.Text = "Login:";
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.FromArgb(121, 182, 201);
            BtnEditar.FlatAppearance.BorderSize = 0;
            BtnEditar.FlatStyle = FlatStyle.Popup;
            BtnEditar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditar.ForeColor = Color.White;
            BtnEditar.Location = new Point(65, 403);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(208, 57);
            BtnEditar.TabIndex = 20;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // ConfirmarSenhaTextBox
            // 
            ConfirmarSenhaTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmarSenhaTextBox.Location = new Point(135, 185);
            ConfirmarSenhaTextBox.Name = "ConfirmarSenhaTextBox";
            ConfirmarSenhaTextBox.Size = new Size(177, 20);
            ConfirmarSenhaTextBox.TabIndex = 9;
            ConfirmarSenhaTextBox.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(23, 187);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 8;
            label8.Text = "Confirmar senha:";
            // 
            // SalarioTextBox
            // 
            SalarioTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SalarioTextBox.Location = new Point(76, 56);
            SalarioTextBox.Name = "SalarioTextBox";
            SalarioTextBox.Size = new Size(237, 20);
            SalarioTextBox.TabIndex = 7;
            // 
            // BtnInativar
            // 
            BtnInativar.BackColor = Color.FromArgb(121, 182, 201);
            BtnInativar.FlatAppearance.BorderSize = 0;
            BtnInativar.FlatStyle = FlatStyle.Popup;
            BtnInativar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnInativar.ForeColor = Color.White;
            BtnInativar.Location = new Point(65, 322);
            BtnInativar.Name = "BtnInativar";
            BtnInativar.Size = new Size(208, 57);
            BtnInativar.TabIndex = 12;
            BtnInativar.Text = "Excluir";
            BtnInativar.UseVisualStyleBackColor = false;
            BtnInativar.Click += BtnInativar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 58);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 6;
            label5.Text = "Salario:";
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = Color.FromArgb(121, 182, 201);
            BtnSalvar.FlatAppearance.BorderSize = 0;
            BtnSalvar.FlatStyle = FlatStyle.Popup;
            BtnSalvar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalvar.ForeColor = Color.White;
            BtnSalvar.Location = new Point(65, 243);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(208, 57);
            BtnSalvar.TabIndex = 11;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += button1_Click;
            // 
            // CargoTextBox
            // 
            CargoTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CargoTextBox.Location = new Point(75, 87);
            CargoTextBox.Name = "CargoTextBox";
            CargoTextBox.Size = new Size(237, 20);
            CargoTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 89);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "Cargo:";
            // 
            // SenhaTextBox
            // 
            SenhaTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SenhaTextBox.Location = new Point(75, 153);
            SenhaTextBox.Name = "SenhaTextBox";
            SenhaTextBox.Size = new Size(237, 20);
            SenhaTextBox.TabIndex = 3;
            SenhaTextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 155);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // NomeTextBox
            // 
            NomeTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NomeTextBox.Location = new Point(76, 24);
            NomeTextBox.Name = "NomeTextBox";
            NomeTextBox.Size = new Size(237, 20);
            NomeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // PesquisarTextBox
            // 
            PesquisarTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PesquisarTextBox.Location = new Point(92, 29);
            PesquisarTextBox.Name = "PesquisarTextBox";
            PesquisarTextBox.Size = new Size(247, 20);
            PesquisarTextBox.TabIndex = 14;
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
            // BtnPesquisar
            // 
            BtnPesquisar.BackColor = Color.FromArgb(121, 182, 201);
            BtnPesquisar.FlatAppearance.BorderSize = 0;
            BtnPesquisar.FlatStyle = FlatStyle.Popup;
            BtnPesquisar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPesquisar.ForeColor = Color.White;
            BtnPesquisar.Location = new Point(376, 22);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(149, 33);
            BtnPesquisar.TabIndex = 15;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = false;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SearchOptions);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(BtnPesquisar);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(PesquisarTextBox);
            groupBox2.Location = new Point(352, 434);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(652, 197);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pesquisa";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // SearchOptions
            // 
            SearchOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            SearchOptions.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchOptions.FormattingEnabled = true;
            SearchOptions.Items.AddRange(new object[] { "SEM FILTRO", "NOME", "ID", "CARGO" });
            SearchOptions.Location = new Point(242, 65);
            SearchOptions.Name = "SearchOptions";
            SearchOptions.Size = new Size(160, 23);
            SearchOptions.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 67);
            label7.Name = "label7";
            label7.Size = new Size(184, 15);
            label7.TabIndex = 19;
            label7.Text = "Selecione um metodo de busca:";
            // 
            // FuncionarioPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 647);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FuncionarioPage";
            Text = " ";
            Load += FuncionarioPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox CargoTextBox;
        private Label label4;
        private TextBox NomeTextBox;
        private Label label1;
        private TextBox SalarioTextBox;
        private Label label5;
        private Button BtnSalvar;
        private Button BtnInativar;
        private TextBox PesquisarTextBox;
        private Label label6;
        private Button BtnPesquisar;
        private GroupBox groupBox2;
        private Label label7;
        private TextBox ConfirmarSenhaTextBox;
        private Label label8;
        private TextBox SenhaTextBox;
        private Label label3;
        private Button BtnEditar;
        private DataGridViewTextBoxColumn FuncId;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Salario;
        private DataGridViewTextBoxColumn Senha;
        private DataGridViewTextBoxColumn dataCriacao;
        private DataGridViewTextBoxColumn dataAlteracao;
        private DataGridViewTextBoxColumn FuncAlterado;
        private ComboBox SearchOptions;
        private TextBox LoginTextBox;
        private Label label9;
        private Label label10;
        private TextBox RelatorioTextBox;
        private Button button1;
    }
}