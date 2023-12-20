using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Drawing;

namespace Sport_assistent_n
{
    /// <summary>
    /// UserControl, через который происходят вход в систему и переход к разделу регистрации
    /// </summary>
    public partial class Entry : UserControl
    {
        /// <summary>
        /// Поле-коннектор. Через него происходит взаимодействие с БД
        /// </summary>
        private QueriesSQL SQL;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Entry()
        {
            InitializeComponent();
            SQL = new QueriesSQL(ConfigurationManager.ConnectionStrings["ProfileStart"].ConnectionString);
        }

        /// <summary>
        /// Метод, запускающийся при нажатии кнопки entryButton. Проверяет введённые данные и
        /// в случае верного ввода открывает одно из окон пользователей. В противном случае
        /// метод выводит сообщение об ошибке
        /// </summary>
        private void entryButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `startingdatabase` WHERE `login`=@ul AND `password`=@up");
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginTextBox.Text;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = passwordTextBox.Text;
            //SQL.OpenConnect();
            Exception except = SQL.SelectDB(command, out dataTable);
            //SQL.CloseConnect();
            if (except!=null) { MessageBox.Show($"Exception code: {except.HResult}\n{except.Message}"); }
            else if (dataTable.Select().Length == 1)
            {
                switch ((uint)dataTable.Rows[0]["role"])
                {
                    case 4:
                        VisualEffects.ControlsChange(this, new Admin(dataTable), new Point(0, 0));
                        break;
                    case 2:
                        VisualEffects.ControlsChange(this, new Accountant(dataTable), new Point(0, 0));
                        break;
                    case 0:
                        VisualEffects.ControlsChange(this, new Client(dataTable), new Point(0, 0));
                        break;
                    case 3:
                        VisualEffects.ControlsChange(this, new AdminSC(dataTable), new Point(0, 0));
                        break;
                    case 1:
                        VisualEffects.ControlsChange(this, new Trainer(dataTable), new Point(0, 0));
                        break;
                    default:
                        MessageBox.Show("Ошибка нахождения нужного профильного окна! Срочно обратитесь к администрации при нахождении этой ошибки!");
                        break;
                }
            }
            else MessageBox.Show("Профиль не найден!");
        }

        /// <summary>
        /// Метод, запускающийся при нажатии кнопки entryButton и открывающий
        /// окно операции клиента
        /// </summary>
        private void registrationButton_Click(object sender, EventArgs e)
        {
            VisualEffects.ControlsChange(this, new Registration());
        }

        private void Entry_Load(object sender, EventArgs e)
        {

        }
    }
}
