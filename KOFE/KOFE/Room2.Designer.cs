namespace KOFE
{
    partial class Room2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room2));
            MinBtn = new Button();
            ExitBtn = new Button();
            NextBtn = new Button();
            PictureBtn = new Button();
            DeletePictureBtn = new Button();
            pictureBox1 = new PictureBox();
            checkButton = new Button();
            answerTextBox = new TextBox();
            riddleLabel = new Label();
            startButton = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ReakziaBtn = new Button();
            BackBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MinBtn
            // 
            MinBtn.BackgroundImage = (Image)resources.GetObject("MinBtn.BackgroundImage");
            MinBtn.BackgroundImageLayout = ImageLayout.Center;
            MinBtn.FlatAppearance.BorderSize = 0;
            MinBtn.FlatStyle = FlatStyle.Flat;
            MinBtn.Location = new Point(741, 2);
            MinBtn.Name = "MinBtn";
            MinBtn.Size = new Size(30, 29);
            MinBtn.TabIndex = 3;
            MinBtn.UseVisualStyleBackColor = true;
            MinBtn.Click += MinBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackgroundImage = (Image)resources.GetObject("ExitBtn.BackgroundImage");
            ExitBtn.BackgroundImageLayout = ImageLayout.Center;
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Location = new Point(767, 2);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(30, 29);
            ExitBtn.TabIndex = 2;
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // NextBtn
            // 
            NextBtn.Location = new Point(699, 554);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(98, 44);
            NextBtn.TabIndex = 21;
            NextBtn.Text = "Дальше";
            NextBtn.UseVisualStyleBackColor = true;
            NextBtn.Click += NextBtn_Click;
            // 
            // PictureBtn
            // 
            PictureBtn.Location = new Point(572, 270);
            PictureBtn.Name = "PictureBtn";
            PictureBtn.Size = new Size(75, 23);
            PictureBtn.TabIndex = 22;
            PictureBtn.Text = "Нажми";
            PictureBtn.UseVisualStyleBackColor = true;
            PictureBtn.Click += PictureBtn_Click;
            // 
            // DeletePictureBtn
            // 
            DeletePictureBtn.BackColor = Color.Red;
            DeletePictureBtn.FlatAppearance.BorderSize = 0;
            DeletePictureBtn.FlatStyle = FlatStyle.Flat;
            DeletePictureBtn.Location = new Point(535, 272);
            DeletePictureBtn.Name = "DeletePictureBtn";
            DeletePictureBtn.Size = new Size(17, 18);
            DeletePictureBtn.TabIndex = 23;
            DeletePictureBtn.UseVisualStyleBackColor = false;
            DeletePictureBtn.Click += DeletePictureBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(457, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(24, 565);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(75, 23);
            checkButton.TabIndex = 25;
            checkButton.Text = "проверить";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click_1;
            // 
            // answerTextBox
            // 
            answerTextBox.Location = new Point(12, 484);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(100, 23);
            answerTextBox.TabIndex = 26;
            // 
            // riddleLabel
            // 
            riddleLabel.AutoSize = true;
            riddleLabel.Location = new Point(156, 521);
            riddleLabel.Name = "riddleLabel";
            riddleLabel.Size = new Size(38, 15);
            riddleLabel.TabIndex = 27;
            riddleLabel.Text = "label1";
            // 
            // startButton
            // 
            startButton.Location = new Point(156, 565);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 28;
            startButton.Text = "старт";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 420);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 29;
            label1.Text = "Загадки";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // ReakziaBtn
            // 
            ReakziaBtn.Location = new Point(422, 502);
            ReakziaBtn.Name = "ReakziaBtn";
            ReakziaBtn.Size = new Size(75, 23);
            ReakziaBtn.TabIndex = 30;
            ReakziaBtn.Text = "играть";
            ReakziaBtn.UseVisualStyleBackColor = true;
            ReakziaBtn.Click += ReakziaBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(595, 554);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(98, 44);
            BackBtn.TabIndex = 31;
            BackBtn.Text = "Назад";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // Room2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 600);
            Controls.Add(BackBtn);
            Controls.Add(ReakziaBtn);
            Controls.Add(label1);
            Controls.Add(startButton);
            Controls.Add(riddleLabel);
            Controls.Add(answerTextBox);
            Controls.Add(checkButton);
            Controls.Add(pictureBox1);
            Controls.Add(DeletePictureBtn);
            Controls.Add(PictureBtn);
            Controls.Add(NextBtn);
            Controls.Add(MinBtn);
            Controls.Add(ExitBtn);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Room2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Room2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MinBtn;
        private Button ExitBtn;
        private Button NextBtn;
        private Button PictureBtn;
        private Button DeletePictureBtn;
        private PictureBox pictureBox1;
        private Button checkButton;
        private TextBox answerTextBox;
        private Label riddleLabel;
        private Button startButton;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button ReakziaBtn;
        private Button BackBtn;
    }
}