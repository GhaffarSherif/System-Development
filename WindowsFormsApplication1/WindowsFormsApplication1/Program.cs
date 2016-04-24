using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new login().Show();
            Application.Run();
        }

        public static String usersConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"C:\\Users\\Graal\\Desktop\\Team Project\\System-Development\\WindowsFormsApplication1\\WindowsFormsApplication1\\Users.mdf\";Integrated Security=True";
        public static String userInfo;

        public static List<String> queryDatabase(String connectionString, String sqlComm)
        {
            List<String> queryResults = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlComm, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String currentRow = "";

                        for (int index = 0; index < reader.FieldCount; index++)
                            currentRow += reader.GetString(index) + ":";

                        queryResults.Add(currentRow);
                    }
                }
            }

            return queryResults;
        }

        public static void editUsersDatabase(String connectionString, String sqlComm)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlComm, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void updateDataGridView(String connectionString, DataGridView dataGridView)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Table]", connectionString);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }

        public static void updateComboBox(String connectionString, ComboBox comboBox)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Table]", connectionString);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = "Username";
        }
    }
}
