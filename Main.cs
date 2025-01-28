namespace Child_env
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ShowHomePage();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            ShowHomePage();
        }

        private void buttonGame1_Click(object sender, EventArgs e)
        {
            LoadForm(new Game1Form());
        }

        private void buttonGame2_Click(object sender, EventArgs e)
        {
            LoadForm(new Game2Form());
        }

        private void buttonGame3_Click(object sender, EventArgs e)
        {
            LoadForm(new Game3Form());
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadForm(Form form)
        {
            buttonGame1.Visible = false;
            buttonGame2.Visible = false;
            buttonGame3.Visible = false;
            buttonHome.Visible = true;
            exitBtn.Visible = false;

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.Controls.Add(form);
            form.BringToFront();
            form.Show();

            form.FormClosed += (s, args) => ShowHomePage();
        }

        private void ShowHomePage()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Form)
                {
                    this.Controls.Remove(control);
                    control.Dispose();
                }
            }

            buttonGame1.Visible = true;
            buttonGame2.Visible = true;
            buttonGame3.Visible = true;
            buttonHome.Visible = false;
            exitBtn.Visible = true;
        }

    }
}