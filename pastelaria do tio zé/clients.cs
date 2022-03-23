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
    public partial class clients : Form
    {
        public bool Visible { get; set; }
        public clients()
        {
            InitializeComponent();
            save_btn.FlatStyle = FlatStyle.Flat;
            save_btn.FlatAppearance.BorderSize = 0;
            save_btn.BackColor = ColorTranslator.FromHtml("#37B52C");

            vScrollBar1.Value = panelForm.VerticalScroll.Value;
            vScrollBar1.Minimum = panelForm.VerticalScroll.Minimum;
            vScrollBar1.Maximum = panelForm.VerticalScroll.Maximum;
        }

        private void clients_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void group_SelectedValueChanged(object sender, EventArgs e)
        {
            if (group.SelectedItem != null)
            {
                string option = (string)group.SelectedItem;
                if(option == "Sim")
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
