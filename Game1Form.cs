using System.Media;

namespace Child_env
{
    public partial class Game1Form : Form
    {
        private Button firstClicked = null;
        private Button secondClicked = null;
        private Random random = new Random();
        private SoundPlayer correctSound;
        private List<string> icons = new List<string>()
        {
            "🐎", "🐎", "🐣", "🐣", "🦎", "🦎", "🐋", "🐋",
            "🐨", "🐨", "🐜", "🐜", "🌹", "🌹", "🌲", "🌲"
        };
        private PictureBox pictureBox;

        public Game1Form()
        {
            InitializeComponent();
            InitializeCardButtons();
            AssignIconsToSquares();
            InitializeCelebration();
            correctSound = new SoundPlayer("./Assets/correct.wav");
        }

        private void InitializeCardButtons()
        {
            this.cardButtons = new Button[16];
            for (int i = 0; i < 16; i++)
            {
                this.cardButtons[i] = new Button();
                this.cardButtons[i].Dock = DockStyle.Fill;
                this.cardButtons[i].Font = new Font("Arial", 36, FontStyle.Bold);
                this.cardButtons[i].TextAlign = ContentAlignment.MiddleCenter;
                this.cardButtons[i].Click += new EventHandler(this.CardButton_Click);
                this.tableLayoutPanel.Controls.Add(this.cardButtons[i]);
            }
        }

        private void InitializeCelebration()
        {
            pictureBox = new PictureBox
            {
                Size = new Size(400, 400),
                Location = new Point((this.ClientSize.Width - 400) / 2, (this.ClientSize.Height - 400) / 2),
                Image = Image.FromFile("./Assets/congratulations.jpg"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Visible = false
            };
            this.Controls.Add(pictureBox);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AssignIconsToSquares()
        {
            foreach (Button button in cardButtons)
            {
                int randomNumber = random.Next(icons.Count);
                button.Tag = icons[randomNumber];
                button.Text = "";
                button.BackColor = Color.SeaGreen;
                icons.RemoveAt(randomNumber);
            }
        }

        private void CardButton_Click(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
                return;

            Button clickedButton = sender as Button;

            if (clickedButton == null)
                return;

            if (clickedButton.Text != "")
                return;

            if (firstClicked == null)
            {
                firstClicked = clickedButton;
                firstClicked.Text = firstClicked.Tag.ToString();
                return;
            }

            secondClicked = clickedButton;
            secondClicked.Text = secondClicked.Tag.ToString();

            CheckForWinner();

            if (firstClicked.Tag.ToString() == secondClicked.Tag.ToString())
            {
                correctSound.Play();
                firstClicked = null;
                secondClicked = null;
            }
            else
            {
                timer1.Start();
            }
        }

        private void CheckForWinner()
        {
            foreach (Button button in cardButtons)
            {
                if (button.Text == "")
                    return;
            }

            ShowCelebration();
        }

        private void ShowCelebration()
        {
            SoundPlayer player = new SoundPlayer("./Assets/clapping.wav");
            player.Play();

            pictureBox.Visible = true;
            pictureBox.BringToFront();
            pictureBox.BorderStyle = BorderStyle.Fixed3D;

            System.Windows.Forms.Timer soundTimer = new System.Windows.Forms.Timer();
            soundTimer.Interval = 5000; // 5 seconds
            soundTimer.Tick += (s, e) =>
            {
                player.Stop();
                soundTimer.Stop();
            };
            soundTimer.Start();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += (s, e) =>
            {
                pictureBox.Visible = false;
                timer.Stop();
                this.Close();
            };
            timer.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.Text = "";
            secondClicked.Text = "";
            firstClicked = null;
            secondClicked = null;
        }

        private void Game1Form_Load(object sender, EventArgs e)
        {

        }
    }
}