using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Child_env
{
    partial class Game1Form
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonHome;
        private TableLayoutPanel tableLayoutPanel;
        private Button[] cardButtons;
        private Timer timer1;
        private Label lblInstructions;

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
            buttonHome = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            timer1 = new Timer(components);
            lblInstructions = new Label();
            SuspendLayout();
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.LightGreen;
            buttonHome.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.Location = new Point(10, 10);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(150, 50);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = Color.Ivory;
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel.ForeColor = Color.Honeydew;
            tableLayoutPanel.Location = new Point(257, 187);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(4);
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel.Size = new Size(417, 412);
            tableLayoutPanel.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Interval = 750;
            timer1.Tick += timer1_Tick;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstructions.Location = new Point(189, 107);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(544, 30);
            lblInstructions.TabIndex = 2;
            lblInstructions.Text = "Click on two cards to find a matching pair. Good luck!";
            // 
            // Game1Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(884, 661);
            Controls.Add(buttonHome);
            Controls.Add(lblInstructions);
            Controls.Add(tableLayoutPanel);
            MaximumSize = new Size(1118, 775);
            MinimumSize = new Size(900, 700);
            Name = "Game1Form";
            Padding = new Padding(4);
            Text = "Memory Game";
            Load += Game1Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}