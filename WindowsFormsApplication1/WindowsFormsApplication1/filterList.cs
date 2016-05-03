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
    public partial class filterList : Form
    {
        public ListBox filters;

        public filterList()
        {
            InitializeComponent();

            filters = filterListBox;
            filterListBox.DataSource = side_menu.filters;
        }

        private void removeAllSelectedFilters()
        {
            for (int index = 0; index < filters.SelectedItems.Count; index++)
                side_menu.filters.Remove("" + filters.SelectedItems[index]);
        }

        private void update()
        {
            side_menu.filterDataGridView();
            filters.DataSource = null;
            filters.DataSource = side_menu.filters;
            side_menu.filterValue.ResetText();
        }

        private void groupFilters(String groupType)
        {
            if (filters.SelectedIndex == -1 || filters.SelectedItems.Count < 2)
            {
                MessageBox.Show("Select two or more filters to group");
                return;
            }

            String group = "(" + filters.SelectedItems[0];
            for (int index = 1; index < filters.SelectedItems.Count; index++)
                group += " " + groupType + " " + filters.SelectedItems[index];
            group += ")";

            removeAllSelectedFilters();

            side_menu.filters.Add(group);
            update();
        }

        private void filterList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void removeFilterButton_Click(object sender, EventArgs e)
        {
            if (filters.SelectedIndex == -1)
            {
                MessageBox.Show("Select a filter to remove");
                return;
            }

            removeAllSelectedFilters();

            update();
        }

        private void groupAndButton_Click(object sender, EventArgs e)
        {
            groupFilters("AND");
        }

        private void groupOrButton_Click(object sender, EventArgs e)
        {
            groupFilters("OR");
        }
    }
}
