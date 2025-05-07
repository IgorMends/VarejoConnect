namespace VarejoConnect.View.RegisterPage
{
    partial class SupplierRegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierRegisterPage));
            label4 = new Label();
            TipoDropBox = new ComboBox();
            BtnSalvar = new Button();
            label1 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            FornecedorDoc = new TextBox();
            FornecedorNum = new TextBox();
            FornecedorName = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(121, 182, 201);
            label4.Location = new Point(80, 151);
            label4.Name = "label4";
            label4.Size = new Size(53, 23);
            label4.TabIndex = 62;
            label4.Text = "Tipo:";
            // 
            // TipoDropBox
            // 
            TipoDropBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TipoDropBox.FormattingEnabled = true;
            TipoDropBox.Items.AddRange(new object[] { "FÍSICA", "JURÍDICA" });
            TipoDropBox.Location = new Point(139, 151);
            TipoDropBox.Name = "TipoDropBox";
            TipoDropBox.Size = new Size(237, 23);
            TipoDropBox.TabIndex = 61;
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
            BtnSalvar.TabIndex = 60;
            BtnSalvar.Text = "Cadastrar";
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(121, 182, 201);
            label1.Location = new Point(11, 187);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 59;
            label1.Text = "Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(121, 182, 201);
            label3.Location = new Point(41, 259);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 58;
            label3.Text = "Telefone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(121, 182, 201);
            label6.Location = new Point(38, 223);
            label6.Name = "label6";
            label6.Size = new Size(95, 23);
            label6.TabIndex = 57;
            label6.Text = "Empresa:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(121, 182, 201);
            label7.Location = new Point(62, 114);
            label7.Name = "label7";
            label7.Size = new Size(71, 23);
            label7.TabIndex = 56;
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
            pictureBox2.TabIndex = 55;
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
            label2.Size = new Size(212, 23);
            label2.TabIndex = 54;
            label2.Text = "Cadastrar Fonecedor:";
            // 
            // FornecedorDoc
            // 
            FornecedorDoc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FornecedorDoc.Location = new Point(139, 190);
            FornecedorDoc.Name = "FornecedorDoc";
            FornecedorDoc.Size = new Size(237, 20);
            FornecedorDoc.TabIndex = 53;
            // 
            // FornecedorNum
            // 
            FornecedorNum.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FornecedorNum.Location = new Point(139, 260);
            FornecedorNum.Name = "FornecedorNum";
            FornecedorNum.Size = new Size(236, 20);
            FornecedorNum.TabIndex = 51;
            // 
            // FornecedorName
            // 
            FornecedorName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FornecedorName.Location = new Point(139, 117);
            FornecedorName.Name = "FornecedorName";
            FornecedorName.Size = new Size(237, 20);
            FornecedorName.TabIndex = 50;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(139, 228);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 20);
            textBox1.TabIndex = 63;
            // 
            // SupplierRegisterPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 450);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(TipoDropBox);
            Controls.Add(BtnSalvar);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(FornecedorDoc);
            Controls.Add(FornecedorNum);
            Controls.Add(FornecedorName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupplierRegisterPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupplierRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ComboBox TipoDropBox;
        private Button BtnSalvar;
        private Label label1;
        private Label label3;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox FornecedorDoc;
        private TextBox FornecedorNum;
        private TextBox FornecedorName;
        private TextBox textBox1;
    }
}