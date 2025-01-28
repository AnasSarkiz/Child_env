namespace Child_env
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonHome;
        private Button buttonGame1;
        private Button buttonGame2;
        private Button buttonGame3;
        private Button exitBtn;
        private Label lblDescription;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            buttonHome = new Button();
            buttonGame1 = new Button();
            buttonGame2 = new Button();
            buttonGame3 = new Button();
            exitBtn = new Button();
            lblDescription = new Label();
            memoryLbl = new Label();
            raceLbl = new Label();
            PictureLbl = new Label();
            SuspendLayout();
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.Ivory;
            buttonHome.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(10, 10);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(150, 50);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonGame1
            // 
            buttonGame1.BackColor = Color.Ivory;
            buttonGame1.BackgroundImage = (Image)resources.GetObject("buttonGame1.BackgroundImage");
            buttonGame1.BackgroundImageLayout = ImageLayout.Zoom;
            buttonGame1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGame1.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGame1.Location = new Point(612, 227);
            buttonGame1.Name = "buttonGame1";
            buttonGame1.Size = new Size(200, 200);
            buttonGame1.TabIndex = 1;
            buttonGame1.UseVisualStyleBackColor = false;
            buttonGame1.Click += buttonGame1_Click;
            // 
            // buttonGame2
            // 
            buttonGame2.BackColor = Color.CadetBlue;
            buttonGame2.BackgroundImage = (Image)resources.GetObject("buttonGame2.BackgroundImage");
            buttonGame2.BackgroundImageLayout = ImageLayout.Stretch;
            buttonGame2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGame2.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGame2.Location = new Point(330, 227);
            buttonGame2.Name = "buttonGame2";
            buttonGame2.Size = new Size(200, 200);
            buttonGame2.TabIndex = 2;
            buttonGame2.UseVisualStyleBackColor = false;
            buttonGame2.Click += buttonGame2_Click;
            // 
            // buttonGame3
            // 
            buttonGame3.BackColor = SystemColors.MenuHighlight;
            buttonGame3.BackgroundImage = (Image)resources.GetObject("buttonGame3.BackgroundImage");
            buttonGame3.BackgroundImageLayout = ImageLayout.Stretch;
            buttonGame3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGame3.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGame3.Location = new Point(64, 227);
            buttonGame3.Name = "buttonGame3";
            buttonGame3.Size = new Size(200, 200);
            buttonGame3.TabIndex = 3;
            buttonGame3.UseVisualStyleBackColor = false;
            buttonGame3.Click += buttonGame3_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Orange;
            exitBtn.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.ImageAlign = ContentAlignment.MiddleLeft;
            exitBtn.Location = new Point(672, 599);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(200, 50);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = SystemColors.Control;
            lblDescription.Location = new Point(12, 115);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(867, 38);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Welcome to Child Environment! Enjoy fun and educational games!";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // memoryLbl
            // 
            memoryLbl.AutoSize = true;
            memoryLbl.BackColor = Color.Transparent;
            memoryLbl.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            memoryLbl.ForeColor = Color.Snow;
            memoryLbl.Location = new Point(649, 464);
            memoryLbl.Name = "memoryLbl";
            memoryLbl.Size = new Size(143, 27);
            memoryLbl.TabIndex = 6;
            memoryLbl.Text = "Memory Game";
            memoryLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // raceLbl
            // 
            raceLbl.AutoSize = true;
            raceLbl.BackColor = Color.Transparent;
            raceLbl.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            raceLbl.ForeColor = Color.Snow;
            raceLbl.Location = new Point(373, 464);
            raceLbl.Name = "raceLbl";
            raceLbl.Size = new Size(112, 27);
            raceLbl.TabIndex = 7;
            raceLbl.Text = "Math Race";
            raceLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PictureLbl
            // 
            PictureLbl.AutoSize = true;
            PictureLbl.BackColor = Color.Transparent;
            PictureLbl.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PictureLbl.ForeColor = Color.Snow;
            PictureLbl.Location = new Point(101, 464);
            PictureLbl.Name = "PictureLbl";
            PictureLbl.Size = new Size(157, 27);
            PictureLbl.TabIndex = 8;
            PictureLbl.Text = "Picture Labeling";
            PictureLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 661);
            Controls.Add(PictureLbl);
            Controls.Add(raceLbl);
            Controls.Add(memoryLbl);
            Controls.Add(buttonHome);
            Controls.Add(buttonGame1);
            Controls.Add(buttonGame2);
            Controls.Add(buttonGame3);
            Controls.Add(exitBtn);
            Controls.Add(lblDescription);
            MaximumSize = new Size(900, 700);
            MinimumSize = new Size(900, 700);
            Name = "Main";
            Text = "Child Environment";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label memoryLbl;
        private Label raceLbl;
        private Label PictureLbl;
    }
}