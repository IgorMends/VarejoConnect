namespace VarejoConnect.View
{
    partial class VendaPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendaPage));
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            clienteTextBox = new TextBox();
            produtoTextBox = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            quantidadeTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            subTotalLabel = new Label();
            TotalLabel = new Label();
            BtnVenda = new Button();
            label10 = new Label();
            TipoDropBox = new ComboBox();
            BtnLimpar = new Button();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 270);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(968, 225);
            dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(121, 182, 201);
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 71);
            label2.Name = "label2";
            label2.Padding = new Padding(6, 2, 6, 2);
            label2.Size = new Size(120, 24);
            label2.TabIndex = 22;
            label2.Text = "Funcionário:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(121, 182, 201);
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 103);
            label1.Name = "label1";
            label1.Padding = new Padding(25, 2, 25, 2);
            label1.Size = new Size(120, 24);
            label1.TabIndex = 23;
            label1.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(121, 182, 201);
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 137);
            label3.Name = "label3";
            label3.Padding = new Padding(21, 2, 22, 2);
            label3.Size = new Size(120, 24);
            label3.TabIndex = 24;
            label3.Text = "Produto:";
            // 
            // clienteTextBox
            // 
            clienteTextBox.Location = new Point(144, 104);
            clienteTextBox.Name = "clienteTextBox";
            clienteTextBox.Size = new Size(251, 23);
            clienteTextBox.TabIndex = 26;
            clienteTextBox.TextChanged += textBox2_TextChanged;
            clienteTextBox.KeyDown += textBox2_KeyDown;
            // 
            // produtoTextBox
            // 
            produtoTextBox.Location = new Point(144, 137);
            produtoTextBox.Name = "produtoTextBox";
            produtoTextBox.Size = new Size(251, 23);
            produtoTextBox.TabIndex = 27;
            produtoTextBox.KeyDown += textBox3_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(121, 182, 201);
            label4.Location = new Point(12, 3);
            label4.Name = "label4";
            label4.Size = new Size(100, 29);
            label4.TabIndex = 28;
            label4.Text = "Vendas";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(405, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(620, 136);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 34;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(593, 138);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 33;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // quantidadeTextBox
            // 
            quantidadeTextBox.Location = new Point(529, 137);
            quantidadeTextBox.Name = "quantidadeTextBox";
            quantidadeTextBox.Size = new Size(56, 23);
            quantidadeTextBox.TabIndex = 36;
            quantidadeTextBox.KeyDown += quantidadeTextBox_KeyDown;
            quantidadeTextBox.KeyPress += quantidadeTextBox_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(121, 182, 201);
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(405, 137);
            label5.Name = "label5";
            label5.Padding = new Padding(7, 2, 6, 2);
            label5.Size = new Size(120, 24);
            label5.TabIndex = 35;
            label5.Text = "Quantidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(121, 182, 201);
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(158, 498);
            label6.Name = "label6";
            label6.Padding = new Padding(35, 2, 36, 2);
            label6.Size = new Size(120, 24);
            label6.TabIndex = 37;
            label6.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(121, 182, 201);
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(33, 498);
            label7.Name = "label7";
            label7.Padding = new Padding(19, 2, 19, 2);
            label7.Size = new Size(120, 24);
            label7.TabIndex = 38;
            label7.Text = "Subtotal:";
            // 
            // subTotalLabel
            // 
            subTotalLabel.BackColor = Color.White;
            subTotalLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subTotalLabel.ForeColor = Color.Black;
            subTotalLabel.Location = new Point(33, 531);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Padding = new Padding(19, 2, 19, 2);
            subTotalLabel.Size = new Size(120, 24);
            subTotalLabel.TabIndex = 39;
            subTotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TotalLabel
            // 
            TotalLabel.BackColor = Color.White;
            TotalLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalLabel.ForeColor = Color.Black;
            TotalLabel.Location = new Point(158, 531);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Padding = new Padding(19, 2, 19, 2);
            TotalLabel.Size = new Size(120, 24);
            TotalLabel.TabIndex = 40;
            TotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            TotalLabel.Click += label9_Click;
            // 
            // BtnVenda
            // 
            BtnVenda.BackColor = Color.FromArgb(121, 182, 201);
            BtnVenda.FlatAppearance.BorderSize = 0;
            BtnVenda.FlatStyle = FlatStyle.Popup;
            BtnVenda.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVenda.ForeColor = Color.White;
            BtnVenda.Location = new Point(793, 563);
            BtnVenda.Name = "BtnVenda";
            BtnVenda.Size = new Size(208, 57);
            BtnVenda.TabIndex = 41;
            BtnVenda.Text = "Finalizar Venda";
            BtnVenda.UseVisualStyleBackColor = false;
            BtnVenda.Click += BtnVenda_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(121, 182, 201);
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(20, 171);
            label10.Name = "label10";
            label10.Padding = new Padding(7, 2, 6, 2);
            label10.Size = new Size(202, 24);
            label10.TabIndex = 42;
            label10.Text = "Forma De Pagamento:";
            // 
            // TipoDropBox
            // 
            TipoDropBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TipoDropBox.FormattingEnabled = true;
            TipoDropBox.Items.AddRange(new object[] { "PIX", "DEBITO", "CREDITO" });
            TipoDropBox.Location = new Point(226, 171);
            TipoDropBox.Name = "TipoDropBox";
            TipoDropBox.Size = new Size(186, 23);
            TipoDropBox.TabIndex = 43;
            // 
            // BtnLimpar
            // 
            BtnLimpar.BackColor = Color.FromArgb(121, 182, 201);
            BtnLimpar.FlatAppearance.BorderSize = 0;
            BtnLimpar.FlatStyle = FlatStyle.Popup;
            BtnLimpar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLimpar.ForeColor = Color.White;
            BtnLimpar.Location = new Point(579, 563);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(208, 57);
            BtnLimpar.TabIndex = 45;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = false;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(121, 182, 201);
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(144, 71);
            label11.Name = "label11";
            label11.Padding = new Padding(6, 2, 6, 2);
            label11.Size = new Size(251, 24);
            label11.TabIndex = 46;
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VendaPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 647);
            Controls.Add(label11);
            Controls.Add(BtnLimpar);
            Controls.Add(TipoDropBox);
            Controls.Add(label10);
            Controls.Add(BtnVenda);
            Controls.Add(TotalLabel);
            Controls.Add(subTotalLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(quantidadeTextBox);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(produtoTextBox);
            Controls.Add(clienteTextBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VendaPage";
            Text = "VendaPage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox clienteTextBox;
        private TextBox produtoTextBox;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TextBox quantidadeTextBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label subTotalLabel;
        private Label TotalLabel;
        private Button BtnVenda;
        private Label label10;
        private ComboBox TipoDropBox;
        private Button BtnLimpar;
        private Label label11;
    }
}