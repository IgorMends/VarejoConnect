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
            label3 = new Label();
            RelatorioTextBox = new TextBox();
            button1 = new Button();
            BtnEditar = new Button();
            BtnInativar = new Button();
            BtnSalvar = new Button();
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
            groupBox2.Location = new Point(387, 434);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(617, 197);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pesquisa";
            // 
            // SearchOptions
            // 
            SearchOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            SearchOptions.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchOptions.FormattingEnabled = true;
            SearchOptions.Items.AddRange(new object[] { "SEM FILTRO", "NOME", "ID", "CPF" });
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
            PesquisarTextBox.Location = new Point(92, 29);
            PesquisarTextBox.Name = "PesquisarTextBox";
            PesquisarTextBox.Size = new Size(247, 20);
            PesquisarTextBox.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(RelatorioTextBox);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(BtnEditar);
            groupBox1.Controls.Add(BtnInativar);
            groupBox1.Controls.Add(BtnSalvar);
            groupBox1.Location = new Point(25, 434);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 201);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(89, 92);
            label3.Name = "label3";
            label3.Size = new Size(180, 15);
            label3.TabIndex = 33;
            label3.Text = "Gerar Relatorio PDF Por Nome:";
            // 
            // RelatorioTextBox
            // 
            RelatorioTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RelatorioTextBox.Location = new Point(59, 110);
            RelatorioTextBox.Name = "RelatorioTextBox";
            RelatorioTextBox.Size = new Size(240, 20);
            RelatorioTextBox.TabIndex = 32;
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
            button1.TabIndex = 30;
            button1.Text = "Gerar Relatorio";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            BtnEditar.TabIndex = 20;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnInativar
            // 
            BtnInativar.BackColor = Color.FromArgb(250, 90, 110);
            BtnInativar.FlatAppearance.BorderSize = 0;
            BtnInativar.FlatStyle = FlatStyle.Popup;
            BtnInativar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnInativar.ForeColor = Color.White;
            BtnInativar.Location = new Point(129, 22);
            BtnInativar.Name = "BtnInativar";
            BtnInativar.Size = new Size(107, 36);
            BtnInativar.TabIndex = 12;
            BtnInativar.Text = "Excluir";
            BtnInativar.UseVisualStyleBackColor = false;
            BtnInativar.Click += BtnInativar_Click;
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
            BtnSalvar.TabIndex = 11;
            BtnSalvar.Text = "Cadastrar";
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(121, 182, 201);
            label2.Location = new Point(25, 3);
            label2.Name = "label2";
            label2.Size = new Size(221, 29);
            label2.TabIndex = 21;
            label2.Text = "Cadastro Clientes";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(979, 373);
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
        private Button button1;
        private Button BtnEditar;
        private Button BtnInativar;
        private Button BtnSalvar;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox RelatorioTextBox;
    }
}