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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            usersConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Users.mdf;Integrated Security=True";
            risksConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Risks.mdf;Integrated Security=True";

            customColors = new Color[] { Color.FromArgb(125, 255, 125), Color.FromArgb(255, 200, 75), Color.FromArgb(255, 255, 125) };

            new login().Show();
            Application.Run();
        }

        public static String usersConnectionString;
        public static String risksConnectionString;
        public static String userInfo;

        public static char fieldSeparationCharacter = ',';

        public static Color[] customColors;

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

        public static void updateComboBox(String connectionString, ComboBox comboBox, String displayMember)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Table]", connectionString);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = displayMember;
        }

        public static String checkNextRevision()
        {
            int index = 0;

            String sqlComm = "SELECT [Next Revision] FROM [Table]";
            if (side_menu.tbs.Filter != null)
                sqlComm += " WHERE " + side_menu.tbs.Filter;

            if (side_menu.rdgv.SortedColumn != null)
            {
                sqlComm += " ORDER BY [" + getColumnName() + "] ";

                switch("" + side_menu.rdgv.SortOrder)
                {
                    case "Ascending": sqlComm += "Asc"; break;
                    case "Descending": sqlComm += "Desc";  break;
                }
            }

            List<String> allRisks = Program.queryDatabase(Program.risksConnectionString, sqlComm);
            List<String> toReviseRiskIds = new List<String>();
            foreach (String risk in allRisks)
            {
                if (Convert.ToDateTime(risk.Split(Program.fieldSeparationCharacter)[0]) <= Convert.ToDateTime(DateTime.Now))
                {
                    side_menu.rdgv.Rows[index].ErrorText = "To revise";
                    toReviseRiskIds.Add(risk.Split(Program.fieldSeparationCharacter)[0]);
                }

                index++;
            }

            String idList = "";
            foreach(String id in toReviseRiskIds)
            {
                idList += id + Program.fieldSeparationCharacter;
            }
            return idList.Trim(Program.fieldSeparationCharacter);
        }

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
