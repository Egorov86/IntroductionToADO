using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Academy
{
    public partial class MainForm : Form
    {
        string connectionString;
            SqlConnection connection;
        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Academy"].ConnectionString;
            MessageBox.Show(this, connectionString, "Connection string", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection = new SqlConnection(connectionString);

            LoadStudentsAndGroups();
            //LoadStudent();
        }
        void LoadStudentsAndGroups()
        {
            connection.Open();
            LoadDataTable(dataGridStudents, "SELECT * FROM Students");
            //LoadDataTable(dataGridGroups, "SELECT * FROM Groups");

            connection.Close();
        }
        void LoadDataTable(DataGridView dataGridView, string sqlCommand)
        {
            SqlCommand command = new SqlCommand(sqlCommand, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable table = new DataTable();
                for (int i = 0; i < reader.FieldCount; i++)
                    table.Columns.Add(reader.GetName(i));
                while (reader.Read())
                {
                    DataRow row = table.NewRow();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[i] = reader[i];
                    }
                    table.Rows.Add(row);
                }
                dataGridView.DataSource = table;
            }
        }

        //void LoadStudent();
        /*{
            string cmd = "SELECT * FROM Students";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable table = new DataTable();
                for (int i = 0; i < reader.FieldCount; i++)
                    table.Columns.Add(reader.GetName(i));
                while (reader.Read()) 
                {
                    DataRow row = table.NewRow();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[i] = reader[i];
                    }
                    table.Rows.Add(row);
                }
                dataGridStudents.DataSource = table;

            }
            reader.Close();
            connection.Close();
        }*/
    }
}
