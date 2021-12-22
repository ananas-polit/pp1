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
    public partial class Coating : Form
    {
        static string conStr = " Data Source = DESKTOP-5AOP0OT\\SQLEXPRESS;Initial Catalog = pp1; Integrated Security = True";
        DataContext context = new DataContext(conStr);
        public Coating()
        {
            InitializeComponent();
            Table<coating> Coating = context.GetTable<coating>();
            dataGridView1.DataSource = Coating.ToList();
        }

        private void Coating_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_coating f1 = new Add_coating();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coating currentAccount = context.GetTable<coating>().FirstOrDefault(
x => x.id_дома == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            context.GetTable<coating>().DeleteOnSubmit(currentAccount);
            context.SubmitChanges();

            dataGridView1.DataSource = context.GetTable<dogovor>().ToList();
        }
    }
}
