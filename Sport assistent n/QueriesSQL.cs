using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Sport_assistent_n
{
    /// <summary>
    /// Класс, предоставляющий методы для взаимодействия с БД
    /// </summary>
    public class QueriesSQL
    {
        /// <summary>
        /// Поле, через которое происходит подключение к БД
        /// </summary>
        private MySqlConnection connector;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="connectionString">Данные для входа</param>
        public QueriesSQL(string connectionString) => connector = new MySqlConnection(connectionString);//задаем сервер и профиль

        /// <summary>
        /// Выполняет переподключение к БД
        /// </summary>
        /// <param name="connectionString">Данные для входа</param>
        public void NewConnectionString(string connectionString) => connector=new MySqlConnection(connectionString);//для перезахода

        /// <summary>
        /// Керри-флаг, предназначенный для проверки состояния (открыто/закрыто) connector
        /// </summary>
        private bool kf;

        /// <summary>
        /// Используется для проверки правильности выполнения операции SELECT в составе команды
        /// </summary>
        /// <param name="command">Команда, которую нужно выполнить</param>
        /// <param name="table">Ссылка на таблицу с данными</param>
        /// <returns>Исключение в случае, когда нельзя выполнить комманду. Иначе - null</returns>
        public Exception SelectDB(MySqlCommand command, out DataTable table)
        {
            command.Connection = connector;
            DataTable dataTable = new DataTable();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter();
            try
            {
                if (!kf) { connector.Open(); kf = true; }
                sqlDataAdapter.SelectCommand = command;
                sqlDataAdapter.Fill(dataTable);
                connector.Close();
                kf=false;
                table = dataTable;
                return null;
            }
            catch (Exception ex){ if (kf) { connector.Close();kf = false; } table=null; return ex; }
        }
        
        /// <summary>
        /// Используется для проверки правильности выполнения операциq INSERT, UPDATE и/или DELETE в составе команды
        /// </summary>
        /// <param name="command">Команда, которую нужно выполнить</param>
        /// <returns>Исключение в случае, когда нельзя выполнить комманду. Иначе - null</returns>
        public Exception UpdateInsertDeletDB(MySqlCommand command)
        {
            //if (!kfConnect) OpenConnect();
            command.Connection = connector;
            try
            {
                if (!kf) { connector.Open(); kf = true; }
                command.ExecuteNonQuery();
                connector.Close();
                kf = false;
                return null;
            }
            catch (Exception ex) { if (kf) { connector.Close(); kf = false; } return ex; }
        }
    }
}
