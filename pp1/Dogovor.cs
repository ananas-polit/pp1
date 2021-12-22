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
    public partial class Dogovor : Form
    {
        static string conStr = " Data Source = DESKTOP-5AOP0OT\\SQLEXPRESS;Initial Catalog = pp1; Integrated Security = True";
        DataContext context = new DataContext(conStr);
        public Dogovor dogovor;
        public Dogovor(bool isAdmin)
        {
            InitializeComponent();
            Table<dogovor> Dogovor = context.GetTable<dogovor>();
            dataGridView1.DataSource = Dogovor.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sotrudniki f1 = new Sotrudniki();
            f1.ShowDialog();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users f1 = new Users();
            f1.ShowDialog();
        }

        private void денежныеОперацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transactions f1 = new Transactions(false);
            f1.ShowDialog();
        }

        private void покрытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Coating f1 = new Coating();
            f1.ShowDialog();
        }

        private void тарифToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tarif f1 = new Tarif();
            f1.ShowDialog();
        }

        private void сервисToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Service f1 = new Service();
            //f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Add f1 = new Add();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Redact_dogovor f1 = new Redact_dogovor(this);
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
//            dogovor currentAccount = context.GetTable<dogovor>().FirstOrDefault(
//x => x.id_договора == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
//            context.GetTable<dogovor>().DeleteOnSubmit(currentAccount);
//            context.SubmitChanges();

//            dataGridView1.DataSource = context.GetTable<dogovor>().ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select *From [Dogovor] Where [Номер_лицевого_счета] Like N'%" + textBox1.Text + "%' ";
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
