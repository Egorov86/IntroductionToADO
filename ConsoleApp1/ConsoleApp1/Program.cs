#define PRINT_AUTHORS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            Console.WriteLine(connectionString);
            Console.WriteLine("\n----------------------------\n");

            SqlConnection connection = new SqlConnection(connectionString);  // подключаемся к серверу SqlConnection connection 
            string cmd = "SELECT * FROM Authors";  // формируем команду cmd выбираем авторов
            SqlCommand command = new SqlCommand(cmd, connection);  //чтобы получать данные с базы  1 параметр cmd -текст команлы 
            //connection - 2 параметр
            connection.Open(); //открыли соединение

            SqlDataReader reader = command.ExecuteReader(); //считать данные из базы SqlDataReader
            const int padding = 24;
            //reader возвращает сложную коллекцию объектов
            for(int i = 0;i < reader.FieldCount; i++) 
            {
                Console.Write(reader.GetName(i).PadRight(padding)+"\t");
            }
            Console.WriteLine();
            
            if (!reader.IsClosed)
            {
                while (reader.Read())
                {
                    for(int i = 0; i < reader.FieldCount; i++) 
                    {
                        Console.Write(reader[i].ToString().PadRight(padding) +"\t");
                    }
                    Console.WriteLine();
                }
            }
            
            reader.Close();
            //connection.Close(); 
            connection.Close(); //закрыли соединение

            Console.WriteLine("\n-===========================================-\n");

            command.CommandText = "SELECT book_title,first_name+' '+last_name AS 'Authors'" +
                "FROM Books JOIN Authors ON (author=author_id)";
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.Write(reader.GetName(i).PadRight(padding+4));
                Console.WriteLine();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i].ToString().PadRight(padding+4));
                    }
                    Console.WriteLine();
                }
            }
            reader.Close();
            connection.Close();
            Console.WriteLine("\n-===========================================-\n");
            ////////////////////////////////////////////////////////////////////////

            command.CommandText = 
                "SELECT  first_name+' '+last_name AS 'Author', COUNT(book_id) AS 'Books count'" +
                "FROM Books JOIN Authors ON (author=author_id)" +
                "GROUP BY first_name, last_name";
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.HasRows) 
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.Write(reader.GetName(i).PadRight(padding));
                Console.WriteLine();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i].ToString().PadRight(padding));
                    }
                    Console.WriteLine();
                }
            }
            connection.Close();



            /*SqlConnection connection_1 = new SqlConnection(connectionString);
            string cmd_1 = "SELECT * FROM Books";
            SqlCommand command_1 = new SqlCommand(cmd_1, connection_1);
            connection_1.Open();
            SqlDataReader reader_1 = command_1.ExecuteReader(); //считать данные из базы SqlDataReader
            for (int i = 0; i < 2; i++)
            {
                Console.Write(reader_1.GetName(i).PadRight(padding+2) + "\t");
            }
            Console.WriteLine();
            if (!reader_1.IsClosed)
            {
                while (reader_1.Read())
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Console.Write(reader_1[i].ToString().PadRight(padding) + "\t");
                    }
                    Console.WriteLine();
                }
            }

            reader_1.Close();
            connection_1.Close();*/
            /*SqlDataReader = command.ExecuteScalarReader();
            /*string countBooksCmd = "SELECT COUNT(*) FROM Books WHERE AuthorId = @AuthorId";
            SqlCommand countBooksCommand = new SqlCommand(countBooksCmd, connection);
            connection.Open();
            Console.WriteLine();*/
        }
    }
}
