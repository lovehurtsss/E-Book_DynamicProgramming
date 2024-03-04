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
    public partial class head : Form
    {
        static main_menu mainm = new main_menu();
        public prak prak = new prak();
        public Form3 galer = new Form3();
        public Form4 video = new Form4();
        static head hed = new head();
        public head()
        {
            InitializeComponent();
            AddOwnedForm(mainm);
            AddOwnedForm(prak);
            AddOwnedForm(galer);
            AddOwnedForm(video);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            galer.StartPosition = FormStartPosition.CenterScreen;
            galer.Show();
            
           Hide();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            video.StartPosition = FormStartPosition.CenterScreen;
            video.Show();
            Hide();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Blue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            prak.StartPosition = FormStartPosition.CenterScreen;
            prak.Show();
            Hide();
    }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Blue;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            mainm.StartPosition = FormStartPosition.CenterScreen;
            mainm.Show();
            Hide();
            
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Blue;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void head_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            mainm.StartPosition = FormStartPosition.CenterScreen;
            mainm.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            prak.StartPosition = FormStartPosition.CenterScreen;
            prak.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            galer.StartPosition = FormStartPosition.CenterScreen;
            galer.Show();
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            video.StartPosition = FormStartPosition.CenterScreen;
            video.Show();
            Hide();
        }
    }
}
