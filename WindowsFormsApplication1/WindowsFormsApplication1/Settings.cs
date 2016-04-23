using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();

            userTypeComboBox.SelectedIndex = 1;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.usersDataSet.Table);

        }

        private void settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose(true);
        }
    }
}
