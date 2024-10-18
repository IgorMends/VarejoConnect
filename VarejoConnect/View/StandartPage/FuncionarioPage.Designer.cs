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
            ConfirmarSenhaTextBox = new TextBox();
            label8 = new Label();
            SalarioTextBox = new TextBox();
            label5 = new Label();
            CargoTextBox = new TextBox();
            label4 = new Label();
            SenhaTextBox = new TextBox();
            label3 = new Label();
            NomeTextBox = new TextBox();
            label1 = new Label();
            BtnSalvar = new Button();
            BtnInativar = new Button();
            PesquisarTextBox = new TextBox();
            label6 = new Label();
            BtnPesquisar = new Button();
            IDRadio = new RadioButton();
            CargoRadio = new RadioButton();
            NomeRadio = new RadioButton();
            groupBox2 = new GroupBox();
            label7 = new Label();
            BtnEditar = new Button();
            TodosRadio = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(947, 356);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(121, 182, 201);
            label2.Location = new Point(25, 3);
            label2.Name = "label2";
            label2.Size = new Size(273, 28);
            label2.TabIndex = 9;
            label2.Text = "Cadastro Funcionários";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ConfirmarSenhaTextBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(SalarioTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(CargoTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(SenhaTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(NomeTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 419);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(673, 140);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // ConfirmarSenhaTextBox
            // 
            ConfirmarSenhaTextBox.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmarSenhaTextBox.Location = new Point(247, 98);
            ConfirmarSenhaTextBox.Name = "ConfirmarSenhaTextBox";
            ConfirmarSenhaTextBox.Size = new Size(247, 21);
            ConfirmarSenhaTextBox.TabIndex = 9;
            ConfirmarSenhaTextBox.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(139, 100);
            label8.Name = "label8";
            label8.Size = new Size(107, 17);
            label8.TabIndex = 8;
            label8.Text = "Confirmar senha:";
            // 
            // SalarioTextBox
            // 
            SalarioTextBox.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SalarioTextBox.Location = new Point(76, 56);
            SalarioTextBox.Name = "SalarioTextBox";
            SalarioTextBox.Size = new Size(247, 21);
            SalarioTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 58);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 6;
            label5.Text = "Salario:";
            // 
            // CargoTextBox
            // 
            CargoTextBox.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CargoTextBox.Location = new Point(404, 24);
            CargoTextBox.Name = "CargoTextBox";
            CargoTextBox.Size = new Size(247, 21);
            CargoTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(351, 26);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 4;
            label4.Text = "Cargo:";
            // 
            // SenhaTextBox
            // 
            SenhaTextBox.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SenhaTextBox.Location = new Point(404, 56);
            SenhaTextBox.Name = "SenhaTextBox";
            SenhaTextBox.Size = new Size(247, 21);
            SenhaTextBox.TabIndex = 3;
            SenhaTextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(351, 58);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // NomeTextBox
            // 
            NomeTextBox.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NomeTextBox.Location = new Point(76, 24);
            NomeTextBox.Name = "NomeTextBox";
            NomeTextBox.Size = new Size(247, 21);
            NomeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = Color.FromArgb(121, 182, 201);
            BtnSalvar.FlatAppearance.BorderSize = 0;
            BtnSalvar.FlatStyle = FlatStyle.Popup;
            BtnSalvar.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalvar.ForeColor = Color.White;
            BtnSalvar.Location = new Point(27, 565);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(208, 57);
            BtnSalvar.TabIndex = 11;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += button1_Click;
            // 
            // BtnInativar
            // 
            BtnInativar.BackColor = Color.FromArgb(121, 182, 201);
            BtnInativar.FlatAppearance.BorderSize = 0;
            BtnInativar.FlatStyle = FlatStyle.Popup;
            BtnInativar.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnInativar.ForeColor = Color.White;
            BtnInativar.Location = new Point(284, 565);
            BtnInativar.Name = "BtnInativar";
            BtnInativar.Size = new Size(208, 57);
            BtnInativar.TabIndex = 12;
            BtnInativar.Text = "Inativar";
            BtnInativar.UseVisualStyleBackColor = false;
            BtnInativar.Click += BtnInativar_Click;
            // 
            // PesquisarTextBox
            // 
            PesquisarTextBox.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PesquisarTextBox.Location = new Point(81, 22);
            PesquisarTextBox.Name = "PesquisarTextBox";
            PesquisarTextBox.Size = new Size(247, 21);
            PesquisarTextBox.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 24);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 13;
            label6.Text = "Pesquisar:";
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.BackColor = Color.FromArgb(121, 182, 201);
            BtnPesquisar.FlatAppearance.BorderSize = 0;
            BtnPesquisar.FlatStyle = FlatStyle.Popup;
            BtnPesquisar.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPesquisar.ForeColor = Color.White;
            BtnPesquisar.Location = new Point(795, 565);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(208, 57);
            BtnPesquisar.TabIndex = 15;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = false;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // IDRadio
            // 
            IDRadio.AutoSize = true;
            IDRadio.Location = new Point(111, 83);
            IDRadio.Name = "IDRadio";
            IDRadio.Size = new Size(36, 19);
            IDRadio.TabIndex = 16;
            IDRadio.TabStop = true;
            IDRadio.Text = "ID";
            IDRadio.UseVisualStyleBackColor = true;
            // 
            // CargoRadio
            // 
            CargoRadio.AutoSize = true;
            CargoRadio.Location = new Point(172, 83);
            CargoRadio.Name = "CargoRadio";
            CargoRadio.Size = new Size(57, 19);
            CargoRadio.TabIndex = 17;
            CargoRadio.TabStop = true;
            CargoRadio.Text = "Cargo";
            CargoRadio.UseVisualStyleBackColor = true;
            // 
            // NomeRadio
            // 
            NomeRadio.AutoSize = true;
            NomeRadio.Location = new Point(29, 83);
            NomeRadio.Name = "NomeRadio";
            NomeRadio.Size = new Size(58, 19);
            NomeRadio.TabIndex = 18;
            NomeRadio.TabStop = true;
            NomeRadio.Text = "Nome";
            NomeRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TodosRadio);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(CargoRadio);
            groupBox2.Controls.Add(NomeRadio);
            groupBox2.Controls.Add(IDRadio);
            groupBox2.Controls.Add(PesquisarTextBox);
            groupBox2.Location = new Point(687, 419);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 119);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pesquisa";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 56);
            label7.Name = "label7";
            label7.Size = new Size(201, 17);
            label7.TabIndex = 19;
            label7.Text = "Selecione um metodo de busca:";
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.FromArgb(121, 182, 201);
            BtnEditar.FlatAppearance.BorderSize = 0;
            BtnEditar.FlatStyle = FlatStyle.Popup;
            BtnEditar.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditar.ForeColor = Color.White;
            BtnEditar.Location = new Point(539, 565);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(208, 57);
            BtnEditar.TabIndex = 20;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // TodosRadio
            // 
            TodosRadio.AutoSize = true;
            TodosRadio.Location = new Point(251, 83);
            TodosRadio.Name = "TodosRadio";
            TodosRadio.Size = new Size(56, 19);
            TodosRadio.TabIndex = 20;
            TodosRadio.TabStop = true;
            TodosRadio.Text = "Todos";
            TodosRadio.UseVisualStyleBackColor = true;
            // 
            // FuncionarioPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 647);
            Controls.Add(BtnEditar);
            Controls.Add(groupBox2);
            Controls.Add(BtnPesquisar);
            Controls.Add(BtnInativar);
            Controls.Add(BtnSalvar);
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
        private RadioButton IDRadio;
        private RadioButton CargoRadio;
        private RadioButton NomeRadio;
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
        private RadioButton TodosRadio;
    }
}