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
    public partial class Add_sotrudniki : Form
    {
        static string conStr = " Data Source = DESKTOP-5AOP0OT\\SQLEXPRESS;Initial Catalog = pp1; Integrated Security = True";
        DataContext context = new DataContext(conStr);
        public Add_sotrudniki()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            transactoins NewUser = new transactoins { id_договора = Convert.ToInt32(comboBox1.SelectedValue), Вид_операции = Convert.ToInt32(comboBox2.SelectedValue), Сумма_операции = Convert.ToInt32(textBox1.Text), Дата_транзакции = Convert.ToDateTime(dateTimePicker1.Value), id_работника = Convert.ToInt32(comboBox3.SelectedValue) };
            context.GetTable<transactoins>().InsertOnSubmit(NewUser);
            context.SubmitChanges();
        }

        private void Add_sotrudniki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pp1DataSet1.Vid_transactions". При необходимости она может быть перемещена или удалена.
            this.vid_transactionsTableAdapter.Fill(this.pp1DataSet1.Vid_transactions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pp1DataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.pp1DataSet.Sotrudniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pp1DataSet.Dogovor". При необходимости она может быть перемещена или удалена.
            this.dogovorTableAdapter.Fill(this.pp1DataSet.Dogovor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pp1DataSet.Transactions". При необходимости она может быть перемещена или удалена.
            this.transactionsTableAdapter.Fill(this.pp1DataSet.Transactions);

        }
    }
}
