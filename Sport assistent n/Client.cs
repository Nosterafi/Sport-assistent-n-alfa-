using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sport_assistent_n
{
    //UserControl, содержащий в себе весь функционал и всю информацию,
    //необходимые для работы клиента спорткомплекса.
    public partial class Client : Sport_assistent_n.User
    {
        //Использующиеся UserControls:
        //Profile
        //Subsription
        //Timetable
        //Notifications

        //Массив, который хранит ссылки на UserControl-ы - разделы 
        //клиента. Он необходим для использования метода VisualEffects.HideControls.
        private UserControl[] DataControls { get; set; }
        private DataTable userdata;//таблица для загрузки данных из DB
        private QueriesSQL querySQL;

        //Конструктор.
        public Client(DataTable table)
        {
            InitializeComponent();
            userdata = table;
            DataPreparation();
            DataControls = new UserControl[]
            {
                profile1,
                subscription1,
                timetable1,
                notifications1
            };
            VisualEffects.HideControls(DataControls);
            subscription1.Show();
            userdata = table;
        }
        //Метод, предназначенный для загрузки данных о пользователи
        private void DataPreparation()
        {
            querySQL = new QueriesSQL(ConfigurationManager.ConnectionStrings["ProfileClient"].ConnectionString);
            MySqlCommand command = new MySqlCommand("SELECT * FROM `clientdatabase` WHERE `login`=@ul AND `password`=@up");
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = userdata.Rows[0]["login"];
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = userdata.Rows[0]["password"];
            Exception ex = querySQL.SelectDB(command, out userdata);
            if (ex != null) { MessageBox.Show($"Exception code: {ex.HResult}\n{ex.Message}"); VisualEffects.ControlsChange(this, new Entry(), new Point(0, 0)); }
            profile1.userSurname.Text = (string)userdata.Rows[0]["surname"];
            profile1.userName.Text = (string)userdata.Rows[0]["name"];
            if (userdata.Rows[0]["patronymic"] != DBNull.Value) profile1.userPatronymic.Text = (string)userdata.Rows[0]["patronymic"];
            profile1.userLogin.Text = (string)userdata.Rows[0]["login"];
            profile1.userPassword.Text = (string)userdata.Rows[0]["password"];
            //subscription1.dataGridView1.DataSource = userdata;
            //querySQL.NewConnectionString(ConfigurationManager.ConnectionStrings["ProfileClient"].ConnectionString);
        }

        //Все методы с именами, заканчивающимися на Click, отвечают
        //за действия, выполняемые при нажатии соответствующей кнопки.
        private void profilButton_Click(object sender, EventArgs e)
        {
            VisualEffects.HideControls(DataControls);
            profile1.Show();
        }

        private void subscriptionButton_Click(object sender, EventArgs e)
        {
            VisualEffects.HideControls(DataControls);
            subscription1.Show();
        }

        private void timeTableButton_Click(object sender, EventArgs e)
        {
            VisualEffects.HideControls(DataControls);
            timetable1.Show();
        }

        private void notificationButton_Click(object sender, EventArgs e)
        {
            VisualEffects.HideControls(DataControls);
            notifications1.Show();
        }

        private void notifications1_Load(object sender, EventArgs e)
        {

        }
    }
}
