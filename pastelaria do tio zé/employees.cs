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
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            panelForm.VerticalScroll.Value = vScrollBar1.Value;
        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
