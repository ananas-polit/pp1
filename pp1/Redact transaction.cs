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
    public partial class Redact_transaction : Form
    {
        static string conStr = " Data Source = DESKTOP-5AOP0OT\\SQLEXPRESS;Initial Catalog = pp1; Integrated Security = True";
        DataContext context = new DataContext(conStr);
        Transactions Transactions;
        public Redact_transaction(Transactions transactions)
        {
            InitializeComponent();
            Transactions = transactions;
            //Table<service> service = context.GetTable<service>();
            transactoins currentAccount = context.GetTable<transactoins>().First(x => x.id_денежной_операции == Convert.ToInt32(Transactions.dataGridView1.CurrentRow.Cells[0].Value));
            comboBox1.SelectedValue = Convert.ToString(currentAccount.id_договора);
            comboBox2.SelectedValue = Convert.ToString(currentAccount.Вид_операции);
            textBox1.Text = Convert.ToString(currentAccount.Сумма_операции); 
            dateTimePicker1.Value = Convert.ToDateTime(currentAccount.Дата_транзакции);
            comboBox3.SelectedValue = Convert.ToString(currentAccount.id_работника);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            transactoins currentAccount = context.GetTable<transactoins>().First(x => x.id_денежной_операции == Convert.ToInt32(Transactions.dataGridView1.CurrentRow.Cells[0].Value));
            currentAccount.id_договора = Convert.ToInt32(comboBox1.SelectedValue);
            currentAccount.Вид_операции = Convert.ToInt32(comboBox2.SelectedValue);
            currentAccount.Сумма_операции = Convert.ToInt32(textBox1.Text);
            currentAccount.Дата_транзакции = Convert.ToDateTime(dateTimePicker1.Value);
            currentAccount.id_работника = Convert.ToInt32(comboBox3.SelectedValue);
            context.SubmitChanges();
        }

        private void Redact_transaction_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pp1DataSet1.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.pp1DataSet1.Sotrudniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pp1DataSet1.Vid_transactions". При необходимости она может быть перемещена или удалена.
            this.vid_transactionsTableAdapter.Fill(this.pp1DataSet1.Vid_transactions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pp1DataSet1.Dogovor". При необходимости она может быть перемещена или удалена.
            this.dogovorTableAdapter.Fill(this.pp1DataSet1.Dogovor);

        }
    }
}
