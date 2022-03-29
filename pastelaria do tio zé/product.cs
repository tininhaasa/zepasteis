using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void product_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
