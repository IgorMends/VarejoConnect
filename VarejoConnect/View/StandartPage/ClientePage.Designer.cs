namespace VarejoConnect.View
{
    partial class ClientePage
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
            groupBox2 = new GroupBox();
            SearchOptions = new ComboBox();
            label7 = new Label();
            BtnPesquisar = new Button();
            label6 = new Label();
            PesquisarTextBox = new TextBox();
            groupBox1 = new GroupBox();
            CpfTextBox = new TextBox();
            label9 = new Label();
            button1 = new Button();
            BtnEditar = new Button();
            EmailTextBox = new TextBox();
            BtnInativar = new Button();
            label5 = new Label();
            BtnSalvar = new Button();
            TelefoneTextBox = new TextBox();
            label4 = new Label();
            NomeTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pesquisa";
            // 
            // SearchOptions
            // 
            SearchOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            SearchOptions.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchOptions.FormattingEnabled = true;
            SearchOptions.Items.AddRange(new object[] { "TODOS", "NOME", "ID", "CPF" });
            SearchOptions.Location = new Point(242, 65);
            SearchOptions.Name = "SearchOptions";
            SearchOptions.Size = new Size(160, 24);
            SearchOptions.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 67);
            label7.Name = "label7";
            label7.Size = new Size(201, 17);
            label7.TabIndex = 19;
            label7.Text = "Selecione um metodo de busca:";
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.BackColor = Color.FromArgb(121, 182, 201);
            BtnPesquisar.FlatAppearance.BorderSize = 0;
            BtnPesquisar.FlatStyle = FlatStyle.Popup;
            BtnPesquisar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPesquisar.ForeColor = Color.White;
            BtnPesquisar.Location = new Point(376, 22);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(149, 33);
            BtnPesquisar.TabIndex = 15;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = false;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 32);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 13;
            label6.Text = "Pesquisar:";
            // 
            // PesquisarTextBox
            // 
            PesquisarTextBox.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PesquisarTextBox.Location = new Point(92, 29);
            PesquisarTextBox.Name = "PesquisarTextBox";
            PesquisarTextBox.Size = new Size(247, 21);
            PesquisarTextBox.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CpfTextBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(BtnEditar);
            groupBox1.Controls.Add(EmailTextBox);
            groupBox1.Controls.Add(BtnInativar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(BtnSalvar);
            groupBox1.Controls.Add(TelefoneTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(NomeTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 580);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // CpfTextBox
            // 
            CpfTextBox.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CpfTextBox.Location = new Point(76, 58);
            CpfTextBox.Name = "CpfTextBox";
            CpfTextBox.Size = new Size(237, 21);
            CpfTextBox.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(23, 60);
            label9.Name = "label9";
            label9.Size = new Size(33, 17);
            label9.TabIndex = 31;
            label9.Text = "CPF:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(121, 182, 201);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(65, 452);
            button1.Name = "button1";
            button1.Size = new Size(208, 57);
            button1.TabIndex = 30;
            button1.Text = "Gerar Relatorio";
            button1.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.FromArgb(121, 182, 201);
            BtnEditar.FlatAppearance.BorderSize = 0;
            BtnEditar.FlatStyle = FlatStyle.Popup;
            BtnEditar.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditar.ForeColor = Color.White;
            BtnEditar.Location = new Point(65, 372);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(208, 57);
            BtnEditar.TabIndex = 20;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailTextBox.Location = new Point(76, 93);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(237, 21);
            EmailTextBox.TabIndex = 7;
            // 
            // BtnInativar
            // 
            BtnInativar.BackColor = Color.FromArgb(121, 182, 201);
            BtnInativar.FlatAppearance.BorderSize = 0;
            BtnInativar.FlatStyle = FlatStyle.Popup;
            BtnInativar.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnInativar.ForeColor = Color.White;
            BtnInativar.Location = new Point(65, 291);
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
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 95);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 6;
            label5.Text = "Email:";
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = Color.FromArgb(121, 182, 201);
            BtnSalvar.FlatAppearance.BorderSize = 0;
            BtnSalvar.FlatStyle = FlatStyle.Popup;
            BtnSalvar.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalvar.ForeColor = Color.White;
            BtnSalvar.Location = new Point(65, 212);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(208, 57);
            BtnSalvar.TabIndex = 11;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // TelefoneTextBox
            // 
            TelefoneTextBox.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TelefoneTextBox.Location = new Point(91, 128);
            TelefoneTextBox.Name = "TelefoneTextBox";
            TelefoneTextBox.Size = new Size(221, 21);
            TelefoneTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 130);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 4;
            label4.Text = "Telefone:";
            // 
            // NomeTextBox
            // 
            NomeTextBox.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NomeTextBox.Location = new Point(76, 24);
            NomeTextBox.Name = "NomeTextBox";
            NomeTextBox.Size = new Size(237, 21);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(121, 182, 201);
            label2.Location = new Point(25, 3);
            label2.Name = "label2";
            label2.Size = new Size(273, 28);
            label2.TabIndex = 21;
            label2.Text = "Cadastro Funcionários";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(352, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(652, 373);
            dataGridView1.TabIndex = 20;
            // 
            // ClientePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 647);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientePage";
            Text = "ClientePage";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private ComboBox SearchOptions;
        private Label label7;
        private Button BtnPesquisar;
        private Label label6;
        private TextBox PesquisarTextBox;
        private GroupBox groupBox1;
        private TextBox CpfTextBox;
        private Label label9;
        private Button button1;
        private Button BtnEditar;
        private TextBox EmailTextBox;
        private Button BtnInativar;
        private Label label5;
        private Button BtnSalvar;
        private TextBox TelefoneTextBox;
        private Label label4;
        private TextBox NomeTextBox;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
    }
}