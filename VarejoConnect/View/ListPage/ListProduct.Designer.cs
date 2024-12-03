namespace VarejoConnect.View.ListPage
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
			dataGridView1.Size = new Size(527, 412);
			dataGridView1.TabIndex = 37;
			// 
			// NomeRadio
			// 
			NomeRadio.AutoSize = true;
			NomeRadio.Location = new Point(78, 89);
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
			IDRadio.Location = new Point(161, 89);
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
			BtnPesquisar.Location = new Point(224, 80);
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
			label1.Location = new Point(31, 48);
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
			// ListProduct
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(551, 574);
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
	}
}