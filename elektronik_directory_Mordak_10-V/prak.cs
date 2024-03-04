using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
namespace elektronik_directory_Mordak_10_V
{
    public partial class prak : Form
    {
        static head main_menu = new head();
        public prak()
        {
            InitializeComponent();
        }

        public int n, m;
        double time = 0.001;
        long[,] mas;
        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            listBox1.Items.Clear();
            listBox1.Items.Add("Знайти кількість способів замостити площу");
            listBox1.Items.Add("n × m за допомогою доміношек розмірами 1 × 2");
            listBox1.Items.Add("або 2 × 1.");
            listBox1.Items.Add("Вхідні дані:");
            listBox1.Items.Add("n - Довжина площини (n<10)");
            listBox1.Items.Add("m - Ширина площини (m<10)");
            listBox1.Items.Add("Вихідні дані:");
            listBox1.Items.Add("Кількість варіантів замощення");
            n = int.Parse(textBox1.Text);
            m = int.Parse(textBox3.Text);
            int temp = 0;
            if (n < 11 && m < 11 && n>-1 && m>-1)
            {
                mas = new long[n + 1, 1 << m];
                mas[0, 0] = 1;
                for (int x = 0; x < n; x++)
                {
                    for (int mask = 0; mask < (1 << m); mask++)
                    {
                        calc(x, 0, mask, 0);
                    }
                }
                label5.Text = Convert.ToString(mas[n, 0]);
                stopwatch.Stop();
                label9.Text = Convert.ToString(stopwatch.ElapsedMilliseconds*0.001+" Сек.");

            }
            else
            { 
                label5.Text = "";
                listBox1.Items.Clear();
                listBox1.Items.Add("Введені значення довжини або ширини не ");
                listBox1.Items.Add("відповідають умові задачі (n<11 m<11)");           
            }
        }

        private void prak_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {              
                e.Cancel = true;
                main_menu.StartPosition = FormStartPosition.CenterScreen;
                main_menu.Show();
                Hide();
            }
        }

        private void prak_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Знайти кількість способів замостити площу");
            listBox1.Items.Add("n × m за допомогою доміношек розмірами 1 × 2");
            listBox1.Items.Add("або 2 × 1.");
            listBox1.Items.Add("Вхідні дані:");
            listBox1.Items.Add("n - Довжина площини (n<10)");
            listBox1.Items.Add("m - Ширина площини (m<10)");
            listBox1.Items.Add("Вихідні дані:");
            listBox1.Items.Add("Кількість варіантів замощення");



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time+0.001;
        }

        public void calc(int x = 0, int y = 0, int mask = 0, int next_mask = 0)
        {
            if (x == n)
            {
                return;
            }
            if (y >= m)
            {
                mas[x + 1, next_mask] += mas[x, mask];
            }
            else
            {
                int my_mask = 1 << y;
                if ((mask & my_mask) != 0)
                {
                    calc(x, y + 1, mask, next_mask);
                }
                else
                {
                    calc(x, y + 1, mask, next_mask | my_mask);
                    if (y + 1 < m && (mask & my_mask) == 0 && (mask & (my_mask << 1)) == 0)
                    {
                        calc(x, y + 2, mask, next_mask);
                    }
                }
            }
        }
    }
}

