using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        // Path to the databases used by this application
        public static String usersConnectionString;
        public static String risksConnectionString;
        
        // Used to keep track of the current user
        public static String userInfo;

        // Used to separate each column of a single row of data from a database query.
        public static char fieldSeparationCharacter = ',';

        // Colors used as backcolor for the risk table header groups.
        public static Color[] customColors;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // References the users/risks databases in the current directory
            usersConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Users.mdf;Integrated Security=True";
            risksConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Risks.mdf;Integrated Security=True";

            customColors = new Color[] { Color.FromArgb(125, 255, 125), Color.FromArgb(255, 200, 75), Color.FromArgb(255, 255, 125) };

            new login().Show();
            Application.Run();
        }

        // Used to query a given database and return the results in a String List, each index defining a row.
        public static List<String> queryDatabase(String connectionString, String sqlComm)
        {
            try
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

                            queryResults.Add(currentRow.Trim(fieldSeparationCharacter));
                        }
                    }
                }

                return queryResults;
            }
            catch(System.Data.SqlClient.SqlException)
            {
                return null;
            }
        }

        // Used to modify a given database. Returns true if the database has been modified.
        public static bool editDatabase(String connectionString, String sqlComm)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlComm, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                return false;
            }
        }

        // Updates the given DataGridView and BindingSource using the given database.
        public static void updateDataGridView(String connectionString, DataGridView dataGridView, BindingSource bindingSource)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Table]", connectionString);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
            dataGridView.DataSource = dataTable;

            if(side_menu.userType.Equals("Admin"))
                checkNextRevision();
        }

        // Updates the given ComboBox using the given database and the given String representing the DisplayMember property.
        public static void updateComboBox(String connectionString, ComboBox comboBox, String displayMember)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Table]", connectionString);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = displayMember;
        }

        // Checks the entire risks database for due revisions.
        public static String checkNextRevision()
        {
            int index = 0;

            // Build the appropriate SQL command to match the data displayed in the risks table.
            String sqlComm = "SELECT [ID], [Next Revision] FROM [Table]";
            if (side_menu.tbs.Filter != null)
                sqlComm += " WHERE " + side_menu.tbs.Filter; // Apply the filters.

            if (side_menu.rdgv.SortedColumn != null)
            {
                sqlComm += " ORDER BY [" + getColumnName() + "] "; // Apply the sorting.

                // Convert the Strings to appropriate SQL keywords.
                switch("" + side_menu.rdgv.SortOrder)
                {
                    case "Ascending": sqlComm += "Asc"; break;
                    case "Descending": sqlComm += "Desc";  break;
                }
            }

            List<String> allRisks = Program.queryDatabase(Program.risksConnectionString, sqlComm); // Get the data.
            List<String> toReviseRiskIds = new List<String>(); // The data that are to be revised.
            foreach (String risk in allRisks)
            {
                if (Convert.ToDateTime(risk.Split(Program.fieldSeparationCharacter)[1]) <= Convert.ToDateTime(DateTime.Now))
                {
                    // Visual cues highlighting the need to review
                    side_menu.rdgv.Rows[index].ErrorText = "To revise";
                    toReviseRiskIds.Add(risk.Split(Program.fieldSeparationCharacter)[0]);
                }

                index++;
            }

            // Return the IDs of the risks to revise.
            String idList = "";
            foreach(String id in toReviseRiskIds)
            {
                idList += id + Program.fieldSeparationCharacter;
            }
            return idList.Trim(Program.fieldSeparationCharacter);
        }

        // Gets the appropriate column name for the database from the risksDataGridView.
        private static String getColumnName()
        {
            switch (side_menu.rdgv.SortedColumn.Name)
            {
                case "NextRevision": return "Next Revision";
                case "ControlMeasure": return "Control Measure";
                case "ResponsiblePerson": return "Responsible Person";
                case "ProbabilityAfter": return "Probability After";
                case "ConsequenceAfter": return "Consequence After";
                case "StatusAfter": return "Status After";
                case "EvaluationAfter": return "Evaluation After";
                default: return side_menu.rdgv.SortedColumn.Name;
            }
        }
    }
}
