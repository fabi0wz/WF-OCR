namespace HermaPicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            uploadFilesBtn = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 114);
            label1.Name = "label1";
            label1.Size = new Size(560, 15);
            label1.TabIndex = 3;
            label1.Text = "Aceder ao link disponibilizado e fazer upload das imagens, de seguida é só carregar para export o ficheiro";
            // 
            // uploadFilesBtn
            // 
            uploadFilesBtn.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            uploadFilesBtn.Location = new Point(294, 191);
            uploadFilesBtn.Name = "uploadFilesBtn";
            uploadFilesBtn.Size = new Size(213, 73);
            uploadFilesBtn.TabIndex = 4;
            uploadFilesBtn.Text = "Upload Files";
            uploadFilesBtn.UseVisualStyleBackColor = true;
            uploadFilesBtn.Click += uploadFilesBtn_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(294, 343);
            button2.Name = "button2";
            button2.Size = new Size(213, 73);
            button2.TabIndex = 5;
            button2.Text = "Export File";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(332, 281);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 6;
            label2.Text = "0 Images Uploaded";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(279, 35);
            label3.Name = "label3";
            label3.Size = new Size(308, 45);
            label3.TabIndex = 7;
            label3.Text = "Auto Herma-Picking";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(uploadFilesBtn);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button uploadFilesBtn;
        private Button button2;
        private Label label2;
        private Label label3;
    }
}