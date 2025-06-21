namespace VarejoConnect.View.OthersPage
{
    partial class FinalizarDevolucaoPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalizarDevolucaoPage));
            pictureBox2 = new PictureBox();
            label3 = new Label();
            motivoTextBox = new TextBox();
            BtnVenda = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(547, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 27);
            label3.Name = "label3";
            label3.Size = new Size(395, 21);
            label3.TabIndex = 52;
            label3.Text = "Digite um motivo para a finalização da devolução:";
            // 
            // motivoTextBox
            // 
            motivoTextBox.Location = new Point(12, 63);
            motivoTextBox.Name = "motivoTextBox";
            motivoTextBox.Size = new Size(543, 23);
            motivoTextBox.TabIndex = 53;
            // 
            // BtnVenda
            // 
            BtnVenda.BackColor = Color.FromArgb(100, 250, 140);
            BtnVenda.FlatAppearance.BorderSize = 0;
            BtnVenda.FlatStyle = FlatStyle.Popup;
            BtnVenda.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVenda.ForeColor = Color.White;
            BtnVenda.Location = new Point(375, 111);
            BtnVenda.Name = "BtnVenda";
            BtnVenda.Size = new Size(180, 35);
            BtnVenda.TabIndex = 65;
            BtnVenda.Text = "Finalizar Devolução";
            BtnVenda.UseVisualStyleBackColor = false;
            BtnVenda.Click += BtnVenda_Click;
            // 
            // FinalizarDevolucaoPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 169);
            Controls.Add(BtnVenda);
            Controls.Add(motivoTextBox);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FinalizarDevolucaoPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinalizarDevolucaoPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label3;
        private TextBox motivoTextBox;
        private Button BtnVenda;
    }
}