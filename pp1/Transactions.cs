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
    public partial class Transactions : Form
    { 
        static string conStr = " Data Source = DESKTOP-5AOP0OT\\SQLEXPRESS;Initial Catalog = pp1; Integrated Security = True";
            DataContext context = new DataContext(conStr);
        public Transactions transactions;
        public Transactions(bool isAdmin)
        {
            InitializeComponent();
            if (isAdmin == true)
            {
                button1.Visible = true;
                button2.Visible = true;

            }
            else
            {
                button1.Visible = false;
                button2.Visible = false;
            }
            Table<transactoins> Transactoins = context.GetTable<transactoins>();
            dataGridView1.DataSource = Transactoins.ToList();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_sotrudniki f1 = new Add_sotrudniki();
                f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Redact_transaction f1 = new Redact_transaction(this);
            f1.ShowDialog();
        }
    }
}
