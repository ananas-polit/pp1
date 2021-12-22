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
    public partial class Redact_dogovor : Form
    {
        static string conStr = " Data Source = DESKTOP-5AOP0OT\\SQLEXPRESS;Initial Catalog = pp1; Integrated Security = True";
        DataContext context = new DataContext(conStr);
        Dogovor Dogovor;
        public Redact_dogovor(Dogovor dogovor)
        {
            InitializeComponent();
            Dogovor = dogovor;
            //Table<service> service = context.GetTable<service>();
            dogovor currentAccount = context.GetTable<dogovor>().First(x => x.id_договора == Convert.ToInt32(Dogovor.dataGridView1.CurrentRow.Cells[0].Value));
            comboBox1.SelectedValue = Convert.ToString(currentAccount.id_пользователя);
            textBox1.Text = Convert.ToString(currentAccount.Баланс);
            textBox2.Text = currentAccount.Логин;
            textBox3.Text = currentAccount.Пароль;
            textBox4.Text = currentAccount.Номер_лицевого_счета;
            comboBox2.SelectedValue = Convert.ToString(currentAccount.id_дома);
            dateTimePicker1.Value = Convert.ToDateTime(currentAccount.Дата_подключения);
            comboBox3.SelectedValue = Convert.ToString(currentAccount.id_сотрудника);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dogovor currentAccount = context.GetTable<dogovor>().FirstOrDefault(
x => x.id_договора == Convert.ToInt32(Dogovor.dataGridView1.CurrentRow.Cells[0].Value));
            currentAccount.id_пользователя = Convert.ToInt32(comboBox1.SelectedValue);
            currentAccount.Баланс = Convert.ToInt32(textBox1.Text);
            currentAccount.Логин = textBox2.Text;
            currentAccount.Пароль = textBox3.Text;
            currentAccount.Номер_лицевого_счета = textBox4.Text;
            currentAccount.id_дома = Convert.ToInt32(comboBox2.SelectedValue);
            currentAccount.Дата_подключения = Convert.ToDateTime(dateTimePicker1.Value);
            currentAccount.id_сотрудника = Convert.ToInt32(comboBox3.SelectedValue);
            context.SubmitChanges();
        }

        private void Redact_dogovor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pp1DataSet1.Coating". При необходимости она может быть перемещена или удалена.
            this.coatingTableAdapter1.Fill(this.pp1DataSet1.Coating);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pp1DataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.pp1DataSet.Sotrudniki);
            //TODO: данная строка кода позволяет загрузить данные в таблицу "pp1DataSet.Coating".При необходимости она может быть перемещена или удалена.
            //this.coatingTableAdapter.Fill(this.pp1DataSet.Coating);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pp1DataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.pp1DataSet.Users);

        }
    }
}
