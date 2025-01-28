namespace Child_env
{
    partial class Game2Form
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonHome;
        private Label lblQuestion;
        private Button btnOption1;
        private Button btnOption2;
        private Button btnOption3;
        private Panel raceTrackPanel;
        private PictureBox playerCar;
        private PictureBox opponentCar;
        private System.Windows.Forms.Timer timer;
        private Label lblFeedback;
        private PictureBox picCelebration;
        private PictureBox picLose;
        private Button btnPlayAgain;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game2Form));
            buttonHome = new Button();
            lblQuestion = new Label();
            btnOption1 = new Button();
            btnOption2 = new Button();
            btnOption3 = new Button();
            raceTrackPanel = new Panel();
            playerCar = new PictureBox();
            opponentCar = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            lblFeedback = new Label();
            startBtn = new Button();
            raceTrackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)opponentCar).BeginInit();
            SuspendLayout();
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.LightBlue;
            buttonHome.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.Location = new Point(10, 10);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(150, 50);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            lblQuestion.ForeColor = Color.DarkBlue;
            lblQuestion.Location = new Point(12, 19);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(860, 50);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Question";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOption1
            // 
            btnOption1.BackColor = Color.LightGreen;
            btnOption1.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            btnOption1.Location = new Point(62, 89);
            btnOption1.Name = "btnOption1";
            btnOption1.Size = new Size(240, 60);
            btnOption1.TabIndex = 1;
            btnOption1.UseVisualStyleBackColor = false;
            btnOption1.Click += OptionButton_Click;
            // 
            // btnOption2
            // 
            btnOption2.BackColor = Color.LightGreen;
            btnOption2.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            btnOption2.Location = new Point(328, 89);
            btnOption2.Name = "btnOption2";
            btnOption2.Size = new Size(240, 60);
            btnOption2.TabIndex = 2;
            btnOption2.UseVisualStyleBackColor = false;
            btnOption2.Click += OptionButton_Click;
            // 
            // btnOption3
            // 
            btnOption3.BackColor = Color.LightGreen;
            btnOption3.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            btnOption3.Location = new Point(594, 89);
            btnOption3.Name = "btnOption3";
            btnOption3.Size = new Size(240, 60);
            btnOption3.TabIndex = 3;
            btnOption3.UseVisualStyleBackColor = false;
            btnOption3.Click += OptionButton_Click;
            // 
            // raceTrackPanel
            // 
            raceTrackPanel.BackColor = Color.Gray;
            raceTrackPanel.BackgroundImage = (Image)resources.GetObject("raceTrackPanel.BackgroundImage");
            raceTrackPanel.BackgroundImageLayout = ImageLayout.Stretch;
            raceTrackPanel.Controls.Add(playerCar);
            raceTrackPanel.Controls.Add(opponentCar);
            raceTrackPanel.Location = new Point(313, 201);
            raceTrackPanel.Name = "raceTrackPanel";
            raceTrackPanel.Size = new Size(269, 433);
            raceTrackPanel.TabIndex = 6;
            raceTrackPanel.Paint += raceTrackPanel_Paint;
            // 
            // playerCar
            // 
            playerCar.BackColor = Color.Transparent;
            playerCar.Location = new Point(61, 25);
            playerCar.Name = "playerCar";
            playerCar.Size = new Size(66, 50);
            playerCar.SizeMode = PictureBoxSizeMode.StretchImage;
            playerCar.Image = Image.FromFile("./Assets/blueCar.png");
            playerCar.TabIndex = 7;
            playerCar.TabStop = false;
            // 
            // opponentCar
            // 
            opponentCar.BackColor = Color.Transparent;
            opponentCar.Location = new Point(133, 25);
            opponentCar.Name = "opponentCar";
            opponentCar.Size = new Size(66, 50);
            opponentCar.SizeMode = PictureBoxSizeMode.StretchImage;
            opponentCar.Image = Image.FromFile("./Assets/yellowCar.png");
            opponentCar.TabIndex = 8;
            opponentCar.TabStop = false;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFeedback.ForeColor = Color.Red;
            lblFeedback.Location = new Point(359, 177);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(0, 21);
            lblFeedback.TabIndex = 9;
            lblFeedback.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startBtn
            // 
            startBtn.BackColor = Color.LightBlue;
            startBtn.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startBtn.Location = new Point(722, 12);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(150, 50);
            startBtn.TabIndex = 10;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += StartButton_Click;
            // Celebration PictureBox
            picCelebration = new PictureBox();
            picCelebration.Size = new Size(200, 200);
            picCelebration.Location = new Point(350, 200);
            picCelebration.Image = Image.FromFile("./Assets/congratulations.jpg"); 
            picCelebration.SizeMode = PictureBoxSizeMode.StretchImage;
            picCelebration.Visible = false;
            this.Controls.Add(picCelebration);

            // Lose PictureBox
            picLose = new PictureBox();
            picLose.Size = new Size(200, 200);
            picLose.Location = new Point(350, 200);
            picLose.Image = Image.FromFile("./Assets/lose.png"); 
            picLose.SizeMode = PictureBoxSizeMode.StretchImage;
            picLose.Visible = false;
            this.Controls.Add(picLose);
            // Play Again Button
            btnPlayAgain = new Button();
            btnPlayAgain.Text = "Play Again";
            btnPlayAgain.Font = new Font("Comic Sans MS", 14, FontStyle.Bold);
            btnPlayAgain.BackColor = Color.LightBlue;
            btnPlayAgain.Location = new Point(380, 450);
            btnPlayAgain.Size = new Size(150, 50);
            btnPlayAgain.Visible = false;
            btnPlayAgain.Click += BtnPlayAgain_Click;
            this.Controls.Add(btnPlayAgain);
        // 
        // Game2Form
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 661);
            Controls.Add(startBtn);
            Controls.Add(buttonHome);
            Controls.Add(lblQuestion);
            Controls.Add(btnOption1);
            Controls.Add(btnOption2);
            Controls.Add(btnOption3);
            Controls.Add(lblFeedback);
            Controls.Add(raceTrackPanel);
            MaximumSize = new Size(900, 700);
            MinimumSize = new Size(900, 700);
            Name = "Game2Form";
            Text = "Math Racer";
            raceTrackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)playerCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)opponentCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button startBtn;
    }
}