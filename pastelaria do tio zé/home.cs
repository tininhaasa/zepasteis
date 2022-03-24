namespace pastelaria_do_tio_zé
{
    public partial class ZePasteis : Form
    {
        public ZePasteis()
        {
            InitializeComponent();
        }

        private void ZePasteis_Load(object sender, EventArgs e)
        {
            menu_nav.BackColor = ColorTranslator.FromHtml("#DEECF1");
            menu_aside.BackColor = ColorTranslator.FromHtml("#DEECF1");
            login.BackColor = ColorTranslator.FromHtml("#FBCB01");
            login.FlatStyle = FlatStyle.Flat;
            login.FlatAppearance.BorderSize = 0;

            functionary.FlatStyle = FlatStyle.Flat;
            functionary.FlatAppearance.BorderSize = 0;
            functionary.BackColor = ColorTranslator.FromHtml("#DEECF1");

            clients.FlatStyle = FlatStyle.Flat;
            clients.FlatAppearance.BorderSize = 0;
            clients.BackColor = ColorTranslator.FromHtml("#DEECF1");

            product.FlatStyle = FlatStyle.Flat;
            product.FlatAppearance.BorderSize = 0;
            product.BackColor = ColorTranslator.FromHtml("#DEECF1");

            about.FlatStyle = FlatStyle.Flat;
            about.FlatAppearance.BorderSize = 0;
            about.BackColor = ColorTranslator.FromHtml("#DEECF1");

            config.FlatStyle = FlatStyle.Flat;
            config.FlatAppearance.BorderSize = 0;
            config.BackColor = ColorTranslator.FromHtml("#DEECF1");

            clients.FlatStyle = FlatStyle.Flat;
            clients.FlatAppearance.BorderSize = 0;
            clients.BackColor = ColorTranslator.FromHtml("#DEECF1");

            language_pt.FlatStyle = FlatStyle.Flat;
            language_pt.FlatAppearance.BorderSize = 0;
            language_pt.BackColor = ColorTranslator.FromHtml("#DEECF1");

            language_sp.FlatStyle = FlatStyle.Flat;
            language_sp.FlatAppearance.BorderSize = 0;
            language_sp.BackColor = ColorTranslator.FromHtml("#DEECF1");

            language_en.FlatStyle = FlatStyle.Flat;
            language_en.FlatAppearance.BorderSize = 0;
            language_en.BackColor = ColorTranslator.FromHtml("#DEECF1");

        }

        private void login_Click(object sender, EventArgs e)
        {
            login form_login = new login();
            form_login.ShowDialog();
        }

        private void functionary_Click(object sender, EventArgs e)
        {

            employees form_employees = new employees();
            form_employees.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clients_Click(object sender, EventArgs e)
        {
            clients form_clients = new clients();
            form_clients.ShowDialog();
        }

        private void product_Click(object sender, EventArgs e)
        {
            product form_product = new product();
            form_product.ShowDialog();
        }

        private void conf_Click(object sender, EventArgs e)
        {
            config form_config = new config();
            form_config.ShowDialog();
        }

        private void about_Click(object sender, EventArgs e)
        {
            about form_about = new about();
            form_about.ShowDialog();
        }

    } 
}