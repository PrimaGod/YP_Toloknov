using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPractice
{
    public static class MainClass
    {
        public static string connectionString = @"Data Source=10.10.1.24;Initial Catalog=YP_Toloknov;Persist Security Info=True;User ID=pro-41;Password=Pro_41student";
        public static string authorizeMethod()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                connection.Open();
                return "Connected";

            }
            catch (SqlException ex)
            {
                //в случае ошибки выведем полное описание проблемы
                return ex.Message;
            }
            finally
            {
                // закрываем подключение
                connection.Close();
            }
        }
        public static DataSet getDataFromClients(int offsetCount)
        {
            string sql = "select Client.ID,Client.FirstName+' '+Client.LastName+' '+Client.Patronymic AS FullName,Gender.Name AS Gender, Client.Birthday, Client.Phone, Client.Email, Client.RegistrationDate From Client JOIN Gender ON Gender.Code = Client.GenderCode Order by Client.ID OFFSET "+offsetCount+" ROWS FETCH NEXT 25 ROWS ONLY";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();
                return ds;
            }
        }
        public static DataSet getDataFromClientsFULL()
        {
            string sql = "select * from Client";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();
                return ds;
            }
        }
        public static DataSet getDataFromServiceFULL()
        {
            string sql = "select * from Service";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();
                return ds;
            }
        }
        public static DataSet getDataAboutClient(int idClient)
        {
            string sql = "select * from Client where ID = " + idClient;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();
                return ds;
            }
        }
        public static DataSet getDataFromService(int idClient)
        {
            string sql;
            if (idClient == 0)
            {
                sql = "select Client.FirstName+' '+Client.LastName+' '+Client.Patronymic AS FullName, Service.Title, ClientService.StartTime, ClientService.Comment From ClientService JOIN Client ON Client.ID = ClientService.ClientID JOIN Service ON Service.ID = ClientService.ServiceID";

            }
            else
            {
                sql = "select Client.FirstName+' '+Client.LastName+' '+Client.Patronymic AS FullName, Service.Title, ClientService.StartTime, ClientService.Comment From ClientService JOIN Client ON Client.ID = ClientService.ClientID JOIN Service ON Service.ID = ClientService.ServiceID where ClientService.ClientID = " + idClient.ToString();

            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();
                return ds;
            }
        }
        public static DataSet getFilterData(int offsetCount,string firstName, string lastName)
        {
            string sql;
            if (firstName != "" && lastName == "")
            {
                sql = "select Client.ID,Client.FirstName+' '+Client.LastName+' '+Client.Patronymic AS FullName,Gender.Name, Client.Birthday, Client.Phone, Client.Email, Client.RegistrationDate From Client JOIN Gender ON Gender.Code = Client.GenderCode where Client.FirstName LIKE '%" + firstName + "%' Order by Client.ID OFFSET " + offsetCount + " ROWS FETCH NEXT 25 ROWS ONLY";


            }
            else if (firstName == "" && lastName != "")
            {
                sql = "select Client.ID,Client.FirstName+' '+Client.LastName+' '+Client.Patronymic AS FullName,Gender.Name, Client.Birthday, Client.Phone, Client.Email, Client.RegistrationDate From Client JOIN Gender ON Gender.Code = Client.GenderCode where Client.LastName LIKE '%" + lastName + "%' Order by Client.ID OFFSET " + offsetCount + " ROWS FETCH NEXT 25 ROWS ONLY";

            }
            else
            {
                sql = "select Client.ID,Client.FirstName+' '+Client.LastName+' '+Client.Patronymic AS FullName,Gender.Name, Client.Birthday, Client.Phone, Client.Email, Client.RegistrationDate From Client JOIN Gender ON Gender.Code = Client.GenderCode where Client.FirstName LIKE '%" + firstName + "%' or Client.LastName LIKE '%" + lastName + "%' Order by Client.ID OFFSET " + offsetCount + " ROWS FETCH NEXT 25 ROWS ONLY";
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();
                return ds;
            }
        }

        //метод записи данных в БД
        public static void writeData2DB(string firstName,string lastName,string Patronymic, DateTime dateBirth, int gender_id, string email, string phone)
        {
            string sql = "insert into Client (FirstName,LastName,Patronymic,Birthday,RegistrationDate,GenderCode,Email,Phone) Values ('"+firstName+"','"+lastName+"','"+Patronymic+"','"+dateBirth+"',GETDATE(),"+gender_id+",'"+email+"','"+phone+"')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                int number = command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static void writeDataClientService(int clientID, int serviceID,string comment)
        {
            string sql = "insert into ClientService (ClientID,ServiceID,StartTime,Comment) values ("+clientID+","+serviceID+",GETDATE(),'"+comment+"')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                int number = command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static void changeRowClient(int idClient, string firstName, string lastName, string Patronymic, DateTime dateBirth, int gender_id, string email, string phone)
        {
            string sql = "update Client SET FirstName = '" + firstName + "', LastName = '" + lastName + "', Patronymic = '" + Patronymic + "', Birthday = '" + dateBirth + "', Email = '" + email + "',Phone = '" + phone + "', GenderCode = " + gender_id + " WHERE ID = " + idClient;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                int number = command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static int getCountOfClients()
        {
            string sql = "select COUNT(*) from Client";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                int count = 0;
                if (reader.HasRows) // если есть данные
                {

                    while (reader.Read()) // построчно считываем данные
                    {
                        count = (int)reader.GetValue(0);
                    }
                    reader.Close();
                    connection.Close();
                    return count;
                }
                else
                {
                    reader.Close();
                    connection.Close();
                    return count;
                }
            }
        }
        public static void deleteRow(int idDelete)
        {
            string sql = "delete from Client where ID = " + idDelete;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                int number = command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
