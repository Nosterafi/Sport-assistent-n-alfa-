using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Sport_assistent_n
{
    public class QueriesSQL
    {
        private MySqlConnection connector;
        public QueriesSQL(string connectionString) => connector = new MySqlConnection(connectionString);//задаем сервер и профиль
        public void NewConnectionString(string connectionString) => connector=new MySqlConnection(connectionString);//для перезахода
        private bool kf;//керри-флаг, предназначенный для проверки состояния (открыто/закрыто) connector

        //для просмотра и возвращения данных из таблицы
        //применять, если в качестве операции для передаци команды в DB вы использовали команду SELECT
        public Exception SelectDB(MySqlCommand command, out DataTable table)
        {
            //if(!kfConnect) OpenConnect();
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
        //для удаления, обновления и добавления в таблицу данных
        //применять, если в качестве операции для передаци команды в DB вы использовали команду INSERT, UPDATE и/или DELETE
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
        //public int ExNumber(int i) => i;
    }
}
