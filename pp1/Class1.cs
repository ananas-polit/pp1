using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;

namespace pp1
{
    [Table(Name = "Dogovor")]
    class dogovor
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id_договора")]
        public int id_договора { get; set; }
        [Column(Name = "id_пользователя")]
        public int id_пользователя { get; set; }
        [Column(Name = "Баланс")]
        public decimal Баланс { get; set; }
        [Column(Name = "Логин")]
        public string Логин { get; set; }
        [Column(Name = "Пароль")]
        public string Пароль { get; set; }
        [Column(Name = "Номер_лицевого_счета")]
        public string Номер_лицевого_счета { get; set; }
        [Column(Name = "id_дома")]
        public int id_дома { get; set; }
        [Column(Name = "Дата_подключения")]
        public DateTime Дата_подключения { get; set; }
        [Column(Name = "id_сотрудника")]
        public int id_сотрудника { get; set; }
    }
    [Table(Name = "Sotrudniki")]
    class sotrudniki
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id_сотрудника")]
        public int id_сотрудника { get; set; }
        [Column(Name = "Фамилия")]
        public string Фамилия { get; set; }
        [Column(Name = "Имя")]
        public string Имя { get; set; }
        [Column(Name = "Отчество")]
        public string Отчество { get; set; }
        [Column(Name = "Серия_и_номер_паспорта")]
        public string Серия_и_номер_паспорта { get; set; }
        [Column(Name = "Адрес")]
        public string Адрес { get; set; }
        [Column(Name = "Контактный_телефон")]
        public string Контактный_телефон { get; set; }
        [Column(Name = "Должность")]
        public string Должность { get; set; }
        [Column(Name = "Зарплата")]
        public decimal Зарплата { get; set; }
    }
    [Table(Name = "Users")]
    class users
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id_пользователя")]
        public int id_пользователя { get; set; }
        [Column(Name = "Фамилия")]
        public string Фамилия { get; set; }
        [Column(Name = "Имя")]
        public string Имя { get; set; }
        [Column(Name = "Отчество")]
        public string Отчество { get; set; }
        [Column(Name = "Серия_и_номер_паспорта")]
        public string Серия_и_номер_паспорта { get; set; }
        [Column(Name = "Адрес")]
        public string Адрес { get; set; }
        [Column(Name = "Контактный_телефон")]
        public string Контактный_телефон { get; set; }

    }
    [Table(Name = "Transactions")]
    class transactoins
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id_денежной_операции")]
        public int id_денежной_операции { get; set; }
        [Column(Name = "id_договора")]
        public int id_договора { get; set; }
        [Column(Name = "Вид_операции")]
        public int Вид_операции { get; set; }
        [Column(Name = "Сумма_операции")]
        public decimal Сумма_операции { get; set; }
        [Column(Name = "Дата_транзакции")]
        public DateTime Дата_транзакции { get; set; }
        [Column(Name = "id_работника")]
        public int id_работника { get; set; }
    }
    [Table(Name = "Coating")]
    class coating
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id_дома")]
        public int id_дома { get; set; }
        [Column(Name = "Улица")]
        public string Улица { get; set; }
       
    }
    [Table(Name = "Tarif")]
    class tarif
    { 
    [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id_тарифа")]
    public int id_тарифа { get; set; }
    [Column(Name = "id_вида_тарифа")]
    public int id_вида_тарифа { get; set; }
    [Column(Name = "Название_тарифа")]
    public string Название_тарифа { get; set; }
    [Column(Name = "Срок_действия")]
    public string Срок_действия { get; set; }
    [Column(Name = "Стоимость")]
    public decimal Стоимость { get; set; }
        [Column(Name = "Описание")]
        public string Описание { get; set; }
    }
    [Table(Name = "Services")]
    class services
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id_услуги")]
        public int id_услуги { get; set; }
        [Column(Name = "id_договора")]
        public int id_договора { get; set; }
        [Column(Name = "id_тарифа")]
        public int id_тарифа { get; set; }
    }
    }
