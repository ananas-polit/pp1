using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;

namespace pp1
{
    public partial class Sotrudniki : Form
    {
        static string conStr = " Data Source = DESKTOP-5AOP0OT\\SQLEXPRESS;Initial Catalog = pp1; Integrated Security = True";
        DataContext context = new DataContext(conStr);
        public Sotrudniki()
        {
            InitializeComponent();
            Table<sotrudniki> Sotrudniki = context.GetTable<sotrudniki>();
            dataGridView1.DataSource = Sotrudniki.ToList();
        }

        private void Sotrudniki_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add_sotrudniki f1 = new Add_sotrudniki();
            //f1.ShowDialog();
        }
    }
}
