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
    public partial class side_menu : Form
    {
        public side_menu()
        {
            InitializeComponent();
        }

        private void side_menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'risksDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.risksDataSet.Table);

        }

        private void side_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose(true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            filterList f = new filterList();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            settings s = new settings();
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
