namespace pastelaria_do_tio_zé
{
    public partial class clients : Form
    {
        public bool Visible { get; set; }
        public clients()
        {
            InitializeComponent();

            name_label.Text = Properties.Resources.ResourceManager.GetString("txtName");
            cpf_label.Text = Properties.Resources.ResourceManager.GetString("txtDocument");
            phone_label.Text = Properties.Resources.ResourceManager.GetString("txtPhone");
            register_label.Text = Properties.Resources.ResourceManager.GetString("txtRegister");
            pass_label.Text = Properties.Resources.ResourceManager.GetString("txtPass");
            fine_label.Text = Properties.Resources.ResourceManager.GetString("txtFine");
            days_label.Text = Properties.Resources.ResourceManager.GetString("txtDays");

            // aqui ele pega e instancia o objeto do user controle (y)
            UserControl1 operacoes = new();
            operacoes.Dock = DockStyle.Bottom;
            panelControl.Controls.Add(operacoes);

            vScrollBar1.Value = panelForm.VerticalScroll.Value;
            vScrollBar1.Minimum = panelForm.VerticalScroll.Minimum;
            vScrollBar1.Maximum = panelForm.VerticalScroll.Maximum;
            operacoes.save.Click += save_Click;
            operacoes.cancel.Click += save_Click;
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void group_SelectedValueChanged(object sender, EventArgs e)
        {
            if (group.SelectedItem != null)
            {
                string option = (string)group.SelectedItem;
                if (option == "Sim")
                {
                    days_label.Visible = true;
                    days.Visible = true;
                }
                else
                {
                    days_label.Visible = false;
                    days.Visible = false;

                }

            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panelForm.VerticalScroll.Value = vScrollBar1.Value;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
