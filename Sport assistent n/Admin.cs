﻿using MySql.Data.MySqlClient;
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
    /// <summary>
    /// UserControl, содержащий в себе весь функционал и всю информацию, необходимые для работы администратора.
    /// Наследует User
    /// </summary>
    public partial class Admin : User
    {
        //Использующиеся UserControls:
        //Profile
        //Acces
        //Notifications

        /// <summary>
        /// Поле-массив, которое хранит ссылки на UserControl-ы - разделы 
        /// администратора. Он необходим для использования метода VisualEffects.HideControls.
        /// </summary>
        private UserControl[] DataControls { get; set; }

        /// <summary>
        /// Таблица для загрузки данных из БД
        /// </summary>
        private DataTable userdata;

        /// <summary>
        /// Поле-коннектор. Используется для взаимодействия с БД
        /// </summary>
        private QueriesSQL querySQL;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="table"></param>
        public Admin(DataTable table)
        {
            InitializeComponent();
            userdata = table;
            DataPreparation();
            DataControls = new UserControl[]
            {
                profile1,
                acces1,
                notifications1
            };
            VisualEffects.HideControls(DataControls);
            acces1.Show();
        }

        /// <summary>
        /// Метод, предназначенный для загрузки данных о пользователе
        /// </summary>
        private void DataPreparation()
        {
            querySQL = new QueriesSQL(ConfigurationManager.ConnectionStrings["ProfileRoot"].ConnectionString);
            MySqlCommand command = new MySqlCommand("SELECT * FROM `admindatabase` WHERE `login`=@ul AND `password`=@up");
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = userdata.Rows[0]["login"];
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = userdata.Rows[0]["password"];
            Exception ex = querySQL.SelectDB(command, out userdata);
            if (ex != null) { MessageBox.Show($"Exception code: {ex.HResult}\n{ex.Message}"); VisualEffects.ControlsChange(this, new Entry(), new Point(0, 0)); }
            profile1.userSurname.Text = (string)userdata.Rows[0]["surname"];
            profile1.userName.Text = (string)userdata.Rows[0]["name"];
            if (userdata.Rows[0]["patronymic"]!= DBNull.Value) profile1.userPatronymic.Text = (string)userdata.Rows[0]["patronymic"];
            profile1.userLogin.Text = (string)userdata.Rows[0]["login"];
            profile1.userPassword.Text = (string)userdata.Rows[0]["password"];
        }

        //Все методы с именами, заканчивающимися на Click, отвечают
        //за действия, выполняемые при нажатии соответствующей кнопки.

        /// <summary>
        /// Метод, запускающийся при нажатии кнопки profileButton и открывающий
        /// профиль администратора
        /// </summary>
        private void profilButton_Click(object sender, EventArgs e)
        {
            VisualEffects.HideControls(DataControls);
            profile1.Show();
        }

        /// <summary>
        /// Метод, запускающийся при нажатии кнопки accesButton и открывающий
        /// раздел контроля доступа клиентов
        /// </summary>
        private void accesButton_Click(object sender, EventArgs e)
        {
            VisualEffects.HideControls(DataControls);
            acces1.Show();
        }

        /// <summary>
        /// Метод, запускающийся при нажатии кнопки notificationButton и открывающий
        /// раздел уведомлений
        /// </summary>
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
