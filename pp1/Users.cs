﻿using System;
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
    public partial class Users : Form
    {
        static string conStr = " Data Source = DESKTOP-5AOP0OT\\SQLEXPRESS;Initial Catalog = pp1; Integrated Security = True";
        DataContext context = new DataContext(conStr);
        public Users()
        {
            InitializeComponent();
            Table<users> Users = context.GetTable<users>();
            dataGridView1.DataSource = Users.ToList();
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_users f1 = new Add_users();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
//            users currentAccount = context.GetTable<users>().FirstOrDefault(
//x => x.id_пользователя == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
//            context.GetTable<users>().DeleteOnSubmit(currentAccount);
//            context.SubmitChanges();

//            dataGridView1.DataSource = context.GetTable<dogovor>().ToList();
        }
    }
}
