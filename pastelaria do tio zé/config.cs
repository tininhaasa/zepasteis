namespace pastelaria_do_tio_zé
{
    public partial class config : Form
    {
        public config()
        {
            InitializeComponent();

            // aqui ele pega e instancia o objeto do user controle (y)
            UserControl1 operacoes = new();

            setLanguageText();

            operacoes.Dock = DockStyle.Bottom;
            panelControl.Controls.Add(operacoes);
            //pega o tamanho atual da tela e acrescenta à altura de operações
            Size = new Size(Size.Width, Size.Height + operacoes.Size.Height);
            operacoes.save.Click += save_Click;
            operacoes.cancel.Click += save_Click;

            this.Text = Properties.Resources.ResourceManager.GetString("txtConfig");
            percent_label.Text = Properties.Resources.ResourceManager.GetString("txtPercent");
            forfeit_label.Text = Properties.Resources.ResourceManager.GetString("txtForfeit");



        }

        private void setLanguageText()
        {
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
