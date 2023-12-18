using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_assistent_n
{
    //UserControl, через который происходит регистрация клиентов.
    public partial class Registration : UserControl
    {
        private QueriesSQL SQL;
        //Конструктор.
        public Registration()
        {
            InitializeComponent();
            SQL = new QueriesSQL(ConfigurationManager.ConnectionStrings["ProfileClient"].ConnectionString);
        }

        //Все методы с именами, заканчивающимися на Click, отвечают
        //за действия, выполняемые при нажатии соответствующей кнопки.
        private void saveButton_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO clientdatabase (surname, name, patronymic, login, password, cost) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)");
            command.Parameters.Add("@Value1", MySqlDbType.VarChar).Value = surnameTextBox.Text;
            command.Parameters.Add("@Value2", MySqlDbType.VarChar).Value = nameTextBox.Text;
            command.Parameters.Add("@Value3", MySqlDbType.VarChar).Value = patronymicTextBox1.Text;
            command.Parameters.Add("@Value4", MySqlDbType.VarChar).Value = emailTextBox.Text;
            command.Parameters.Add("@Value5", MySqlDbType.VarChar).Value = passwordTextBox.Text;
            command.Parameters.Add("@Value6", MySqlDbType.Decimal).Value = 0;
            Exception ex=SQL.UpdateInsertDeletDB(command);
            if (ex != null) { MessageBox.Show($"Exception code: {ex.HResult}\n{ex.Message}"); return; }
            MessageBox.Show("Аккаунт зарегестрирован!\nМожете в него войти!");
            VisualEffects.ControlsChange(this, new Entry(), new Point(0, 0));
        }
        //Эксперемент
        //Удачный
        private void Ex()
        {
            MySqlCommand command = new MySqlCommand("UPDATE `clientdatabase` SET `password` = @ul WHERE `clientdatabase`.`id` = @up;");
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = "изменено";
            command.Parameters.Add("@up", MySqlDbType.Int16).Value = 1;
            Exception ex = SQL.UpdateInsertDeletDB(command);
            if (ex != null) { MessageBox.Show($"Exception code: {ex.HResult}\n{ex.Message}"); return; }
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
