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
    public partial class Add_users : Form
    {
        static string conStr = " Data Source = DESKTOP-5AOP0OT\\SQLEXPRESS;Initial Catalog = pp1; Integrated Security = True";
        DataContext context = new DataContext(conStr);
        public Add_users()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            users NewUser = new users { Фамилия = textBox5.Text, Имя = textBox6.Text, Отчество = textBox7.Text, Серия_и_номер_паспорта = textBox8.Text, Адрес = textBox9.Text, Контактный_телефон = textBox10.Text };
            context.GetTable<users>().InsertOnSubmit(NewUser);
            context.SubmitChanges();
        }
    }
}
