namespace pastelaria_do_tio_zé
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            login_label.Text = Properties.Resources.ResourceManager.GetString("txtUser");
            pass_label.Text = Properties.Resources.ResourceManager.GetString("txtPass");
            btn_login.Text = Properties.Resources.ResourceManager.GetString("txtLogin");

            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.BackColor = ColorTranslator.FromHtml("#FBCB01");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
