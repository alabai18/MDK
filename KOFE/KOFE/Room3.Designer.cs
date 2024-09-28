namespace KOFE
{
    partial class Room3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room3));
            StartBtn = new Button();
            btnHit = new Button();
            btnStand = new Button();
            MinBtn = new Button();
            ExitBtn = new Button();
            BackBtn = new Button();
            RestartBtn = new Button();
            SuspendLayout();
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(532, 40);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(75, 23);
            StartBtn.TabIndex = 0;
            StartBtn.Text = "Старт";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // btnHit
            // 
            btnHit.Location = new Point(351, 502);
            btnHit.Name = "btnHit";
            btnHit.Size = new Size(75, 23);
            btnHit.TabIndex = 1;
            btnHit.Text = "Брать";
            btnHit.UseVisualStyleBackColor = true;
            btnHit.Click += btnHit_Click_1;
            // 
            // btnStand
            // 
            btnStand.Location = new Point(351, 461);
            btnStand.Name = "btnStand";
            btnStand.Size = new Size(75, 23);
            btnStand.TabIndex = 2;
            btnStand.Text = "Конец";
            btnStand.UseVisualStyleBackColor = true;
            btnStand.Click += btnStand_Click_1;
            // 
            // MinBtn
            // 
            MinBtn.BackgroundImage = (Image)resources.GetObject("MinBtn.BackgroundImage");
            MinBtn.BackgroundImageLayout = ImageLayout.Center;
            MinBtn.FlatAppearance.BorderSize = 0;
            MinBtn.FlatStyle = FlatStyle.Flat;
            MinBtn.Location = new Point(742, 2);
            MinBtn.Name = "MinBtn";
            MinBtn.Size = new Size(30, 29);
            MinBtn.TabIndex = 5;
            MinBtn.UseVisualStyleBackColor = true;
            MinBtn.Click += MinBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackgroundImage = (Image)resources.GetObject("ExitBtn.BackgroundImage");
            ExitBtn.BackgroundImageLayout = ImageLayout.Center;
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Location = new Point(768, 2);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(30, 29);
            ExitBtn.TabIndex = 4;
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(700, 555);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(98, 44);
            BackBtn.TabIndex = 32;
            BackBtn.Text = "Назад";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // RestartBtn
            // 
            RestartBtn.Location = new Point(351, 546);
            RestartBtn.Name = "RestartBtn";
            RestartBtn.Size = new Size(75, 23);
            RestartBtn.TabIndex = 33;
            RestartBtn.Text = "Заново";
            RestartBtn.UseVisualStyleBackColor = true;
            RestartBtn.Click += RestartBtn_Click;
            // 
            // Room3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 600);
            Controls.Add(RestartBtn);
            Controls.Add(BackBtn);
            Controls.Add(MinBtn);
            Controls.Add(ExitBtn);
            Controls.Add(btnStand);
            Controls.Add(btnHit);
            Controls.Add(StartBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Room3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Room3";
            ResumeLayout(false);
        }

        #endregion

        private Button StartBtn;
        private Button btnHit;
        private Button btnStand;
        private Button MinBtn;
        private Button ExitBtn;
        private Button BackBtn;
        private Button RestartBtn;
    }
}