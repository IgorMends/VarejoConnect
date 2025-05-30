﻿namespace VarejoConnect.View.ListPage
{
	partial class ListProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListProduct));
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            NomeRadio = new RadioButton();
            IDRadio = new RadioButton();
            BtnPesquisar = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(522, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(527, 373);
            dataGridView1.TabIndex = 37;
            // 
            // NomeRadio
            // 
            NomeRadio.AutoSize = true;
            NomeRadio.Location = new Point(263, 90);
            NomeRadio.Name = "NomeRadio";
            NomeRadio.Size = new Size(77, 19);
            NomeRadio.TabIndex = 38;
            NomeRadio.TabStop = true;
            NomeRadio.Text = "Por nome";
            NomeRadio.UseVisualStyleBackColor = true;
            // 
            // IDRadio
            // 
            IDRadio.AutoSize = true;
            IDRadio.Location = new Point(346, 90);
            IDRadio.Name = "IDRadio";
            IDRadio.Size = new Size(57, 19);
            IDRadio.TabIndex = 39;
            IDRadio.TabStop = true;
            IDRadio.Text = "Por ID";
            IDRadio.UseVisualStyleBackColor = true;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.BackColor = Color.FromArgb(121, 182, 201);
            BtnPesquisar.FlatAppearance.BorderSize = 0;
            BtnPesquisar.FlatStyle = FlatStyle.Popup;
            BtnPesquisar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPesquisar.ForeColor = Color.White;
            BtnPesquisar.Location = new Point(409, 81);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(130, 35);
            BtnPesquisar.TabIndex = 40;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = false;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 53);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 41;
            label1.Text = "Organizar por:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(121, 182, 201);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(213, 32);
            label2.TabIndex = 42;
            label2.Text = "Lista de Produtos";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(121, 182, 201);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(394, 525);
            button1.Name = "button1";
            button1.Size = new Size(130, 35);
            button1.TabIndex = 51;
            button1.Text = "Selecionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(91, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(161, 21);
            comboBox1.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 89);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 63;
            label3.Text = "Seção:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(121, 182, 201);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(248, 525);
            button2.Name = "button2";
            button2.Size = new Size(130, 35);
            button2.TabIndex = 64;
            button2.Text = "Limpar Filtro";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ListProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(551, 574);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnPesquisar);
            Controls.Add(IDRadio);
            Controls.Add(NomeRadio);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListProduct";
            Load += ListProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
		private DataGridView dataGridView1;
		private RadioButton NomeRadio;
		private RadioButton IDRadio;
		private Button BtnPesquisar;
		private Label label1;
		private Label label2;
        private Button button1;
        private ComboBox comboBox1;
        private Label label3;
        private Button button2;
    }
}