using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Drawing;

namespace Sport_assistent_n
{
    //UserControl, через который происходят вход в систему и переход к разделу регистрации.
    public partial class Entry : UserControl
    {
        private QueriesSQL SQL;
        //private MySqlConnection connector;
        //Конструктор.
        public Entry()
        {
            InitializeComponent();
            SQL = new QueriesSQL(ConfigurationManager.ConnectionStrings["ProfileStart"].ConnectionString);
        }
        private void entryButton_Click(object sender, EventArgs e)
        {
            //if (loginTextBox.Text == "Nosterafi" && passwordTextBox.Text == "0000")
            //    VisualEffects.ControlsChange(this, new Admin(), new Point(0, 0));      
            /*
            try
            {
                connector = new MySqlConnection(ConfigurationManager.ConnectionStrings["ProfileStart"].ConnectionString);
                connector.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базам данных: {ex.Message}\nПовторите попытку позже!");
                return;
            }
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            DataTable dataTable = new DataTable();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `startingdatabase` WHERE `login`=@ul AND `password`=@up", connector);
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = password;
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(dataTable);
            connector.Close();
            */
            //var d = dataTable;
            //var s = dataTable.Rows[0]["role"];
            //QueriesSQL SQL = new QueriesSQL(ConfigurationManager.ConnectionStrings["ProfileStart"].ConnectionString);
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

        //Все методы с именами, заканчивающимися на Click, отвечают
        //за действия, выполняемые при нажатии соответствующей кнопки.
        private void registrationButton_Click(object sender, EventArgs e)
        {
            VisualEffects.ControlsChange(this, new Registration());
        }

        private void Entry_Load(object sender, EventArgs e)
        {

        }
    }
}
