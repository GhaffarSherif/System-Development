using System;
using System.Collections.Generic;
using System.Configuration;
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

            usersConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.UsersConnectionString"].ConnectionString;
            risksConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.RisksConnectionString"].ConnectionString;

            new login().Show();
            Application.Run();
        }

        public static String usersConnectionString;
        public static String risksConnectionString;
        public static String userInfo;

        public static char fieldSeparationCharacter = ',';

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
                            currentRow += "" + reader.GetValue(index) + fieldSeparationCharacter;

                        queryResults.Add(currentRow);
                    }
                }
            }

            return queryResults;
        }

        public static void editDatabase(String connectionString, String sqlComm)
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
