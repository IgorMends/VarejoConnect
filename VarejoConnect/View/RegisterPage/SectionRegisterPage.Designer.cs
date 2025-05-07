namespace VarejoConnect.View.RegisterPage
{
    partial class SectionRegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectionRegisterPage));
            BtnSalvar = new Button();
            label1 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            NomeSectionTextBox = new TextBox();
            DescriptionSectionTextBox = new TextBox();
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
            BtnSalvar.Location = new Point(78, 208);
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
            label1.Location = new Point(65, 75);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 59;
            label1.Text = "Nome:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(121, 182, 201);
            label6.Location = new Point(33, 111);
            label6.Name = "label6";
            label6.Size = new Size(103, 23);
            label6.TabIndex = 57;
            label6.Text = "Descrição";
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
            label2.Size = new Size(167, 23);
            label2.TabIndex = 54;
            label2.Text = "Cadastrar Seção";
            // 
            // NomeSectionTextBox
            // 
            NomeSectionTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NomeSectionTextBox.Location = new Point(139, 77);
            NomeSectionTextBox.Name = "NomeSectionTextBox";
            NomeSectionTextBox.Size = new Size(237, 20);
            NomeSectionTextBox.TabIndex = 53;
            // 
            // DescriptionSectionTextBox
            // 
            DescriptionSectionTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescriptionSectionTextBox.Location = new Point(139, 112);
            DescriptionSectionTextBox.Name = "DescriptionSectionTextBox";
            DescriptionSectionTextBox.Size = new Size(237, 20);
            DescriptionSectionTextBox.TabIndex = 52;
            // 
            // SectionRegisterPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 330);
            Controls.Add(BtnSalvar);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(NomeSectionTextBox);
            Controls.Add(DescriptionSectionTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SectionRegisterPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SectionRegisterPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnSalvar;
        private Label label1;
        private Label label6;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox NomeSectionTextBox;
        private TextBox DescriptionSectionTextBox;
    }
}