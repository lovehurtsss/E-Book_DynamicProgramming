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
    public partial class main_menu : Form
    {
        static head main = new head();
        public main_menu()
        {
            InitializeComponent();
           
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = Application.StartupPath;
            string st1 = treeView1.SelectedNode.Text;
            int sqq = treeView1.SelectedNode.Index;
            if (st1 == "Умовні позначення")
            {
                webBrowser1.Navigate(path + "\\texts\\umovni.htm");
            }
            if (st1 == "Вступ")
            {
                webBrowser1.Navigate(path + "\\texts\\vstup.htm");
            }
            if (st1 == "Загальні відомості")
            {
                webBrowser1.Navigate(path + "\\texts\\zagalni.htm");
            }
            if (st1 == "Задача \"Доміно\"")
            {
                webBrowser1.Navigate(path + "\\texts\\umova.htm");
            }
            if (st1 == "Рішення задачі")
            {
                webBrowser1.Navigate(path + "\\texts\\ans.htm");
            }
            if (st1 == "Код")
            {
                webBrowser1.Navigate(path + "\\texts\\kod.htm");
            }
            if (st1 == "Проект")
            {
                webBrowser1.Navigate(path + "\\texts\\umovni.htm");
            }
            if (st1 == "Складність алгоритму")
            {
                webBrowser1.Navigate(path + "\\texts\\sloshno.htm");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            webBrowser1.Navigate(path + "\\texts\\vstup.htm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void main_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                main.StartPosition = FormStartPosition.CenterScreen;
                main.Show();
                Hide();
            }
        }
    }
}
