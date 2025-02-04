using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Child_env
{
    partial class Game3Form
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonHome;
        private Label lblQuestion;
        private Button btnOption1;
        private Button btnOption2;
        private Button btnOption3;
        private PictureBox pictureBox;
        private Label lblFeedback;
        private Label lblScore;
        private Label lblHearts;
        private ProgressBar progressBar;
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
            buttonHome = new Button();
            lblQuestion = new Label();
            btnOption1 = new Button();
            btnOption2 = new Button();
            btnOption3 = new Button();
            pictureBox = new PictureBox();
            lblFeedback = new Label();
            lblScore = new Label();
            lblHearts = new Label();
            progressBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
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
            lblQuestion.Location = new Point(12, 70);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(860, 50);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "What is the name of this animal";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOption1
            // 
            btnOption1.BackColor = Color.LightGreen;
            btnOption1.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            btnOption1.Location = new Point(62, 140);
            btnOption1.Name = "btnOption1";
            btnOption1.Size = new Size(240, 60);
            btnOption1.TabIndex = 2;
            btnOption1.UseVisualStyleBackColor = false;
            btnOption1.Click += OptionButton_Click;
            // 
            // btnOption2
            // 
            btnOption2.BackColor = Color.LightGreen;
            btnOption2.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            btnOption2.Location = new Point(328, 140);
            btnOption2.Name = "btnOption2";
            btnOption2.Size = new Size(240, 60);
            btnOption2.TabIndex = 3;
            btnOption2.UseVisualStyleBackColor = false;
            btnOption2.Click += OptionButton_Click;
            // 
            // btnOption3
            // 
            btnOption3.BackColor = Color.LightGreen;
            btnOption3.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            btnOption3.Location = new Point(594, 140);
            btnOption3.Name = "btnOption3";
            btnOption3.Size = new Size(240, 60);
            btnOption3.TabIndex = 4;
            btnOption3.UseVisualStyleBackColor = false;
            btnOption3.Click += OptionButton_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(313, 220);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(240, 240);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            lblFeedback.ForeColor = Color.Red;
            lblFeedback.Location = new Point(359, 470);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(0, 27);
            lblFeedback.TabIndex = 6;
            lblFeedback.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            lblScore.ForeColor = Color.DarkBlue;
            lblScore.Location = new Point(12, 470);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(0, 27);
            lblScore.TabIndex = 7;
            // 
            // lblHearts
            // 
            lblHearts.AutoSize = true;
            lblHearts.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            lblHearts.ForeColor = Color.Red;
            lblHearts.Location = new Point(800, 470);
            lblHearts.Name = "lblHearts";
            lblHearts.Size = new Size(0, 27);
            lblHearts.TabIndex = 8;
            // Celebration PictureBox
            picCelebration = new PictureBox();
            picCelebration.Size = new Size(200, 200);
            picCelebration.Location = new Point(350, 200);
            picCelebration.BorderStyle = BorderStyle.FixedSingle;
            picCelebration.SizeMode = PictureBoxSizeMode.StretchImage;
            picCelebration.Visible = false;
            this.Controls.Add(picCelebration);

            // Lose PictureBox
            picLose = new PictureBox();
            picLose.Size = new Size(200, 200);
            picLose.Location = new Point(350, 200);
            picLose.Image = Image.FromFile("./Assets/lose.png");
            picLose.BorderStyle = BorderStyle.FixedSingle;
            picLose.SizeMode = PictureBoxSizeMode.StretchImage;
            picLose.Visible = false;
            this.Controls.Add(picLose);



            // Play Again Button
            btnPlayAgain = new Button();
            btnPlayAgain.Text = "Play Again";
            btnPlayAgain.Font = new Font("Comic Sans MS", 14, FontStyle.Bold);
            btnPlayAgain.BackColor = Color.LightBlue;
            btnPlayAgain.Location = new Point(370, 450);
            btnPlayAgain.Size = new Size(150, 50);
            btnPlayAgain.Visible = false;
            btnPlayAgain.Click += BtnPlayAgain_Click;
            this.Controls.Add(btnPlayAgain);
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 510);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(860, 30);
            progressBar.TabIndex = 9;
            // 
            // Game3Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(884, 661);
            Controls.Add(buttonHome);
            Controls.Add(lblQuestion);
            Controls.Add(btnOption1);
            Controls.Add(btnOption2);
            Controls.Add(btnOption3);
            Controls.Add(pictureBox);
            Controls.Add(lblFeedback);
            Controls.Add(lblScore);
            Controls.Add(lblHearts);
            Controls.Add(progressBar);
            MaximumSize = new Size(900, 700);
            MinimumSize = new Size(900, 700);
            Name = "Game3Form";
            Text = "Animal Quiz";
            Load += Game3Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}