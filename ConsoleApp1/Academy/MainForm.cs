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
using Academy;

namespace Academy
{
    public partial class MainForm : Form
    {
        string connectionString;
        SqlConnection connection;

        Dictionary<string, int> d_groups_direction;
        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Academy"].ConnectionString;
            //MessageBox.Show(this, connectionString, "Connection string", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection = new SqlConnection(connectionString);

            //LoadStudentsAndGroups();
            LoadStudent();
            LoadGroups();
            LoadDerictions();
        }
       /* void LoadStudentsAndGroups()
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
        }*/

        void LoadStudent()
        {

            dataGridStudents.DataSource = Connector.LoadData
                (
                     "last_name AS N'Фамилия'," +
                     "first_name AS N'имя', " +
                     "ISNULL(middle_name, N'') AS N'Отчество', " +
                     "CONVERT(NVARCHAR, birth_date, 104) AS N'Дата рождения'," +
                     "DATEDIFF(DAY,birth_date,GETDATE())/365 AS N'Возраст', " +
                     "group_name AS N'Группа' ",
                     "Students,Groups",
                     "[group]=group_id"
                );
            tslStudentsCount.Text = $"Количество студентов: {dataGridStudents.RowCount - 1}";
            //dataGridStudents.Columns["Дата рождения"].ValueType = 
            #region Loading
            //string cmd = "SELECT * FROM Students";
            //SqlCommand command = new SqlCommand(cmd, connection);
            //connection.Open();
            //SqlDataReader reader = command.ExecuteReader();

            //if (reader.HasRows)
            //{
            //    DataTable table = new DataTable();
            //    for (int i = 0; i < reader.FieldCount; i++)
            //        table.Columns.Add(reader.GetName(i));
            //    while (reader.Read()) 
            //    {
            //        DataRow row = table.NewRow();
            //        for (int i = 0; i < reader.FieldCount; i++)
            //        {
            //            row[i] = reader[i];
            //        }
            //        table.Rows.Add(row);
            //    }
            //    dataGridStudents.DataSource = table;

            //}
            //reader.Close();
            //connection.Close(); 
            #endregion
        }
        void LoadGroups()
        {
            dataGridViewGroups.DataSource = Connector.LoadData
               (
                    "group_id AS 'ID', group_name AS N'Название группы', direction_name AS N'Направление обучения'",
                    "Groups,Directions",
                    "direction = direction_id"
               );
            tslGroupsCount.Text = $"Количество групп: {dataGridViewGroups.RowCount-1}";
        }
        void LoadDerictions()
        {
            //DataTable dt_directions = Connector.LoadData("direction_id, direction_name," "Direction");
            //cbGroupsDirection.Items.AddRange(dt_directions);
            d_groups_direction = Connector.LoadPair("direction_name", "direction_id", "Directions");
            cbGroupsDirection.Items.AddRange(d_groups_direction.Keys.ToArray());
            cbGroupsDirection.Items.Insert(0, "Все");
            cbGroupsDirection.SelectedIndex = 0;
        }

        private void cbGroupsDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroupsDirection.SelectedIndex == 0) LoadGroups();
            else
                dataGridViewGroups.DataSource = Connector.LoadData
                (
                     "group_id, group_name, direction_name",
                     "Groups,Directions",
                     $"direction=direction_id AND direction={d_groups_direction[cbGroupsDirection.SelectedItem.ToString()]}"
                );
            tslGroupsCount.Text = $"Количество групп: {(dataGridViewGroups.RowCount == 0 ? 0 : dataGridViewGroups.RowCount - 1)}";
        }
    }
}
