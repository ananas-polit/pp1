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
    public partial class Add : Form
    {
        static string conStr = " Data Source = DESKTOP-5AOP0OT\\SQLEXPRESS;Initial Catalog = pp1; Integrated Security = True";
        DataContext context = new DataContext(conStr);
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dogovor NewUser = new dogovor { id_пользователя = Convert.ToInt32(comboBox1.SelectedValue), Баланс = Convert.ToInt32(textBox1.Text), Логин = textBox2.Text, Пароль = textBox3.Text, Номер_лицевого_счета = textBox4.Text, id_дома = Convert.ToInt32(comboBox2.SelectedValue), Дата_подключения = Convert.ToDateTime(dateTimePicker1.Value), id_сотрудника = Convert.ToInt32(comboBox3.SelectedValue) };
            context.GetTable<dogovor>().InsertOnSubmit(NewUser);
            context.SubmitChanges();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pp1DataSet1.Coating". При необходимости она может быть перемещена или удалена.
            this.coatingTableAdapter1.Fill(this.pp1DataSet1.Coating);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pp1DataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.pp1DataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pp1DataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.pp1DataSet.Sotrudniki);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //coating NewUser = new coating { Улица = textBox11.Text };
            //context.GetTable<coating>().InsertOnSubmit(NewUser);
            //context.SubmitChanges();
        }
    }
}
