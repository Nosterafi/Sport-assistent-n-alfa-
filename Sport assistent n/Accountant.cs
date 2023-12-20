using MySql.Data.MySqlClient;
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
    /// UserControl, содержащий всю информацию и весь функционал, необходимые бухгалтеру.
    /// Наследует User
    /// </summary>
    public partial class Accountant : User
    {
        //Использующиеся UserControl-ы:
        //Profile
        //Sales
        //Gain
        //Debts
        //Report

        /// <summary>
        /// Поле-массив, которое хранит ссылки на UserControl-ы - разделы бухгалтера.
        /// Он необходим для использования метода VisualEffects.HideControls.
        /// </summary>
        private UserControl[] DataControls { get; set; }

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
        /// <param name="table">Таблица с данными бухгалтера</param>
        public Accountant(DataTable table)
        {
            InitializeComponent();
            userdata = table;
            DataPreparation();
            DataControls = new UserControl[]
            {
                profile1,
                sales1,
                gain1,
                debts1,
                report1
            };
            VisualEffects.HideControls(DataControls);
            sales1.Show();
        }

        /// <summary>
        /// Метод, предназначенный для загрузки данных о пользователе
        /// </summary>
        private void DataPreparation()
        {
            querySQL = new QueriesSQL(ConfigurationManager.ConnectionStrings["ProfileAccountant"].ConnectionString);
            MySqlCommand command = new MySqlCommand("SELECT * FROM `accountantdatabase` WHERE `login`=@ul AND `password`=@up");
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
        /// Метод, запускающийся при нажатии кнопки profileButton и открывающий профиль бухгалтера
        /// </summary>
        private void profilButton_Click(object sender, EventArgs e)
        {
            VisualEffects.HideControls(DataControls);
            profile1.Show();
        }

        /// <summary>
        /// Метод, запускающийся при нажатии кнопки salesButton и открывающий
        /// раздел учёта продаж абонементов
        /// </summary>
        private void salesButton_Click(object sender, EventArgs e)
        {
            VisualEffects.HideControls(DataControls);
            sales1.Show();
        }

        /// <summary>
        /// Метод, запускающийся при нажатии кнопки gainButton и открывающий
        /// раздел расчёта доходов
        /// </summary>
        private void gainButton_Click(object sender, EventArgs e)
        {
            VisualEffects.HideControls(DataControls);
            gain1.Show();
        }

        /// <summary>
        /// Метод, запускающийся при нажатии кнопки gainButton и открывающий
        /// раздел контроля задолженностей клиентов
        /// </summary>
        private void debtsButton_Click(object sender, EventArgs e)
        {
            VisualEffects.HideControls(DataControls);
            debts1.Show();
        }

        /// <summary>
        /// Метод, запускающийся при нажатии кнопки reportButton и открывающий
        /// раздел генерации отчётов о финансовых показателях
        /// </summary>
        private void reportButton_Click(object sender, EventArgs e)
        {
            VisualEffects.HideControls(DataControls);
            report1.Show();
        }

        private void report1_Load(object sender, EventArgs e)
        {

        }
    }
}
