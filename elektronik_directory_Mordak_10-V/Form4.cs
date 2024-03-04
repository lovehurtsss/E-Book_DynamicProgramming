using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace elektronik_directory_Mordak_10_V
{
    public partial class Form4 : Form
    {
        static head main_menu = new head();
        public Form4()
        {
            InitializeComponent();
        }
        string path = Application.StartupPath;
        int nump;
        bool bOol = false;
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                main_menu.StartPosition = FormStartPosition.CenterScreen;
                main_menu.Show();
                Hide();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Справа можна побачити візуалізацію");
            listBox1.Items.Add("різних варіантів замощення площини");
            listBox1.Items.Add("розмірами 4 на 4 доміношками розмірами");
            listBox1.Items.Add("2 на 1 та 1 на 2.");
            button2.BringToFront();

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Справа можна побачити візуалізацію");
            listBox1.Items.Add("різних варіантів замощення площини");
            listBox1.Items.Add("розмірами 4 на 4 доміношками розмірами");
            listBox1.Items.Add("2 на 1 та 1 на 2.");
            timer2.Start();
            nump = 0;
            bOol = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (bOol)
            {
                timer2.Stop();
                button4.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Справа можна побачити візуалізацію");
            listBox1.Items.Add("різних варіантів замощення площини");
            listBox1.Items.Add("розмірами 4 на 4 доміношками розмірами");
            listBox1.Items.Add("2 на 1 та 1 на 2.");
            timer2.Start();
            button2.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Знайти кількість способів замостити площу");
            listBox1.Items.Add("n × m за допомогою доміношек розмірами");
            listBox1.Items.Add("1 × 2 або 2 × 1.");
            listBox1.Items.Add("Вхідні дані:");
            listBox1.Items.Add("n - Довжина площини (n<10)");
            listBox1.Items.Add("m - Ширина площини (m<10)");
            listBox1.Items.Add("Вихідні дані:");
            listBox1.Items.Add("Кількість варіантів замощення");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Площину 4 на 4 можна замостити доміно (36)");
            listBox1.Items.Add("різними варіантами. Без накладання одна на");
            listBox1.Items.Add("одну, незамощених частин площини або виходу");
            listBox1.Items.Add("за межі площини. Витрачений час: менше 0.001");
            listBox1.Items.Add("c.");
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            nump++;
            
            if (nump <= 8)
            {
               
                pictureBox1.Load(path + "\\GRAF\\" + nump.ToString() + ".png");
            }
            else
            {
               
                nump = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
