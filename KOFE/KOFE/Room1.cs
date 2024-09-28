namespace KOFE
{
    public partial class Room1 : Form
    {
        private int playerScore = 0;
        private int computerScore = 0;
        private Random random = new Random();
        private double balance = 100.0;

        public Room1()
        {
            InitializeComponent();
            LoadComboBoxItems();
        }

        private void reshitBtn_Click(object sender, EventArgs e)
        {
            double x0, prevx, x, n, a, E;
            x0 = 2;
            prevx = x0;
            x = 0;
            n = double.Parse(ATxt.Text);
            a = double.Parse(BTxt.Text);
            E = 0.01;
            if (n % 2 == 0 && a < 0)
            {
                MessageBox.Show("�������� 'a' �� ����� ���� �������������");
            }
            else if (n % 2 == 1 && a < 0)
            {
                x = Math.Abs(Answer(x0, n, a, E));
                MessageBox.Show($"-{x}^{n} = {a}");
            }
            else
            {
                x = Math.Abs(Answer(x0, n, a, E));
                MessageBox.Show($"{x}^{n} = {a}");
            }
        }

        public static double Answer(double x0, double n, double a, double E)
        {
            double prevx = x0;
            double x;
            while (Math.Abs(Math.Pow(prevx, n) - a) > E)
            {
                if (n % 2 == 1 && a < 0 || n % 2 == 0 && a >= 0 || n % 2 == 1 && a >= 0)
                {
                    if (Math.Pow(prevx, n) == a)
                    {
                        break;
                    }
                    else
                    {
                        x = (1 / n) * ((n - 1) * prevx + a / (Math.Pow(prevx, n - 1)));
                        prevx = x;
                    }
                }
                else
                {
                    break;
                }
            }
            return prevx;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LoadComboBoxItems()
        {
            comboBox1.Items.Add("����-���");
            comboBox1.Items.Add("����������� ���");
            comboBox1.Items.Add("������");
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\nikit\\Pictures\\����\\����-���.jpg");
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\nikit\\Pictures\\����\\���������.jpg");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("C:\\Users\\nikit\\Pictures\\����\\������.jpg");
                    break;
                default:
                    pictureBox1.Image = null;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            comboBox1.SelectedIndex = -1;
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            int playerRoll = RollDice();
            int computerRoll = RollDice();

            MessageBox.Show($"�� ���������: {playerRoll}\n��������� ��������: {computerRoll}");

            if (playerRoll > computerRoll)
            {
                playerScore++;
                MessageBox.Show("�� ��������!");
            }
            else if (playerRoll < computerRoll)
            {
                computerScore++;
                MessageBox.Show("�� ���������.");
            }
            else
            {
                MessageBox.Show("�����.");
            }

            ScoreLabel.Text = $"����: �� - {playerScore}, ��������� - {computerScore}";
        }

        private int RollDice()
        {
            return random.Next(1, 7);
        }

        private void kazinoBtn_Click(object sender, EventArgs e)
        {
            Form casinoForm = new Form();

            Label balanceLabel = new Label() { Text = $"��� ������: {balance}", Location = new Point(10, 10), AutoSize = true };

            Label betLabel = new Label() { Text = "������� ������:", Location = new Point(10, 40), AutoSize = true };

            TextBox betTextBox = new TextBox() { Location = new Point(120, 40), Width = 100 };

            Label numberLabel = new Label() { Text = "�������� ����� (0-36):", Location = new Point(10, 70), AutoSize = true };

            NumericUpDown numberNumericUpDown = new NumericUpDown() { Location = new Point(120, 70), Minimum = 0, Maximum = 36 };

            Button playButton = new Button() { Text = "������", Location = new Point(10, 100) };

            Label resultLabel = new Label() { Location = new Point(10, 130), AutoSize = true };

            playButton.Click += (s, args) =>
            {
                double bet;

                if (!double.TryParse(betTextBox.Text, out bet) || bet <= 0 || bet > balance)
                {
                    MessageBox.Show("������������ ������. ���������� �����.");
                    return;
                }

                int chosenNumber = (int)numberNumericUpDown.Value;

                int winningNumber = random.Next(0, 37);

                if (chosenNumber == winningNumber)
                {
                    resultLabel.Text = $"���������� �����: {winningNumber}. �����������! �� ��������!";
                    balance += bet * 35;
                }
                else
                {
                    resultLabel.Text = $"���������� �����: {winningNumber}. � ���������, �� ���������.";
                    balance -= bet;
                }

                balanceLabel.Text = $"��� ������: {balance}";

                if (balance <= 0)
                {
                    resultLabel.Text += "\n� ��� ����������� ������! ���� ��������.";
                    playButton.Enabled = false;
                }

                casinoForm.Controls.Add(resultLabel);

                casinoForm.Controls.Add(balanceLabel);

                casinoForm.Controls.Clear();
                casinoForm.Controls.Add(balanceLabel);
                casinoForm.Controls.Add(betLabel);
                casinoForm.Controls.Add(betTextBox);
                casinoForm.Controls.Add(numberLabel);
                casinoForm.Controls.Add(numberNumericUpDown);
                casinoForm.Controls.Add(playButton);
                casinoForm.Controls.Add(resultLabel);

                foreach (Control control in casinoForm.Controls)
                {
                    control.Refresh();
                }
            };

            casinoForm.Controls.Add(balanceLabel);
            casinoForm.Controls.Add(betLabel);
            casinoForm.Controls.Add(betTextBox);
            casinoForm.Controls.Add(numberLabel);
            casinoForm.Controls.Add(numberNumericUpDown);
            casinoForm.Controls.Add(playButton);
            casinoForm.Controls.Add(resultLabel);

            casinoForm.Text = "������ - �������";
            casinoForm.Size = new Size(300, 250);
            casinoForm.ShowDialog();
        }

        private void chisloBtn_Click(object sender, EventArgs e)
        {
            int targetNumber = random.Next(1, 11);
            int attempts = 3;

            Form guessForm = new Form();

            Label instructionLabel = new Label() { Text = "�������� ����� �� 1 �� 10:", Location = new Point(10, 10), AutoSize = true };

            NumericUpDown guessNumericUpDown = new NumericUpDown() { Location = new Point(10, 40), Minimum = 1, Maximum = 10 };

            Button guessButton = new Button() { Text = "�������", Location = new Point(10, 70) };

            Label resultLabel = new Label() { Location = new Point(10, 100), AutoSize = true };

            guessButton.Click += (s, args) =>
            {
                int guess = (int)guessNumericUpDown.Value;

                if (guess == targetNumber)
                {
                    resultLabel.Text = "�����������! �� ������� �����.";
                    balance += 10;
                    balanceLabel.Text = $"��� ������: {balance}";
                }
                else
                {
                    attempts--;
                    resultLabel.Text = $"�����������. � ��� �������� {attempts} �������.";
                }

                if (attempts == 0)
                {
                    resultLabel.Text = $"�� ���������. ���������� �����: {targetNumber}";
                    balance -= 5;
                    balanceLabel.Text = $"��� ������: {balance}";
                    guessButton.Enabled = false;
                }
            };

            guessForm.Controls.Add(instructionLabel);
            guessForm.Controls.Add(guessNumericUpDown);
            guessForm.Controls.Add(guessButton);
            guessForm.Controls.Add(resultLabel);

            guessForm.Text = "������ �����";
            guessForm.Size = new Size(250, 200);
            guessForm.ShowDialog();
        }

        private void KamenBtn_Click(object sender, EventArgs e)
        {
            Form rpsForm = new Form();

            Label label = new Label() { Text = "��������: ������, ������� ��� ������", Location = new Point(10, 10), AutoSize = true };

            RadioButton rockButton = new RadioButton() { Text = "������", Location = new Point(10, 40) };
            RadioButton paperButton = new RadioButton() { Text = "������", Location = new Point(10, 70) };
            RadioButton scissorsButton = new RadioButton() { Text = "�������", Location = new Point(10, 100) };

            Button playButton = new Button() { Text = "������", Location = new Point(10, 130) };
            Label resultLabel = new Label() { Location = new Point(10, 160), AutoSize = true };

            playButton.Click += (s, args) =>
            {
                string playerChoice = "";
                if (rockButton.Checked)
                    playerChoice = "������";
                else if (paperButton.Checked)
                    playerChoice = "������";
                else if (scissorsButton.Checked)
                    playerChoice = "�������";

                if (playerChoice == "")
                {
                    MessageBox.Show("����������, ��������!");
                    return;
                }

                string[] options = { "������", "������", "�������" };
                string computerChoice = options[random.Next(0, 3)];

                string result = "";
                if (playerChoice == computerChoice)
                {
                    result = "�����!";
                }
                else if ((playerChoice == "������" && computerChoice == "�������") ||
                         (playerChoice == "������" && computerChoice == "������") ||
                         (playerChoice == "�������" && computerChoice == "������"))
                {
                    result = "�� ��������!";
                    balance += 5;
                }
                else
                {
                    result = "�� ���������.";
                    balance -= 5;
                }

                resultLabel.Text = $"�� �������: {playerChoice}\n��������� ������: {computerChoice}\n���������: {result}\n��� ������: {balance}";
            };

            rpsForm.Controls.Add(label);
            rpsForm.Controls.Add(rockButton);
            rpsForm.Controls.Add(paperButton);
            rpsForm.Controls.Add(scissorsButton);
            rpsForm.Controls.Add(playButton);
            rpsForm.Controls.Add(resultLabel);

            rpsForm.Text = "������, �������, ������";
            rpsForm.Size = new Size(300, 250);
            rpsForm.Show();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room2 Room2 = new Room2();
            Room2.ShowDialog();
            this.Close();
        }
    }
}