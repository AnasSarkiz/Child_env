using System.Media;


namespace Child_env
{
    public partial class Game3Form : Form
    {
        private Random random = new Random();
        private string correctAnswer;
        private int score = 0;
        private int wrongAnswers = 0;
        private int totalQuestions;
        private SoundPlayer correctSoundPlayer;
        private SoundPlayer incorrectSoundPlayer;
        private List<(string ImagePath, string CorrectLabel, string[] Options)> pictures = new List<(string ImagePath, string CorrectLabel, string[] Options)>
        {
            ("./Assets/cat.png", "cat", new[] { "dog", "cat", "rat" }),
            ("./Assets/dog.png", "dog", new[] { "cat", "dog", "rat" }),
            ("./Assets/elephant.png", "elephant", new[] { "elephant", "lion", "tiger" }),
            ("./Assets/lion.png", "lion", new[] { "elephant", "lion", "tiger" }),
            ("./Assets/tiger.png", "tiger", new[] { "elephant", "lion", "tiger" }),
            ("./Assets/bird.png", "bird", new[] { "bird", "fish", "frog" }),
            ("./Assets/fish.png", "fish", new[] { "bird", "fish", "frog" }),
            ("./Assets/frog.png", "frog", new[] { "bird", "fish", "frog" }),
        };

        public Game3Form()
        {
            InitializeComponent();
            correctSoundPlayer = new SoundPlayer("./Assets/correct.wav");
            incorrectSoundPlayer = new SoundPlayer("./Assets/incorrect.wav");
        }


        private void Game3Form_Load(object sender, EventArgs e)
        {
            totalQuestions = pictures.Count;
            progressBar.Maximum = totalQuestions;
            UpdateHearts();
            LoadNewQuestion();
        }

        private void LoadNewQuestion()
        {
            if (pictures.Count == 0)
            {
                ShowCelebration();
                return;
            }

            var selectedPicture = pictures[random.Next(pictures.Count)];
            pictureBox.Image = Image.FromFile(selectedPicture.ImagePath);
            correctAnswer = selectedPicture.CorrectLabel;

            var options = selectedPicture.Options.OrderBy(x => random.Next()).ToArray();
            btnOption1.Text = options[0];
            btnOption2.Text = options[1];
            btnOption3.Text = options[2];
            lblFeedback.Text = "";

            pictures.Remove(selectedPicture); 
        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string selectedAnswer = clickedButton.Text;

            if (selectedAnswer == correctAnswer)
            {
                lblFeedback.ForeColor = Color.Green;
                lblFeedback.Text = "Correct!";
                correctSoundPlayer.Play();
                score++;
                progressBar.Value = score;
                lblScore.Text = $"Score: {score}/{totalQuestions}";

                if (score == totalQuestions)
                {
                    ShowCelebration();
                }
                else
                {
                    LoadNewQuestion();
                }
            }
            else
            {
                lblFeedback.ForeColor = Color.Red;
                lblFeedback.Text = "Incorrect. Try again.";
                incorrectSoundPlayer.Play();
                wrongAnswers++;
                UpdateHearts();

                if (wrongAnswers == 2)
                {
                    ShowLose();
                }
            }
        }

        private void UpdateHearts()
        {
            int remainingHearts = 2 - wrongAnswers;
            lblHearts.Text = new string('❤', remainingHearts);
        }

        private void ShowCelebration()
        {
            picCelebration.Visible = true;

            SoundPlayer victorySound = new SoundPlayer("./Assets/clapping.wav");
            victorySound.Play();

            btnPlayAgain.Visible = true;
        }

        private void ShowLose()
        {
            picLose.Visible = true;
            SoundPlayer loseSound = new SoundPlayer("./Assets/lose.wav");
            loseSound.Play();

            btnPlayAgain.Visible = true;
        }

        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            score = 0;
            wrongAnswers = 0;
            pictures = new List<(string ImagePath, string CorrectLabel, string[] Options)>
            {
                ("./Assets/cat.png", "cat", new[] { "dog", "cat", "rat" }),
                ("./Assets/dog.png", "dog", new[] { "cat", "dog", "rat" }),
                ("./Assets/elephant.png", "elephant", new[] { "elephant", "lion", "tiger" }),
                ("./Assets/lion.png", "lion", new[] { "elephant", "lion", "tiger" }),
                ("./Assets/tiger.png", "tiger", new[] { "elephant", "lion", "tiger" }),
                ("./Assets/bird.png", "bird", new[] { "bird", "fish", "frog" }),
                ("./Assets/fish.png", "fish", new[] { "bird", "fish", "frog" }),
                ("./Assets/frog.png", "frog", new[] { "bird", "fish", "frog" }),
            };

            UpdateHearts();
            progressBar.Value = 0;
            picCelebration.Visible = false;
            picLose.Visible = false;
            btnPlayAgain.Visible = false;
            LoadNewQuestion();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}