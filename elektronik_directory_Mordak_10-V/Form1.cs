using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elektronik_directory_Mordak_10_V
{
    public partial class title : Form
    {
        public head main = new head();
        public title()
        {
            InitializeComponent();
            AddOwnedForm(main);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Yellow;
            label2.ForeColor = Color.Yellow;
            label6.ForeColor = Color.Yellow;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label6.ForeColor = Color.White;
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            main.StartPosition = FormStartPosition.CenterScreen;
            main.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            main.StartPosition = FormStartPosition.CenterScreen;
            main.Show();
            Hide();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Yellow;
            label2.ForeColor = Color.Yellow;
            label6.ForeColor = Color.Yellow;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label6.ForeColor = Color.White;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            main.StartPosition = FormStartPosition.CenterScreen;
            main.Show();
            Hide();
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Yellow;
            label2.ForeColor = Color.Yellow;
            label6.ForeColor = Color.Yellow;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label6.ForeColor = Color.White;
        }
    }
}
