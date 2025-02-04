using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Child_env
{
    public partial class Game3Form : Form
    {
        private readonly Random random = new Random();
        private string correctAnswer;
        private int score;
        private int wrongAnswers;
        private int totalQuestions;
        private SoundPlayer victorySound;
        private SoundPlayer loseSound;
        private SoundPlayer correctSoundPlayer;
        private SoundPlayer incorrectSoundPlayer;
        private List<(string ImagePath, string CorrectLabel, string[] Options)> pictures;

        public Game3Form()
        {
            InitializeComponent();
            correctSoundPlayer = new SoundPlayer(Path.Combine("./Assets", "correct.wav"));
            incorrectSoundPlayer = new SoundPlayer(Path.Combine("./Assets", "incorrect.wav"));
            InitializeAssets();
        }

        private void Game3Form_Load(object sender, EventArgs e)
        {
            totalQuestions = pictures.Count;
            progressBar.Maximum = totalQuestions;
            UpdateHearts();
            LoadNewQuestion();
        }

        private void InitializeAssets()
        {
            victorySound = new SoundPlayer(Path.Combine("./Assets", "clapping.wav"));
            picCelebration.Image = Image.FromFile("./Assets/congratulations.png");
            loseSound = new SoundPlayer(Path.Combine("./Assets", "lose.wav"));
            pictures = new List<(string, string, string[])>
            {
                (Path.Combine("./Assets", "cat.png"), "cat", new[] { "dog", "cat", "rat" }),
                (Path.Combine("./Assets", "dog.png"), "dog", new[] { "cat", "dog", "rat" }),
                (Path.Combine("./Assets", "elephant.png"), "elephant", new[] { "elephant", "lion", "tiger" }),
                (Path.Combine("./Assets", "lion.png"), "lion", new[] { "elephant", "lion", "tiger" }),
                (Path.Combine("./Assets", "tiger.png"), "tiger", new[] { "elephant", "lion", "tiger" }),
                (Path.Combine("./Assets", "bird.png"), "bird", new[] { "bird", "fish", "frog" }),
                (Path.Combine("./Assets", "fish.png"), "fish", new[] { "bird", "fish", "frog" }),
                (Path.Combine("./Assets", "frog.png"), "frog", new[] { "bird", "fish", "frog" }),
            };
        }

        private void LoadNewQuestion()
        {
            if (pictures.Count == 0)
            {
                ShowCelebration();
                return;
            }

            var selected = pictures[random.Next(pictures.Count)];
            pictureBox.Image = Image.FromFile(selected.ImagePath);
            correctAnswer = selected.CorrectLabel;
            var options = selected.Options.OrderBy(x => random.Next()).ToArray();

            btnOption1.Text = options[0];
            btnOption2.Text = options[1];
            btnOption3.Text = options[2];
            lblFeedback.Text = "";

            pictures.Remove(selected);
        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
            var clickedButton = sender as Button;
            if (clickedButton == null)
                return;

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
                    ShowCelebration();
                else
                    LoadNewQuestion();
            }
            else
            {
                lblFeedback.ForeColor = Color.Red;
                lblFeedback.Text = "Incorrect. Try again.";
                incorrectSoundPlayer.Play();
                wrongAnswers++;
                UpdateHearts();
                if (wrongAnswers == 2)
                    ShowLose();
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
           victorySound.Play();
            btnOption1.Visible = false;
            btnOption2.Visible = false;
            btnOption3.Visible = false;
            pictureBox.Visible = false;
            lblQuestion.Visible = false;
            lblFeedback.Visible = false;
            btnPlayAgain.Visible = true;
        }

        private void ShowLose()
        {
            picLose.Visible = true;
            loseSound.Play();
            btnOption1.Visible = false;
            btnOption2.Visible = false;
            btnOption3.Visible = false;
            pictureBox.Visible = false;
            lblQuestion.Visible = false;
            lblFeedback.Visible = false;
            btnPlayAgain.Visible = true;
        }

        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            score = 0;
            wrongAnswers = 0;
            InitializeAssets();
            btnOption1.Visible = true;
            btnOption2.Visible = true;
            btnOption3.Visible = true;
            pictureBox.Visible = true;
            lblFeedback.Visible = true;
            lblQuestion.Visible = true;
            UpdateHearts();
            progressBar.Value = 0;
            picCelebration.Visible = false;
            picLose.Visible = false;
            btnPlayAgain.Visible = false;
            LoadNewQuestion();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            victorySound.Stop();
            loseSound.Stop();
            Close();
        }
    }
}
