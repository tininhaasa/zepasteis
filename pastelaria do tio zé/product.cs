namespace pastelaria_do_tio_zé
{
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();

            // aqui ele pega e instancia o objeto do user controle (y)
            UserControl1 operacoes = new();
            operacoes.Dock = DockStyle.Bottom;

            panelControl.Controls.Add(operacoes);
            //pega o tamanho atual da tela e acrescenta à altura de operações
            Size = new Size(Size.Width, Size.Height + operacoes.Size.Height);

            name_label.Text = Properties.Resources.ResourceManager.GetString("txtName");
            price_label.Text = Properties.Resources.ResourceManager.GetString("txtPrice");
            description_label1.Text = Properties.Resources.ResourceManager.GetString("txtDesc");

            operacoes.save.Click += save_Click;
            operacoes.cancel.Click += save_Click;
        }

        private void product_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                product_image.Image = new Bitmap(open.FileName);
                // image file path  
            }
        }

        private void save_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
