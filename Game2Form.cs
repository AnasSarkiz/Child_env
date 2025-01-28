using System.Media;

namespace Child_env
{
    public partial class Game2Form : Form
    {
        private Random random = new Random();
        private int correctAnswer;
        private int playerProgress = 25;
        private int opponentProgress = 25;
        private SoundPlayer engineSoundPlayer;

        public Game2Form()
        {
            InitializeComponent();
            engineSoundPlayer = new SoundPlayer("./Assets/car_engine.wav");
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            engineSoundPlayer.PlayLooping();
            startBtn.Visible = false;
            GenerateQuestion();
            timer.Start();
        }

        private void GenerateQuestion()
        {
            int num1 = random.Next(1, 10);
            int num2 = random.Next(1, num1);
            string[] operators = { "+", "-" };
            string selectedOperator = operators[random.Next(operators.Length)];

            switch (selectedOperator)
            {
                case "+":
                    correctAnswer = num1 + num2;
                    break;
                case "-":
                    correctAnswer = num1 - num2;
                    break;
            }

            lblQuestion.Text = $"{num1} {selectedOperator} {num2} = ?";

            int wrongAnswer1 = correctAnswer + random.Next(1, 5);
            int wrongAnswer2 = correctAnswer - random.Next(1, 5);
            if (wrongAnswer2 < 0) wrongAnswer2 = Math.Abs(wrongAnswer2) + 1;

            var options = new[] { correctAnswer, wrongAnswer1, wrongAnswer2 }.OrderBy(x => random.Next()).ToArray();

            btnOption1.Text = options[0].ToString();
            btnOption2.Text = options[1].ToString();
            btnOption3.Text = options[2].ToString();
            lblFeedback.Text = "";
        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int selectedAnswer = int.Parse(clickedButton.Text);

            if (selectedAnswer == correctAnswer)
            {
                playerProgress += 25;
                UpdateCarPositions();
                if (playerProgress >= (raceTrackPanel.Height * 0.85) - playerCar.Height)
                {
                    timer.Stop();
                    engineSoundPlayer.Stop();
                    ShowCelebration();
                }
                else
                {
                    GenerateQuestion();
                }
            }
            else
            {
                lblFeedback.Text = "Incorrect answer. Try again.";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            opponentProgress += random.Next(4, 10);
            if (opponentProgress >= (raceTrackPanel.Height * 0.85) - opponentCar.Height)
            {
                timer.Stop();
                engineSoundPlayer.Stop();
                ShowLose();
            }
            UpdateCarPositions();
        }

        private void UpdateCarPositions()
        {
            playerCar.Top = playerProgress;
            opponentCar.Top = opponentProgress;
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
            playerProgress = 0;
            opponentProgress = 0;
            UpdateCarPositions();
            picCelebration.Visible = false;
            picLose.Visible = false;
            btnPlayAgain.Visible = false;
            startBtn.Visible = true;
            GenerateQuestion();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            engineSoundPlayer.Stop();
            this.Close();
        }
        private void raceTrackPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}