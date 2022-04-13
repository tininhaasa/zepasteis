namespace pastelaria_do_tio_zé
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();

            about_label.Text = Properties.Resources.ResourceManager.GetString("descAbout");
        }

        private void label1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void about_Load(object sender, EventArgs e)
        {

        }

        private void about_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
