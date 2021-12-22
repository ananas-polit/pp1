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
    public partial class Tarif : Form
    {
        static string conStr = " Data Source = DESKTOP-5AOP0OT\\SQLEXPRESS;Initial Catalog = pp1; Integrated Security = True";
        DataContext context = new DataContext(conStr);
        public Tarif()
        {
            InitializeComponent();
            Table<tarif> Tarif = context.GetTable<tarif>();
            dataGridView1.DataSource = Tarif.ToList();
        }

        private void Tarif_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select *From [Tarif] Where [Название_тарифа] Like N'%" + textBox1.Text + "%' ";
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<tarif> tarifs = null;
            switch (comboBox1.SelectedIndex)
            {
                case 0: tarifs = context.GetTable<tarif>().Where(x => x.Стоимость <= 500 && x.Стоимость > 300).ToList(); break;
                case 1: tarifs = context.GetTable<tarif>().Where(x => x.Стоимость <= 700 && x.Стоимость > 500).ToList(); break;
                case 2: tarifs = context.GetTable<tarif>().Where(x => x.Стоимость <= 2500 && x.Стоимость > 1000).ToList(); break;
                //case 3: tarifs = context.GetTable<tarif>().Where(x => x.Стоимость <= 0.7 && x.Стоимость > 0.3).ToList(); break;
                //case 4: tarifs = context.GetTable<tarif>().Where(x => x.Стоимость <= 1 && x.Стоимость > 0.7).ToList(); break;
                //case 5: tarifs = context.GetTable<tarif>().Where(x => x.Стоимость <= 1 && x.Стоимость > 0).ToList(); break;

            }

            dataGridView1.DataSource = tarifs;
        }
    }
}
