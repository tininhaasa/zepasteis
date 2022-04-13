namespace pastelaria_do_tio_zé
{
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();

            name_label.Text = Properties.Resources.ResourceManager.GetString("txtName");
            cpf_label.Text = Properties.Resources.ResourceManager.GetString("txtDocument");
            phone_label.Text = Properties.Resources.ResourceManager.GetString("txtPhone");
            register_label.Text = Properties.Resources.ResourceManager.GetString("txtRegister");
            pass_label.Text = Properties.Resources.ResourceManager.GetString("txtPass");
            group_label.Text = Properties.Resources.ResourceManager.GetString("txtGroup");

            vScrollBar1.Value = panelForm.VerticalScroll.Value;
            vScrollBar1.Minimum = panelForm.VerticalScroll.Minimum;
            vScrollBar1.Maximum = panelForm.VerticalScroll.Maximum;

            // aqui ele pega e instancia o objeto do user controle (y)
            UserControl1 operacoes = new();
            operacoes.Dock = DockStyle.Bottom;
            panelControl.Controls.Add(operacoes);
            //pega o tamanho atual da tela e acrescenta à altura de operações
            Size = new Size(Size.Width, Size.Height + operacoes.Size.Height);
            operacoes.save.Click += save_Click;
            operacoes.cancel.Click += save_Click;
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            panelForm.VerticalScroll.Value = vScrollBar1.Value;
        }

    }
}
