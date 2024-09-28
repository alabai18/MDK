namespace KOFE
{
    partial class Room1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room1));
            ExitBtn = new Button();
            MinBtn = new Button();
            ATxt = new TextBox();
            BTxt = new TextBox();
            uravLbl = new Label();
            reshitBtn = new Button();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            PlayBtn = new Button();
            ScoreLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            kazinoBtn = new Button();
            chisloBtn = new Button();
            balanceLabel = new Label();
            label3 = new Label();
            KamenBtn = new Button();
            label4 = new Label();
            NextBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ExitBtn
            // 
            ExitBtn.BackgroundImage = (Image)resources.GetObject("ExitBtn.BackgroundImage");
            ExitBtn.BackgroundImageLayout = ImageLayout.Center;
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Location = new Point(768, 0);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(30, 29);
            ExitBtn.TabIndex = 0;
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // MinBtn
            // 
            MinBtn.BackgroundImage = (Image)resources.GetObject("MinBtn.BackgroundImage");
            MinBtn.BackgroundImageLayout = ImageLayout.Center;
            MinBtn.FlatAppearance.BorderSize = 0;
            MinBtn.FlatStyle = FlatStyle.Flat;
            MinBtn.Location = new Point(742, 0);
            MinBtn.Name = "MinBtn";
            MinBtn.Size = new Size(30, 29);
            MinBtn.TabIndex = 1;
            MinBtn.UseVisualStyleBackColor = true;
            MinBtn.Click += MinBtn_Click;
            // 
            // ATxt
            // 
            ATxt.Location = new Point(12, 55);
            ATxt.Name = "ATxt";
            ATxt.Size = new Size(100, 23);
            ATxt.TabIndex = 2;
            // 
            // BTxt
            // 
            BTxt.Location = new Point(152, 55);
            BTxt.Name = "BTxt";
            BTxt.Size = new Size(100, 23);
            BTxt.TabIndex = 3;
            // 
            // uravLbl
            // 
            uravLbl.AutoSize = true;
            uravLbl.Location = new Point(72, 14);
            uravLbl.Name = "uravLbl";
            uravLbl.Size = new Size(119, 15);
            uravLbl.TabIndex = 4;
            uravLbl.Text = "Решение уравнений";
            // 
            // reshitBtn
            // 
            reshitBtn.Location = new Point(92, 94);
            reshitBtn.Name = "reshitBtn";
            reshitBtn.Size = new Size(75, 23);
            reshitBtn.TabIndex = 6;
            reshitBtn.Text = "Решить";
            reshitBtn.UseVisualStyleBackColor = true;
            reshitBtn.Click += reshitBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(413, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(515, 255);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.RebeccaPurple;
            button1.Location = new Point(482, 255);
            button1.Name = "button1";
            button1.Size = new Size(27, 24);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PlayBtn
            // 
            PlayBtn.Location = new Point(61, 304);
            PlayBtn.Name = "PlayBtn";
            PlayBtn.Size = new Size(75, 23);
            PlayBtn.TabIndex = 10;
            PlayBtn.Text = "Играть";
            PlayBtn.UseVisualStyleBackColor = true;
            PlayBtn.Click += PlayBtn_Click;
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Location = new Point(80, 251);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(0, 15);
            ScoreLabel.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 405);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 12;
            label1.Text = "КАЗИНО";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 207);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 13;
            label2.Text = "КОСТИ";
            // 
            // kazinoBtn
            // 
            kazinoBtn.Location = new Point(61, 475);
            kazinoBtn.Name = "kazinoBtn";
            kazinoBtn.Size = new Size(75, 23);
            kazinoBtn.TabIndex = 14;
            kazinoBtn.Text = "Играть";
            kazinoBtn.UseVisualStyleBackColor = true;
            kazinoBtn.Click += kazinoBtn_Click;
            // 
            // chisloBtn
            // 
            chisloBtn.Location = new Point(245, 475);
            chisloBtn.Name = "chisloBtn";
            chisloBtn.Size = new Size(75, 23);
            chisloBtn.TabIndex = 15;
            chisloBtn.Text = "Играть";
            chisloBtn.UseVisualStyleBackColor = true;
            chisloBtn.Click += chisloBtn_Click;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new Point(245, 439);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(0, 15);
            balanceLabel.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 402);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 17;
            label3.Text = "Угадай число";
            // 
            // KamenBtn
            // 
            KamenBtn.Location = new Point(467, 475);
            KamenBtn.Name = "KamenBtn";
            KamenBtn.Size = new Size(75, 23);
            KamenBtn.TabIndex = 18;
            KamenBtn.Text = "Играть";
            KamenBtn.UseVisualStyleBackColor = true;
            KamenBtn.Click += KamenBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(436, 402);
            label4.Name = "label4";
            label4.Size = new Size(152, 15);
            label4.TabIndex = 19;
            label4.Text = "Камень, ножницы, бумага";
            // 
            // NextBtn
            // 
            NextBtn.Location = new Point(700, 554);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(98, 44);
            NextBtn.TabIndex = 20;
            NextBtn.Text = "Дальше";
            NextBtn.UseVisualStyleBackColor = true;
            NextBtn.Click += NextBtn_Click;
            // 
            // Room1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 600);
            Controls.Add(NextBtn);
            Controls.Add(label4);
            Controls.Add(KamenBtn);
            Controls.Add(label3);
            Controls.Add(balanceLabel);
            Controls.Add(chisloBtn);
            Controls.Add(kazinoBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ScoreLabel);
            Controls.Add(PlayBtn);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(reshitBtn);
            Controls.Add(uravLbl);
            Controls.Add(BTxt);
            Controls.Add(ATxt);
            Controls.Add(MinBtn);
            Controls.Add(ExitBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Room1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitBtn;
        private Button MinBtn;
        private TextBox ATxt;
        private TextBox BTxt;
        private Label uravLbl;
        private Button reshitBtn;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Button PlayBtn;
        private Label ScoreLabel;
        private Label label1;
        private Label label2;
        private Button kazinoBtn;
        private Button chisloBtn;
        private Label balanceLabel;
        private Label label3;
        private Button KamenBtn;
        private Label label4;
        private Button NextBtn;
    }
}
