namespace VarejoConnect.View.EditPage
{
    partial class FornecedorEditPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FornecedorEditPage));
            BtnSalvar = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = Color.FromArgb(121, 182, 201);
            BtnSalvar.FlatAppearance.BorderSize = 0;
            BtnSalvar.FlatStyle = FlatStyle.Popup;
            BtnSalvar.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalvar.ForeColor = Color.White;
            BtnSalvar.Location = new Point(112, 358);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(208, 57);
            BtnSalvar.TabIndex = 51;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(135, 240);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 23);
            textBox3.TabIndex = 50;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 184);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 23);
            textBox2.TabIndex = 49;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 23);
            textBox1.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(121, 182, 201);
            label4.Location = new Point(42, 240);
            label4.Name = "label4";
            label4.Size = new Size(92, 23);
            label4.TabIndex = 47;
            label4.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(121, 182, 201);
            label3.Location = new Point(39, 184);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 46;
            label3.Text = "Empresa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(121, 182, 201);
            label1.Location = new Point(61, 126);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 45;
            label1.Text = "Nome:";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(397, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(121, 182, 201);
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(173, 23);
            label2.TabIndex = 43;
            label2.Text = "Editar Fornecedor";
            // 
            // FornecedorEditPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 504);
            Controls.Add(BtnSalvar);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FornecedorEditPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FornecedorEditPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSalvar;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
    }
}