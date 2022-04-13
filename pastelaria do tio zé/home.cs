using System.Configuration;
namespace pastelaria_do_tio_zé
{
    /// <summary>
    /// Classe principal da pastelaria do seu zé
    /// </summary>
    public partial class ZePasteis : Form
    {
        /// <summary>
        /// Método/função principal
        /// </summary>
        public ZePasteis()
        {

            InitializeComponent();

            //Aqui ele pega a linguagem salva pelo usuário
            string? languageSys = (ConfigurationManager.AppSettings.Get("Language") is not null) ? ConfigurationManager.AppSettings.Get("Language") : "";

            Thread.CurrentThread.CurrentUICulture   = new System.Globalization.CultureInfo(languageSys!);
            Thread.CurrentThread.CurrentCulture     = new System.Globalization.CultureInfo(languageSys!);
            
            //Onde ele pega os textos que aparecem nas telas e troca para o idioma atual
            functionary.Text    = Properties.Resources.ResourceManager.GetString("txtEmployeer");
            product.Text        = Properties.Resources.ResourceManager.GetString("txtProduct");
            clients.Text        = Properties.Resources.ResourceManager.GetString("txtClient");
            config.Text         = Properties.Resources.ResourceManager.GetString("txtConfig");
            about.Text          = Properties.Resources.ResourceManager.GetString("txtAbout");
            login.Text          = Properties.Resources.ResourceManager.GetString("txtLogin");

        }
        /// <summary>
        /// Quando iniciar o código ele formata os botões que estão com padrão do visual studio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void language_pt_Click(object sender, EventArgs e)
        {
            changeLang("pt-BR");

        }

        private void language_sp_Click(object sender, EventArgs e)
        {
            changeLang("es");
        }

        private void language_en_Click(object sender, EventArgs e)
        {
            changeLang("en-US");
        }
        /// <summary>
        /// Aqui ele troca toda a linguagem do sistemas, com o click dos eventos language_pt_Click,language_sp_Click e language_en_Click
        /// </summary>
        /// <param name="lang">Passado pelo click dos botões com as bandeiras dos países</param>
        public void changeLang(string lang)
        {
            //abre o arquivo local como leitura/escrita e salva as alterações em ProjetoPastelariaDoZe_2022.dll.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("Language");
            config.AppSettings.Settings.Add("Language", lang);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            DialogResult result = MessageBox.Show(Properties.Resources.ResourceManager.GetString("txtChangeLangMessage"), Properties.Resources.ResourceManager.GetString("txtChangeLangTitle"), MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
            else
            {
                // Do something  
            }
        }
    }
}