namespace VarejoConnect.View.RegisterPage
{
    partial class ProductRegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductRegisterPage));
            BtnSalvar = new Button();
            label1 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            MarcaTextBox = new TextBox();
            DescricaoTextBox = new TextBox();
            PrecoTextBox = new TextBox();
            NomeTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = Color.FromArgb(100, 250, 140);
            BtnSalvar.FlatAppearance.BorderSize = 0;
            BtnSalvar.FlatStyle = FlatStyle.Popup;
            BtnSalvar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalvar.ForeColor = Color.White;
            BtnSalvar.Location = new Point(78, 345);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(263, 57);
            BtnSalvar.TabIndex = 58;
            BtnSalvar.Text = "Cadastrar";
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(121, 182, 201);
            label1.Location = new Point(47, 157);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 57;
            label1.Text = "Marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(121, 182, 201);
            label3.Location = new Point(55, 225);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 56;
            label3.Text = "Preço:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(121, 182, 201);
            label6.Location = new Point(15, 193);
            label6.Name = "label6";
            label6.Size = new Size(108, 23);
            label6.TabIndex = 55;
            label6.Text = "Descrição:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(121, 182, 201);
            label7.Location = new Point(52, 123);
            label7.Name = "label7";
            label7.Size = new Size(71, 23);
            label7.TabIndex = 54;
            label7.Text = "Nome:";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(398, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 53;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(121, 182, 201);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(179, 23);
            label2.TabIndex = 52;
            label2.Text = "Cadastrar Produto";
            // 
            // MarcaTextBox
            // 
            MarcaTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MarcaTextBox.Location = new Point(129, 160);
            MarcaTextBox.Name = "MarcaTextBox";
            MarcaTextBox.Size = new Size(237, 20);
            MarcaTextBox.TabIndex = 51;
            // 
            // DescricaoTextBox
            // 
            DescricaoTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescricaoTextBox.Location = new Point(129, 195);
            DescricaoTextBox.Name = "DescricaoTextBox";
            DescricaoTextBox.Size = new Size(237, 20);
            DescricaoTextBox.TabIndex = 50;
            // 
            // PrecoTextBox
            // 
            PrecoTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrecoTextBox.Location = new Point(129, 230);
            PrecoTextBox.Name = "PrecoTextBox";
            PrecoTextBox.Size = new Size(236, 20);
            PrecoTextBox.TabIndex = 49;
            // 
            // NomeTextBox
            // 
            NomeTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NomeTextBox.Location = new Point(129, 126);
            NomeTextBox.Name = "NomeTextBox";
            NomeTextBox.Size = new Size(237, 20);
            NomeTextBox.TabIndex = 48;
            // 
            // ProductRegisterPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 450);
            Controls.Add(BtnSalvar);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(MarcaTextBox);
            Controls.Add(DescricaoTextBox);
            Controls.Add(PrecoTextBox);
            Controls.Add(NomeTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductRegisterPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductRegisterPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSalvar;
        private Label label1;
        private Label label3;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox MarcaTextBox;
        private TextBox DescricaoTextBox;
        private TextBox PrecoTextBox;
        private TextBox NomeTextBox;
    }
}