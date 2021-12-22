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
    public partial class Add_coating : Form
    {
        static string conStr = " Data Source = DESKTOP-5AOP0OT\\SQLEXPRESS;Initial Catalog = pp1; Integrated Security = True";
        DataContext context = new DataContext(conStr);
        public Add_coating()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coating NewUser = new coating { Улица = textBox11.Text };
            context.GetTable<coating>().InsertOnSubmit(NewUser);
            context.SubmitChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
