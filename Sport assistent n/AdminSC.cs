﻿using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sport_assistent_n
{

    /// <summary>
    /// UserControl, содержащий в себе весь функционал и всю информацию,
    /// необходимые для работы администратора спорткомплекса.
    /// </summary>
    public partial class AdminSC : Sport_assistent_n.User
    {
        //Использующиеся UserControls:
        //Profile
        //Manager
        //Distribution
        //Monitoring

        /// <summary>
        /// Поле-массив, которое хранит ссылки на UserControl-ы - разделы 
        /// администратора спорткомплекса. Он необходим для использования метода VisualEffects.HideControls.
        /// </summary>
        private UserControl[] DataControl { get; set; }

        /// <summary>
        /// Таблица для загрузки данных из БД
        /// </summary>
        private DataTable userdata;

        /// <summary>
        /// Поле-коннектор. Через него происходит взаимодействие с БД
        /// </summary>
        private QueriesSQL querySQL;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="table"></param>
        public AdminSC(DataTable table)
        {
            InitializeComponent();
            userdata = table;
            DataPreparation();
            DataControl = new UserControl[]
            {
                profile1,
                manager1,
                distribution1,
                monitoring1
            };
            VisualEffects.HideControls(DataControl);
            manager1.Show();
        }

        /// <summary>
        /// Метод, предназначенный для загрузки данных о пользователи
        /// </summary>
        private void DataPreparation()
        {
            querySQL = new QueriesSQL(ConfigurationManager.ConnectionStrings["ProfileAdminSC"].ConnectionString);
            MySqlCommand command = new MySqlCommand("SELECT * FROM `adminsportcomplexdatabase` WHERE `login`=@ul AND `password`=@up");
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = userdata.Rows[0]["login"];
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = userdata.Rows[0]["password"];
            Exception ex = querySQL.SelectDB(command, out userdata);
            if (ex != null) { MessageBox.Show($"Exception code: {ex.HResult}\n{ex.Message}"); VisualEffects.ControlsChange(this, new Entry(), new Point(0, 0)); }
            profile1.userSurname.Text = (string)userdata.Rows[0]["surname"];
            profile1.userName.Text = (string)userdata.Rows[0]["name"];
            if (userdata.Rows[0]["patronymic"] != DBNull.Value) profile1.userPatronymic.Text = (string)userdata.Rows[0]["patronymic"];
            profile1.userLogin.Text = (string)userdata.Rows[0]["login"];
            profile1.userPassword.Text = (string)userdata.Rows[0]["password"];
        }

        //Все методы с именами, заканчивающимися на Click, отвечают
        //за действия, выполняемые при нажатии соответствующей кнопки.

        /// <summary>
        /// Метод, запускающийся при нажатии кнопки profileButton и открывающий
        /// профиль администратора спорткомплекса
        /// </summary>
        private void profilButton_Click(object sender, EventArgs e)
        {
            VisualEffects.HideControls(DataControl);
            profile1.Show();
        }

        /// <summary>
        /// Метод, запускающийся при нажатии кнопки managerButton и открывающий
        /// раздел управления клиентскими данными
        /// </summary>
        private void managerButton_Click(object sender, EventArgs e)
        {
            VisualEffects.HideControls(DataControl);
            manager1.Show();
        }

        /// <summary>
        /// Метод, запускающийся при нажатии кнопки distributionButton и открывающий
        /// раздел распределения тренеров
        /// </summary>
        private void distributionButton_Click(object sender, EventArgs e)
        {
            VisualEffects.HideControls(DataControl);
            distribution1.Show();
        }

        /// <summary>
        /// Метод, запускающийся при нажатии кнопки monitoringButton и открывающий
        /// раздел мониторинга
        /// </summary>
        private void monitoringButton_Click(object sender, EventArgs e)
        {
            VisualEffects.HideControls(DataControl);
            monitoring1.Show();
        }

        private void monitoring1_Load(object sender, EventArgs e)
        {

        }
    }
}
