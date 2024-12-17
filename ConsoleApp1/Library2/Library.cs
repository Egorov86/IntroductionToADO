using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel.Design;

namespace Library2
{
    internal class Library
    {
        static string connectionString = "";
        public static SqlConnection connection = null;
        static readonly string delimiter1 = "\n------------------------------------\n";
        static readonly string delimiter2 = "\n=====================================\n";
        static Library()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;
            connection = new SqlConnection(connectionString);
            Console.WriteLine(connectionString);
        }
        public static void Select(string fields, string tables, string condition = "", int padding=20)
        {
            string cmd = $"SELECT {fields} FROM {tables}";
            if (condition.Length > 0) cmd += $" WHERE {condition}";
            cmd += ";";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                Console.WriteLine(delimiter1);
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.Write(reader.GetName(i).PadRight(padding));
                Console.WriteLine();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                        Console.Write(reader[i].ToString().PadRight(padding));
                    Console.WriteLine();
                }
                Console.WriteLine(delimiter2);
            }
            reader.Close();
            connection.Close();
        }

        /*public static void Insert(string table, string fields, string values)
        {
            string cmd = $"INSERT {table} ({fields}) VALUES ({values});";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }*/
        public static void Insert(string table, string fields, object[] values)
        {
            //создаем строку для запроса в кой кол полей=кол параметров
            string parameters = string.Join(", ", values.Select((_, index) => $"@param{index}"));
            string cmd = $"INSERT INTO {table} ({fields}) VALUES ({parameters});";
            using (SqlCommand command = new SqlCommand(cmd, connection))
            {
                //добавляю кол-во параметров
                for (int i = 0; i < values.Length; i++)
                {
                    command.Parameters.AddWithValue($"@param{i}", values[i]);
                }
                connection.Open(); // открыл соединение
                command.ExecuteNonQuery();
                connection.Close(); // закрыл соединение
            }
        }





        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}
