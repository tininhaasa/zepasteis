namespace pastelaria_do_tio_zé
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            save.FlatStyle = FlatStyle.Flat;
            save.FlatAppearance.BorderSize = 0;
            save.BackColor = ColorTranslator.FromHtml("#37B52C");
            save.Text = "Salvar";

            cancel.FlatStyle = FlatStyle.Flat;
            cancel.FlatAppearance.BorderSize = 0;
            cancel.BackColor = ColorTranslator.FromHtml("#ff0000");
            cancel.Text = "Cancelar";

            save.Text = Properties.Resources.ResourceManager.GetString("txtSave");
            cancel.Text = Properties.Resources.ResourceManager.GetString("txtCancel");
        }
    }
}
