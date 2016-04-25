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
    public partial class editRisks : Form
    {
        public editRisks()
        {
            InitializeComponent();
        }

        private void addRiskButton_Click(object sender, EventArgs e)
        {

        }

        private void editRisks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'risksDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.risksDataSet.Table);

        }
    }
}
