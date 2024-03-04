using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elektronik_directory_Mordak_10_V
{
    public partial class Form3 : Form
    {
        string path;
        int n, Count, nMain;
        static head main_menu = new head();
        public Form3()
        {
            InitializeComponent();
          
        }
      
        private void frmPhoto_Load(object sender, EventArgs e)
        {
           
        }

        void check()
        {
            
        }

        private void PB1_Click(object sender, EventArgs e)
        {
           
        }

        private void PB2_Click(object sender, EventArgs e)
        {
            
        }

        private void PB3_Click(object sender, EventArgs e)
        {
            
        }

        

        private void PB4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void PB5_Click_1(object sender, EventArgs e)
        {
           
        }

        private void pctNext_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                main_menu.StartPosition = FormStartPosition.CenterScreen;
                main_menu.Show();
                Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pctPrev_Click(object sender, EventArgs e)
        {
           
        }
        private void Form3_Load(object sender, EventArgs e)
        {

            listBox1.Items.Add("Оскільки складність алгоритму рахується");
            listBox1.Items.Add("за формулою O=(2^n)*m, то графік не буде");
            listBox1.Items.Add("кардинально змінюватися від значення m.");
            listBox1.Items.Add("Побудуємо графік для m = 4.");
            listBox1.Items.Add("Зразу видно наскільки швидко починає");
            listBox1.Items.Add("зростати складність алгоритму залежно");
            listBox1.Items.Add("від значення n. Саме цьому з'явилося");
            listBox1.Items.Add("обмеження на числові значення n та m.");
        }
    }
}

