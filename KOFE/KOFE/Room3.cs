namespace KOFE
{
    public partial class Room3 : Form
    {
        private const int gridSize = 10;
        private const int mineCount = 10;
        private Button[,] buttons = new Button[gridSize, gridSize];
        private int[,] mines;
        private bool gameEnded;
        private Deck deck;
        private int playerScore;
        private int dealerScore;
        private Label lblPlayerScore;
        private Label lblDealerScore;

        public Room3()
        {
            InitializeComponent();
            InitializeLabels();
            StartNewGame();
        }

        private void InitializeLabels()
        {
            lblPlayerScore = new Label();
            lblPlayerScore.Location = new Point(10, gridSize * 40 + 10);
            lblPlayerScore.AutoSize = true;
            this.Controls.Add(lblPlayerScore);

            lblDealerScore = new Label();
            lblDealerScore.Location = new Point(200, gridSize * 40 + 10);
            lblDealerScore.AutoSize = true;
            this.Controls.Add(lblDealerScore);

        }


        private void InitializeGame()
        {
            mines = new int[gridSize, gridSize];
            gameEnded = false;

            for (int x = 0; x < gridSize; x++)
            {
                for (int y = 0; y < gridSize; y++)
                {
                    buttons[x, y] = new Button();
                    buttons[x, y].Size = new Size(40, 40);
                    buttons[x, y].Location = new Point(x * 40, y * 40);
                    buttons[x, y].Click += Button_Click;
                    buttons[x, y].Tag = new Point(x, y);
                    this.Controls.Add(buttons[x, y]);
                }
            }

            PlaceMines();
            SetNumbers();
        }

        private void ResetGame()
        {
            StartNewGame();
        }
        private void PlaceMines()
        {
            Random rand = new Random();
            int placedMines = 0;

            while (placedMines < mineCount)
            {
                int x = rand.Next(gridSize);
                int y = rand.Next(gridSize);

                if (mines[x, y] == 0)
                {
                    mines[x, y] = -1;
                    placedMines++;
                }
            }
        }

        private void SetNumbers()
        {
            for (int x = 0; x < gridSize; x++)
            {
                for (int y = 0; y < gridSize; y++)
                {
                    if (mines[x, y] == -1) continue;

                    int count = 0;
                    for (int dx = -1; dx <= 1; dx++)
                    {
                        for (int dy = -1; dy <= 1; dy++)
                        {
                            if (x + dx >= 0 && x + dx < gridSize &&
                                y + dy >= 0 && y + dy < gridSize &&
                                mines[x + dx, y + dy] == -1)
                            {
                                count++;
                            }
                        }
                    }
                    mines[x, y] = count;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (gameEnded) return;

            Button button = sender as Button;
            Point location = (Point)button.Tag;

            if (mines[location.X, location.Y] == -1)
            {
                MessageBox.Show("Игра окончена! Вы попали на мину.");
                RevealMines();
                gameEnded = true;
                return;
            }

            button.Text = mines[location.X, location.Y].ToString();
            button.Enabled = false;

            CheckWin();
        }

        private void RevealMines()
        {
            for (int x = 0; x < gridSize; x++)
            {
                for (int y = 0; y < gridSize; y++)
                {
                    if (mines[x, y] == -1)
                    {
                        buttons[x, y].Text = "💣";
                        buttons[x, y].BackColor = Color.Red;
                    }
                    buttons[x, y].Enabled = false;
                }
            }
        }

        private void CheckWin()
        {
            foreach (Button button in buttons)
            {
                Point location = (Point)button.Tag;
                if (button.Enabled && mines[location.X, location.Y] != -1)
                    return;
            }

            MessageBox.Show("Поздравляем! Вы выиграли!");
            gameEnded = true;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void StartNewGame()
        {
            deck = new Deck();
            deck.Shuffle();
            playerScore = 0;
            dealerScore = 0;
            UpdateScores();
        }
        private void UpdateScores()
        {
            lblPlayerScore.Text = $"Ваши очки: {playerScore}";
            lblDealerScore.Text = $"Очки дилера: {dealerScore}";
        }

        private void CheckForWin()
        {
            if (playerScore > 21)
            {
                MessageBox.Show("Вы проиграли!");
                StartNewGame();
            }
        }

        private void CheckForWinner()
        {
            if (dealerScore > 21 || playerScore > dealerScore)
            {
                MessageBox.Show("Вы выиграли!");
            }
            else if (playerScore == dealerScore)
            {
                MessageBox.Show("Ничья!");
            }
            else
            {
                MessageBox.Show("Вы проиграли!");
            }

            StartNewGame();
        }

        private void btnStand_Click_1(object sender, EventArgs e)
        {
            while (dealerScore < 17)
            {
                Card card = deck.Draw();
                if (card != null)
                {
                    dealerScore += card.GetValue();
                }
            }
            UpdateScores();
            CheckForWinner();
        }

        private void btnHit_Click_1(object sender, EventArgs e)
        {
            Card card = deck.Draw();
            if (card != null)
            {
                playerScore += card.GetValue();
                UpdateScores();
                CheckForWin();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room2 Room2 = new Room2();
            Room2.ShowDialog();
            this.Close();
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }

    public class Card
    {
        public string Suit { get; set; }
        public string Value { get; set; }

        public int GetValue()
        {
            if (Value == "A") return 11;
            if (Value == "K" || Value == "Q" || Value == "J") return 10;
            return int.Parse(Value);
        }
    }

    public class Deck
    {
        private List<Card> cards;
        private Random random;

        public Deck()
        {
            random = new Random();
            cards = new List<Card>();
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    cards.Add(new Card { Suit = suit, Value = value });
                }
            }
        }

        public void Shuffle()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                int j = random.Next(i, cards.Count);
                var temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public Card Draw()
        {
            if (cards.Count == 0) return null;
            var card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
    }
}