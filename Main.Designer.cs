namespace Child_env
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonGame1;
        private System.Windows.Forms.Button buttonGame2;
        private System.Windows.Forms.Button buttonGame3;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label memoryLbl;
        private System.Windows.Forms.Label raceLbl;
        private System.Windows.Forms.Label PictureLbl;

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
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGame1 = new System.Windows.Forms.Button();
            this.buttonGame2 = new System.Windows.Forms.Button();
            this.buttonGame3 = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.memoryLbl = new System.Windows.Forms.Label();
            this.raceLbl = new System.Windows.Forms.Label();
            this.PictureLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Ivory;
            this.buttonHome.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(10, 10);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(150, 50);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonGame1
            // 
            this.buttonGame1.BackColor = System.Drawing.Color.Ivory;
            this.buttonGame1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGame1.BackgroundImage")));
            this.buttonGame1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGame1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.buttonGame1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGame1.Location = new System.Drawing.Point(612, 227);
            this.buttonGame1.Name = "buttonGame1";
            this.buttonGame1.Size = new System.Drawing.Size(200, 200);
            this.buttonGame1.TabIndex = 1;
            this.buttonGame1.UseVisualStyleBackColor = false;
            this.buttonGame1.Click += new System.EventHandler(this.buttonGame1_Click);
            // 
            // buttonGame2
            // 
            this.buttonGame2.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonGame2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGame2.BackgroundImage")));
            this.buttonGame2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGame2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.buttonGame2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGame2.Location = new System.Drawing.Point(330, 227);
            this.buttonGame2.Name = "buttonGame2";
            this.buttonGame2.Size = new System.Drawing.Size(200, 200);
            this.buttonGame2.TabIndex = 2;
            this.buttonGame2.UseVisualStyleBackColor = false;
            this.buttonGame2.Click += new System.EventHandler(this.buttonGame2_Click);
            // 
            // buttonGame3
            // 
            this.buttonGame3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonGame3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGame3.BackgroundImage")));
            this.buttonGame3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGame3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.buttonGame3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGame3.Location = new System.Drawing.Point(64, 227);
            this.buttonGame3.Name = "buttonGame3";
            this.buttonGame3.Size = new System.Drawing.Size(200, 200);
            this.buttonGame3.TabIndex = 3;
            this.buttonGame3.UseVisualStyleBackColor = false;
            this.buttonGame3.Click += new System.EventHandler(this.buttonGame3_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Orange;
            this.exitBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.Location = new System.Drawing.Point(672, 599);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(200, 50);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDescription.Location = new System.Drawing.Point(12, 115);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(867, 38);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Welcome to Child Environment! Enjoy fun and educational games!";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memoryLbl
            // 
            this.memoryLbl.AutoSize = true;
            this.memoryLbl.BackColor = System.Drawing.Color.Transparent;
            this.memoryLbl.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.memoryLbl.ForeColor = System.Drawing.Color.Snow;
            this.memoryLbl.Location = new System.Drawing.Point(649, 464);
            this.memoryLbl.Name = "memoryLbl";
            this.memoryLbl.Size = new System.Drawing.Size(143, 27);
            this.memoryLbl.TabIndex = 6;
            this.memoryLbl.Text = "Memory Game";
            this.memoryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // raceLbl
            // 
            this.raceLbl.AutoSize = true;
            this.raceLbl.BackColor = System.Drawing.Color.Transparent;
            this.raceLbl.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.raceLbl.ForeColor = System.Drawing.Color.Snow;
            this.raceLbl.Location = new System.Drawing.Point(373, 464);
            this.raceLbl.Name = "raceLbl";
            this.raceLbl.Size = new System.Drawing.Size(112, 27);
            this.raceLbl.TabIndex = 7;
            this.raceLbl.Text = "Math Race";
            this.raceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureLbl
            // 
            this.PictureLbl.AutoSize = true;
            this.PictureLbl.BackColor = System.Drawing.Color.Transparent;
            this.PictureLbl.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.PictureLbl.ForeColor = System.Drawing.Color.Snow;
            this.PictureLbl.Location = new System.Drawing.Point(101, 464);
            this.PictureLbl.Name = "PictureLbl";
            this.PictureLbl.Size = new System.Drawing.Size(157, 27);
            this.PictureLbl.TabIndex = 8;
            this.PictureLbl.Text = "Picture Labeling";
            this.PictureLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.PictureLbl);
            this.Controls.Add(this.raceLbl);
            this.Controls.Add(this.memoryLbl);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonGame1);
            this.Controls.Add(this.buttonGame2);
            this.Controls.Add(this.buttonGame3);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.lblDescription);
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "Main";
            this.Text = "Child Environment";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
