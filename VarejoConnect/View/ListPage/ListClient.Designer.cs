namespace VarejoConnect.View.ListPage
{
	partial class ListClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListClient));
            label2 = new Label();
            label1 = new Label();
            BtnPesquisar = new Button();
            IDRadio = new RadioButton();
            NomeRadio = new RadioButton();
            dataGridView1 = new DataGridView();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(121, 182, 201);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(198, 32);
            label2.TabIndex = 49;
            label2.Text = "Lista de Clientes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 48);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 48;
            label1.Text = "Organizar por:";
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
            BtnPesquisar.TabIndex = 47;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = false;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // IDRadio
            // 
            IDRadio.AutoSize = true;
            IDRadio.Location = new Point(161, 89);
            IDRadio.Name = "IDRadio";
            IDRadio.Size = new Size(57, 19);
            IDRadio.TabIndex = 46;
            IDRadio.TabStop = true;
            IDRadio.Text = "Por ID";
            IDRadio.UseVisualStyleBackColor = true;
            // 
            // NomeRadio
            // 
            NomeRadio.AutoSize = true;
            NomeRadio.Location = new Point(78, 89);
            NomeRadio.Name = "NomeRadio";
            NomeRadio.Size = new Size(77, 19);
            NomeRadio.TabIndex = 45;
            NomeRadio.TabStop = true;
            NomeRadio.Text = "Por nome";
            NomeRadio.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(527, 412);
            dataGridView1.TabIndex = 44;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(522, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // ListClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(551, 574);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnPesquisar);
            Controls.Add(IDRadio);
            Controls.Add(NomeRadio);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListClient";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
		private Label label1;
		private Button BtnPesquisar;
		private RadioButton IDRadio;
		private RadioButton NomeRadio;
		private DataGridView dataGridView1;
		private PictureBox pictureBox2;
	}
}