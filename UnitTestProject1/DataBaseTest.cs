using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using Sport_assistent_n;
using System;
using System.Data;

namespace DataBaseTest
{
    [TestClass]
    public class UnitTestOnDB
    {
        #region Тестирование при включенной и исправной базе данных на правах root пользователя!
        //Внимание!!!
        //Сверяйтесь с базой данных!
        //После добавления, удаления и/или обновления должны происходить соответствующие изменения в БД!!
        //Проверяйте!!!
        [TestMethod]
        //команда SELECT предназначена для просмотра информации в DB любым критериям
        //если есть строка/и, которые подходят под критерии, то команда возвращает их
        //иначе возвращает null
        public void TestMethodSelectROOT()
        {
            var queries = new QueriesSQL("server=localhost;port=3306;username=root;password=root;database=profile");
            DataTable dataTable = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `startingdatabase` WHERE `login`=@ulog AND `password`=@upas");
            //при выполнении команды SELECT от профиля root не должны возникать ошибки
            //если есть такая строка в базе данных, то она должна вернуться в DataTable
            //иначе возвращается пустая строка, соответственно длина DataTable должна быть 0
            command.Parameters.Add("@ulog", MySqlDbType.VarChar).Value = "client";//профиль существует
            command.Parameters.Add("@upas", MySqlDbType.VarChar).Value = "123";
            Assert.AreEqual(queries.SelectDB(command, out dataTable), null);
            Assert.AreEqual(dataTable.Select().Length, 1);//должна вернуться одна строка
            //иначе проверьте командную строку с параметрами и таблицу данных из DB, которую вы взяли для тестов
            command.Parameters.Clear();
            command.Parameters.Add("@ulog", MySqlDbType.VarChar).Value = "aboba";//такого профиля пока не существует
            command.Parameters.Add("@upas", MySqlDbType.VarChar).Value = "amoga";
            Assert.AreEqual(queries.SelectDB(command, out dataTable), null);
            Assert.AreEqual(dataTable.Select().Length, 0);
            //по скольку такого профиля не существует, DT должен быть пуст
            //иначе проверьте командную строку с параметрами и таблицу данных из DB, которую вы взяли для тестов
        }

        [TestMethod]
        //команда INSERT предназначена для добаления новой строки данных в DB
        //команда DELETE, наоборот, удаляет все строки данных в DB по соответствующим критериям
        public void TestMethodInsertDeletROOT()
        {
            //Добавление в базу данных
            var queries = new QueriesSQL("server=localhost;port=3306;username=root;password=root;database=profile");
            MySqlCommand command = new MySqlCommand("INSERT INTO `coachdatabase` (`surname`, `name`, `patronymic`, `login`, `password`) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5);");
            command.Parameters.Add("@Value1", MySqlDbType.VarChar).Value = "Корольков";
            command.Parameters.Add("@Value2", MySqlDbType.VarChar).Value = "Иван";
            command.Parameters.Add("@Value3", MySqlDbType.VarChar).Value = "Юрьевич";
            command.Parameters.Add("@Value4", MySqlDbType.VarChar).Value = "coach";//такой логин уже существует
            command.Parameters.Add("@Value5", MySqlDbType.VarChar).Value = "12345";
            //если вы пытаетесь добавить в DB значение, которое должно быть уникальным, и которое уже существует
            //то DB выдаст исключение, которое передастся в программу
            Assert.AreNotEqual(queries.UpdateInsertDeletDB(command), null);
            //в данном случаи строка с таким логином уже существует, поэтому должно выдаваться исключение
            //иначе проверьте командную строку с параметрами и таблицу данных из DB, которую вы взяли для тестов
            command.Parameters.Clear();
            command.Parameters.Add("@Value1", MySqlDbType.VarChar).Value = "Корольков";
            command.Parameters.Add("@Value2", MySqlDbType.VarChar).Value = "Иван";
            command.Parameters.Add("@Value3", MySqlDbType.VarChar).Value = "Юрьевич";
            command.Parameters.Add("@Value4", MySqlDbType.VarChar).Value = "xQxQ";//такого логина нет
            command.Parameters.Add("@Value5", MySqlDbType.VarChar).Value = "12345";
            Assert.AreEqual(queries.UpdateInsertDeletDB(command), null);
            //в этом случаи строки с таким профилем не существует в DB, поэтому операция должна пройти без исключений
            //иначе проверьте командную строку с параметрами и таблицу данных из DB, которую вы взяли для тестов

            //Удаление из базы данных
            //данная операция призвана удалить все строки в DB, которые попадают под заданный/е нами критерий/и
            //выкидывает исключение в основном только в том случаи, если мы что-то не правильно указали
            command = new MySqlCommand("DELETE FROM coachdatabase WHERE `coachdatabase`.`login` = @Value;");
            command.Parameters.Add("@Value", MySqlDbType.VarChar).Value = "sndk";//этого логина нет
            //не смотря на то, что строки с данным логином не существует, исключение всё равно не должно вылезать
            //т.к. команда ищет подходящие строки и удаляет их
            //если таковых нет, то значит из нет, и операция удаления просто не была необходима
            //иначе проверьте командную строку с параметрами и таблицу данных из DB, которую вы взяли для тестов
            Assert.AreEqual(queries.UpdateInsertDeletDB(command), null);
            command.Parameters.Clear();
            command.Parameters.Add("@Value", MySqlDbType.VarChar).Value = "xQxQ";//этот профиль должен удалиться из таблицы
            Assert.AreEqual(queries.UpdateInsertDeletDB(command), null);
            //этот профиль уже существует (мы его ранее создали), и поэтому после операции он должен был удалится
            //иначе проверьте командную строку с параметрами и таблицу данных из DB, которую вы взяли для тестов

        }
        [TestMethod]
        //команда UPDATE предназначена для обновления указанных нами значений в определённых строках DB, которые мы тоже выбираем по своим критериям
        //по своей сути перезаписывает данные, которые были изменены (и если были изменены)
        public void TestMethodUpdateROOT()
        {
            var queries = new QueriesSQL("server=localhost;port=3306;username=root;password=root;database=profile");
            MySqlCommand command = new MySqlCommand("UPDATE `accountantdatabase` SET `login` = @Value1, `password` = @Value2 WHERE `accountantdatabase`.`login` = @Value3;");
            command.Parameters.Add("@Value1", MySqlDbType.VarChar).Value = "accountantEX";
            //command.Parameters.Add("@Value2", MySqlDbType.VarChar).Value = new Random().Next(1000).ToString();
            command.Parameters.Add("@Value2", MySqlDbType.VarChar).Value = "12358";
            command.Parameters.Add("@Value3", MySqlDbType.VarChar).Value = "accountant";//профиль существует
            //обновляет логин и пароль существующего профиля, исключений не должно быть
            //иначе проверьте командную строку с параметрами и таблицу данных из DB, которую вы взяли для тестов
            Assert.AreEqual(queries.UpdateInsertDeletDB(command), null);
            command.Parameters.Clear();
            command.Parameters.Add("@Value1", MySqlDbType.VarChar).Value = "accountantEX";
            command.Parameters.Add("@Value2", MySqlDbType.VarChar).Value = "12358";
            command.Parameters.Add("@Value3", MySqlDbType.VarChar).Value = "russian_condors";//профиль не существует
            //в данном случаи профиля с таким логином не существует, однако исключения не должно вылезти
            //иначе проверьте командную строку с параметрами и таблицу данных из DB, которую вы взяли для тестов
            Assert.AreEqual(queries.UpdateInsertDeletDB(command), null);
        }
        #endregion

        #region Тестирование при включенной и исправной базе данных на правах других пользователей!
        //Внимание!!!
        //Сверяйтесь с базой данных!
        //После добавления, удаления и/или обновления должны происходить соответствующие изменения в БД!!
        //Проверяйте!!!
        [TestMethod]
        //суть данного тестового метода заключается в том, что в DB присутствуют пользователи с различными уровнями доступа
        //данные тесты призваны проверить, что ограничения прав пользователей работают
        //иначе проверьте командную строку с параметрами и уровни доступа пользователей в DB
        public void TestMethodSelectStartingUSER()
        {
            //у пользователя 'startingUSER' есть только одна возможность: просматривать (с помощью SELECT) таблицу данных `startingdatabase` в базе данных 'profile'
            var queries = new QueriesSQL("server=localhost;port=3306;username=startingUSER;password=USER;database=profile");
            DataTable dataTable = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `startingdatabase` WHERE `login`=@ulog AND `password`=@upas");
            //при выполнении команды SELECT от профиля startingUSER в таблицу данных `startingdatabase` не должны возникать ошибки
            //иначе проверьте командную строку с параметрами и уровни доступа пользователей в DB
            command.Parameters.Add("@ulog", MySqlDbType.VarChar).Value = "client";
            command.Parameters.Add("@upas", MySqlDbType.VarChar).Value = "123";
            Assert.AreEqual(queries.SelectDB(command, out dataTable), null);
            Assert.AreEqual(dataTable.Select().Length, 1);

            //этот тест должен выдать ошибку, т.к. пользователю закрыто добавление (INSERT)
            //иначе проверьте командную строку с параметрами и уровни доступа пользователей в DB
            command = new MySqlCommand("INSERT INTO `startingdatabase` (`id`, `login`, `password`, `role`) VALUES (@Value1, @Value2, @Value3, @Value4);");
            command.Parameters.Add("@Value1", MySqlDbType.VarChar).Value = "imposible";
            command.Parameters.Add("@Value2", MySqlDbType.VarChar).Value = "imposible";
            command.Parameters.Add("@Value3", MySqlDbType.VarChar).Value = "imposible";
            command.Parameters.Add("@Value4", MySqlDbType.Int32).Value = 0;
            Assert.AreNotEqual(queries.UpdateInsertDeletDB(command), null);
        }

        [TestMethod]
        //этот тест призван проверить, что пользователь 'coachUSER' (тренер) может только обновить/посмотреть таблицу данных 'section'
        //в базе данных 'trainingschedules'
        public void TestMethodUpdateSelectCoachUSER()
        {
            //пользователь 'coachUSER' может обновлять, удалять, смотреть,добавлять данные в свою таблицу данных 'coachdatabase' в базе данных 'profile'
            //а также может просматривать и обновлять таблицу данных 'section' в базе данных 'trainingschedules'
            var queries = new QueriesSQL("server=localhost;port=3306;username=coachUSER;password=coach;database=trainingschedules");
            DataTable dataTable = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `section` WHERE `name`=@Value");
            //при выполнении команды SELECT от профиля 'coachUSER' в таблицу данных `trainingschedules` не должны возникать ошибки
            //иначе проверьте командную строку с параметрами и уровни доступа пользователей в DB
            command.Parameters.Add("@Value", MySqlDbType.VarChar).Value = "Кикбоксинг";
            Assert.AreEqual(queries.SelectDB(command, out dataTable), null);
            Assert.AreEqual(dataTable.Select().Length, 1);

            //этот тест должен выдать ошибку, т.к. пользователю закрыто добавление (INSERT)
            //иначе проверьте командную строку с параметрами и уровни доступа пользователей в DB
            command = new MySqlCommand("INSERT INTO `section` (`name`, `description`, `time`, `status`) VALUES (@Value1, @Value2, @Value3, @Value4);");
            command.Parameters.Add("@Value1", MySqlDbType.VarChar).Value = "imposible";
            command.Parameters.Add("@Value2", MySqlDbType.VarChar).Value = "imposible";
            command.Parameters.Add("@Value3", MySqlDbType.DateTime).Value = new DateTime(2023, 12, 15, 15, 30, 0);
            sbyte tinyIntValue = 1;
            command.Parameters.Add("@Value4", MySqlDbType.Byte).Value = tinyIntValue;
            Assert.AreNotEqual(queries.UpdateInsertDeletDB(command), null);

            command = new MySqlCommand("UPDATE `section` SET `description` = @Value1 WHERE `section`.`name` = @Value2;");
            //при выполнении команды UPDATE от профиля 'coachUSER' в таблицу данных `trainingschedules` не должны возникать ошибки
            //иначе проверьте командную строку с параметрами и уровни доступа пользователей в DB
            command.Parameters.Add("@Value2", MySqlDbType.VarChar).Value = "Кикбоксинг";
            command.Parameters.Add("@Value1", MySqlDbType.VarChar).Value = "Каждый четверг в 19:00\nПока ведёт только Корольков!";
            Assert.AreEqual(queries.UpdateInsertDeletDB(command), null);

            //этот тест должен выдать ошибку, т.к. пользователю закрыто удаление (DELETE)
            //иначе проверьте командную строку с параметрами и уровни доступа пользователей в DB
            command = new MySqlCommand("DELETE FROM 'section' WHERE `section`.`name` = @Value;");
            command.Parameters.Add("@Value1", MySqlDbType.VarChar).Value = "Кикбоксинг";
            Assert.AreNotEqual(queries.UpdateInsertDeletDB(command), null);
        }

        [TestMethod]
        //этот тест призван проверить, что пользователь 'adminspUSER' (администратор спорткомплекса) не может ничего сдлеать с таблицей данных 'admindatabase'
        //в базе данных 'profile'
        public void TestMethodActionsAdmindatabaseAdminspUSER()
        {
            //все операции (SELECT, INSERT, DELETE, UPDATE) должны быть недоступны данному профилю
            var queries = new QueriesSQL("server=localhost;port=3306;username=adminspUSER;password=adminsp;database=profile");
            DataTable dataTable = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `admindatabase` WHERE `login`=@Value");
            command.Parameters.Add("@Value", MySqlDbType.VarChar).Value = "admin";
            Assert.AreNotEqual(queries.SelectDB(command, out dataTable), null);
            Assert.AreEqual(dataTable, null);

            command = new MySqlCommand("INSERT INTO `admindatabase` (`surname`, `name`, `patronymic`, `login`, 'password') VALUES (@Value1, @Value2, @Value3, @Value4, @Value5);");
            command.Parameters.Add("@Value1", MySqlDbType.VarChar).Value = "imposible";
            command.Parameters.Add("@Value2", MySqlDbType.VarChar).Value = "imposible";
            command.Parameters.Add("@Value3", MySqlDbType.VarChar).Value = "imposible";
            command.Parameters.Add("@Value4", MySqlDbType.VarChar).Value = "imposible";
            command.Parameters.Add("@Value5", MySqlDbType.VarChar).Value = "imposible";
            Assert.AreNotEqual(queries.UpdateInsertDeletDB(command), null);

            command = new MySqlCommand("UPDATE `admindatabase` SET `login` = @Value1 WHERE `admindatabase`.`login` = @Value2;");
            command.Parameters.Add("@Value1", MySqlDbType.VarChar).Value = "newlogin";
            command.Parameters.Add("@Value2", MySqlDbType.VarChar).Value = "admin";
            Assert.AreNotEqual(queries.UpdateInsertDeletDB(command), null);

            command = new MySqlCommand("DELETE FROM 'admindatabase' WHERE `admindatabase`.`login` = @Value;");
            command.Parameters.Add("@Value1", MySqlDbType.VarChar).Value = "admin";
            Assert.AreNotEqual(queries.UpdateInsertDeletDB(command), null);
        }
        #endregion
    }
}
