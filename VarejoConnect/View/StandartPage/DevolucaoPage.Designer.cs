namespace VarejoConnect.View.StandartPage
{
    partial class DevolucaoPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolucaoPage));
            button1 = new Button();
            label11 = new Label();
            BtnLimpar = new Button();
            BtnVenda = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            vendaTextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dgvDevolver = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            dgvVenda = new DataGridView();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDevolver).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(121, 182, 201);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(627, 604);
            button1.Name = "button1";
            button1.Size = new Size(193, 35);
            button1.TabIndex = 69;
            button1.Text = "Listar Todas Devoluções";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(121, 182, 201);
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(136, 49);
            label11.Name = "label11";
            label11.Padding = new Padding(6, 2, 6, 2);
            label11.Size = new Size(268, 24);
            label11.TabIndex = 68;
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnLimpar
            // 
            BtnLimpar.BackColor = Color.FromArgb(250, 90, 110);
            BtnLimpar.FlatAppearance.BorderSize = 0;
            BtnLimpar.FlatStyle = FlatStyle.Popup;
            BtnLimpar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLimpar.ForeColor = Color.White;
            BtnLimpar.Location = new Point(154, 424);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(180, 35);
            BtnLimpar.TabIndex = 67;
            BtnLimpar.Text = "Limpar ";
            BtnLimpar.UseVisualStyleBackColor = false;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // BtnVenda
            // 
            BtnVenda.BackColor = Color.FromArgb(100, 250, 140);
            BtnVenda.FlatAppearance.BorderSize = 0;
            BtnVenda.FlatStyle = FlatStyle.Popup;
            BtnVenda.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVenda.ForeColor = Color.White;
            BtnVenda.Location = new Point(826, 604);
            BtnVenda.Name = "BtnVenda";
            BtnVenda.Size = new Size(180, 35);
            BtnVenda.TabIndex = 64;
            BtnVenda.Text = "Finalizar Devolução";
            BtnVenda.UseVisualStyleBackColor = false;
            BtnVenda.Click += BtnVenda_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(441, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(121, 182, 201);
            label4.Location = new Point(12, 3);
            label4.Name = "label4";
            label4.Size = new Size(136, 29);
            label4.TabIndex = 54;
            label4.Text = "Devolução";
            // 
            // vendaTextbox
            // 
            vendaTextbox.Location = new Point(136, 82);
            vendaTextbox.Name = "vendaTextbox";
            vendaTextbox.Size = new Size(268, 23);
            vendaTextbox.TabIndex = 52;
            vendaTextbox.KeyDown += vendaTextbox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(121, 182, 201);
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Padding = new Padding(25, 2, 25, 2);
            label1.Size = new Size(116, 24);
            label1.TabIndex = 50;
            label1.Text = "Venda:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(121, 182, 201);
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Padding = new Padding(6, 2, 6, 2);
            label2.Size = new Size(120, 24);
            label2.TabIndex = 49;
            label2.Text = "Funcionário:";
            // 
            // dgvDevolver
            // 
            dgvDevolver.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevolver.Location = new Point(22, 32);
            dgvDevolver.Name = "dgvDevolver";
            dgvDevolver.Size = new Size(441, 386);
            dgvDevolver.TabIndex = 70;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDevolver);
            groupBox2.Controls.Add(BtnLimpar);
            groupBox2.Location = new Point(533, 123);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(487, 475);
            groupBox2.TabIndex = 73;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produtos a Devolver:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(dgvVenda);
            groupBox1.Location = new Point(12, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(487, 475);
            groupBox1.TabIndex = 74;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos da Venda:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(121, 182, 201);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(252, 424);
            button2.Name = "button2";
            button2.Size = new Size(193, 35);
            button2.TabIndex = 72;
            button2.Text = "Devolver Venda Inteira";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(121, 182, 201);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(43, 424);
            button3.Name = "button3";
            button3.Size = new Size(193, 35);
            button3.TabIndex = 71;
            button3.Text = "Devolver Produto";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dgvVenda
            // 
            dgvVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenda.Location = new Point(22, 32);
            dgvVenda.Name = "dgvVenda";
            dgvVenda.Size = new Size(441, 386);
            dgvVenda.TabIndex = 70;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(413, 84);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 75;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // DevolucaoPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 647);
            Controls.Add(pictureBox4);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(BtnVenda);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(vendaTextbox);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DevolucaoPage";
            Text = "DevolucaoPage";
            Load += DevolucaoPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDevolver).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label11;
        private Button BtnLimpar;
        private Button BtnVenda;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox vendaTextbox;
        private Label label1;
        private Label label2;
        private DataGridView dgvDevolver;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button button3;
        private DataGridView dgvVenda;
        private Button button2;
        private PictureBox pictureBox4;
    }
}