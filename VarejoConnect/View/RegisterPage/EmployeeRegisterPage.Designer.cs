namespace VarejoConnect.View.RegisterPage
{
    partial class EmployeeRegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeRegisterPage));
            BtnSalvar = new Button();
            label1 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            PasswordTextBox = new TextBox();
            PositionTextBox = new TextBox();
            SalaryTextBox = new TextBox();
            NomeTextBox = new TextBox();
            label4 = new Label();
            LoginTextBox = new TextBox();
            label5 = new Label();
            ConfirmPasswordTextBox = new TextBox();
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
            label1.Location = new Point(51, 170);
            label1.Name = "label1";
            label1.Size = new Size(72, 23);
            label1.TabIndex = 57;
            label1.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(121, 182, 201);
            label3.Location = new Point(44, 273);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 56;
            label3.Text = "Salário:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(121, 182, 201);
            label6.Location = new Point(49, 238);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 55;
            label6.Text = "Cargo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(121, 182, 201);
            label7.Location = new Point(52, 135);
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
            label2.Size = new Size(215, 23);
            label2.TabIndex = 52;
            label2.Text = "Cadastrar Funcionario";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTextBox.Location = new Point(129, 172);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(237, 20);
            PasswordTextBox.TabIndex = 51;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PositionTextBox
            // 
            PositionTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PositionTextBox.Location = new Point(129, 241);
            PositionTextBox.Name = "PositionTextBox";
            PositionTextBox.Size = new Size(237, 20);
            PositionTextBox.TabIndex = 50;
            // 
            // SalaryTextBox
            // 
            SalaryTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SalaryTextBox.Location = new Point(129, 276);
            SalaryTextBox.Name = "SalaryTextBox";
            SalaryTextBox.Size = new Size(236, 20);
            SalaryTextBox.TabIndex = 49;
            // 
            // NomeTextBox
            // 
            NomeTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NomeTextBox.Location = new Point(129, 138);
            NomeTextBox.Name = "NomeTextBox";
            NomeTextBox.Size = new Size(237, 20);
            NomeTextBox.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(121, 182, 201);
            label4.Location = new Point(59, 101);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 60;
            label4.Text = "Login:";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginTextBox.Location = new Point(129, 103);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(237, 20);
            LoginTextBox.TabIndex = 59;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(121, 182, 201);
            label5.Location = new Point(8, 205);
            label5.Name = "label5";
            label5.Size = new Size(168, 23);
            label5.TabIndex = 62;
            label5.Text = "Confirmar Senha:";
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmPasswordTextBox.Location = new Point(178, 206);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Size = new Size(218, 20);
            ConfirmPasswordTextBox.TabIndex = 61;
            ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // EmployeeRegisterPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(427, 450);
            Controls.Add(label5);
            Controls.Add(ConfirmPasswordTextBox);
            Controls.Add(label4);
            Controls.Add(LoginTextBox);
            Controls.Add(BtnSalvar);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(PasswordTextBox);
            Controls.Add(PositionTextBox);
            Controls.Add(SalaryTextBox);
            Controls.Add(NomeTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeRegisterPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeRegisterPage";
            Load += EmployeeRegisterPage_Load;
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
        private TextBox PasswordTextBox;
        private TextBox PositionTextBox;
        private TextBox SalaryTextBox;
        private TextBox NomeTextBox;
        private Label label4;
        private TextBox LoginTextBox;
        private Label label5;
        private TextBox ConfirmPasswordTextBox;
    }
}