namespace KOFE
{
    public partial class Room2 : Form
    {
        private System.Windows.Forms.Button[,] buttons = new System.Windows.Forms.Button[3, 3];
        private string currentPlayer = "X";
        private Label statusLabel;
        private Random random = new Random();
        private List<Bitmap> images = new List<Bitmap>();
        private PictureBox PictureBox1;
        private int currentRiddleIndex;
        private List<Riddle> riddles;
        private System.Windows.Forms.Timer timer;
        private int countdownInterval;

        public Room2()
        {
            InitializeComponent();
            this.Text = "Крестики-нолики";

            statusLabel = new Label() { Text = "Игрок, ваш ход", Location = new Point(10, 10), AutoSize = true };
            this.Controls.Add(statusLabel);

            InitializeButtons();
            LoadImages();
            LoadImages();
            InitializeRiddles();
            riddleLabel.Visible = false;
            answerTextBox.Visible = false;
            checkButton.Visible = false;
            InitializeGame();

        }

        private void InitializeGame()
        {

            this.Text = "Игра на реакцию";

            Button button1 = new Button();
            ReakziaBtn.Text = "Нажми на меня!";
            ReakziaBtn.Size = new Size(150, 50);
            ReakziaBtn.Location = new Point((this.ClientSize.Width - ReakziaBtn.Width) / 2, (this.ClientSize.Height - ReakziaBtn.Height) / 2);
            ReakziaBtn.Click += new EventHandler(ReakziaBtn_Click);
            this.Controls.Add(button1);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ReakziaBtn.BackColor = Color.Green;
            timer.Stop();
            timer.Interval = 2000;
            timer.Start();
        }

        private void timer1_TickRed(object sender, EventArgs e)
        {
            ReakziaBtn.BackColor = Color.Red;
            timer.Interval = 2000;
            timer1.Stop();
        }


        private void ReakziaBtn_Click(object sender, EventArgs e)
        {
            Button ReakziaBtn = (Button)sender;

            if (ReakziaBtn.BackColor == Color.Green)
            {
                MessageBox.Show("Вы выиграли! 🎉");
                ReakziaBtn.BackColor = DefaultBackColor;
                timer.Start();
            }
            else if (ReakziaBtn.BackColor == Color.Red)
            {
                MessageBox.Show("Вы проиграли! 😢");
                timer.Stop();
            }
            else
            {
                MessageBox.Show("Слишком рано!");
            }
        }

        private void InitializeButtons()
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new System.Windows.Forms.Button()
                    {
                        Location = new Point(10 + j * 80, 30 + i * 80),
                        Size = new Size(75, 75),
                        Font = new Font("Arial", 24)
                    };
                    buttons[i, j].Click += new EventHandler(PlayBtn_Click);
                    this.Controls.Add(buttons[i, j]);
                }
            }
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            if (string.IsNullOrEmpty(clickedButton.Text))
            {
                clickedButton.Text = currentPlayer;

                if (CheckWin())
                {
                    MessageBox.Show($"Поздравляем! Игрок {currentPlayer} выиграл!");
                    ResetGame();
                }
                else if (IsDraw())
                {
                    MessageBox.Show("Ничья!");
                    ResetGame();
                }
                else
                {
                    currentPlayer = currentPlayer == "X" ? "O" : "X";
                    statusLabel.Text = $"Игрок {currentPlayer}, ваш ход";
                }
            }
        }

        private bool CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if ((buttons[i, 0].Text == currentPlayer && buttons[i, 1].Text == currentPlayer && buttons[i, 2].Text == currentPlayer) ||
                    (buttons[0, i].Text == currentPlayer && buttons[1, i].Text == currentPlayer && buttons[2, i].Text == currentPlayer))
                    return true;
            }

            if ((buttons[0, 0].Text == currentPlayer && buttons[1, 1].Text == currentPlayer && buttons[2, 2].Text == currentPlayer) ||
                (buttons[0, 2].Text == currentPlayer && buttons[1, 1].Text == currentPlayer && buttons[2, 0].Text == currentPlayer))
                return true;

            return false;
        }

        private bool IsDraw()
        {
            foreach (var button in buttons)
            {
                if (string.IsNullOrEmpty(button.Text))
                    return false;
            }
            return true;
        }

        private void ResetGame()
        {
            foreach (var button in buttons)
            {
                button.Text = "";
            }
            currentPlayer = "X";
            statusLabel.Text = "Игрок X, ваш ход";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LoadImages()
        {
            images.Add(new Bitmap("C:\\Users\\nikit\\Pictures\\коты\\kanye-west.jpg"));
            images.Add(new Bitmap("C:\\Users\\nikit\\Pictures\\коты\\мейн-кун.jpg"));
            images.Add(new Bitmap("C:\\Users\\nikit\\Pictures\\коты\\сфинкс.jpg"));
            images.Add(new Bitmap("C:\\Users\\nikit\\Pictures\\коты\\шотландия.jpg"));
        }

        private void PictureBtn_Click(object sender, EventArgs e)
        {
            if (images.Count > 0)
            {
                int index = random.Next(images.Count);
                pictureBox1.Image = images[index];
            }
            else
            {
                MessageBox.Show("Список изображений пуст.");
            }
        }

        private void DeletePictureBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void InitializeRiddles()
        {
            riddles = new List<Riddle>
            {
                new Riddle("Что всегда впереди, но никогда не видно?", "будущее"),
                new Riddle("Я всегда с вами, но вы не можете меня видеть. Что я?", "воздух"),
                new Riddle("Что можно сломать, но никогда не держать в руках?", "обещание"),
                new Riddle("Что растет, когда вы берете его?", "дыра"),
                new Riddle("Что уходит, но никогда не возвращается?", "время"),
                new Riddle("У кого есть ключи, но не может открыть ни одной двери?", "пианист"),
                new Riddle("Что можно поймать, но нельзя бросить?", "простуда"),
                new Riddle("Что у вас есть, но вы не можете потерять?", "имя"),
                new Riddle("Какой месяц имеет 28 дней?", "все"),
                new Riddle("Что может быть сломано, но никогда не упадет?", "обещание"),
                new Riddle("Когда я был молод, я был зеленым, когда я старый, я коричневый. Что я?", "банан"),
                new Riddle("Что идет вверх и вниз, но никогда не двигается?", "лестница"),
                new Riddle("Какой цвет у черного кота в темноте?", "черный"),
                new Riddle("Что уходит от вас, когда вы его зовете?", "тишина"),
                new Riddle("Кто всегда говорит правду, даже когда лжет?", "зеркало"),
                new Riddle("Какой вопрос нельзя задать?", "вопрос о вопросе"),
                new Riddle("Что можно держать в руках, но нельзя увидеть?", "дыхание"),
                new Riddle("Что у вас есть два раза в минуту и один раз в моменте?", "буква 'м'"),
                new Riddle("Какой ключ не открывает никакие двери?", "ключ к шифру"),
                new Riddle("Что становится мокрым, когда высыхает?", "полотенце")
            };
            currentRiddleIndex = 0;
        }

        private void ShowNextRiddle()
        {
            if (currentRiddleIndex < riddles.Count)
            {
                riddleLabel.Text = riddles[currentRiddleIndex].Question;
            }
            else
            {
                riddleLabel.Text = "Поздравляем! Вы ответили на все загадки.";
                answerTextBox.Enabled = false;
                checkButton.Enabled = false;
            }
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
            startButton.Visible = false;
            riddleLabel.Visible = true;
            answerTextBox.Visible = true;
            checkButton.Visible = true;
            currentRiddleIndex = 0;
            ShowNextRiddle();
        }

        private void checkButton_Click_1(object sender, EventArgs e)
        {
            string userAnswer = answerTextBox.Text.Trim().ToLower();
            if (userAnswer == riddles[currentRiddleIndex].Answer.ToLower())
            {
                MessageBox.Show("Правильно!", "Ответ", MessageBoxButtons.OK);
                currentRiddleIndex++;
                answerTextBox.Clear();
                ShowNextRiddle();
            }
            else
            {
                MessageBox.Show("Неправильно. Попробуйте еще раз.", "Ответ", MessageBoxButtons.OK);
            }
        }

        public class Riddle
        {
            public string Question { get; }
            public string Answer { get; }

            public Riddle(string question, string answer)
            {
                Question = question;
                Answer = answer;
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room3 Room3 = new Room3();
            Room3.ShowDialog();
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room1 Room1 = new Room1();
            Room1.ShowDialog();
            this.Close();
        }
    }
}
