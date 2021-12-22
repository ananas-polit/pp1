using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pp1
{
    public partial class Vhod : Form
    {
        public Vhod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = "a";
            string password = "ad";
            if (textBox1.Text == login && textBox2.Text == password)
            {
               Dogovor f3 = new Dogovor(false);
                f3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = "aa";
            string password = "aad";
            if (textBox1.Text == login && textBox2.Text == password)
            {
                Transactions f3 = new Transactions(true);
                f3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Tarif f3 = new Tarif();
            f3.ShowDialog();
        }

        private void Vhod_Load(object sender, EventArgs e)
        {

        }
        public bool Auth(string login, string password)
        {
            throw new NotImplementedException();
        }
            
    }
}
