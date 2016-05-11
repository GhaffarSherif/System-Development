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
        // The ListBox which displays all the filters.
        public ListBox filters;

        public filterList()
        {
            InitializeComponent();

            filters = filterListBox;
            filterListBox.DataSource = side_menu.filters;
        }

        // Removes all selected filters.
        private void removeAllSelectedFilters()
        {
            Program.updateDataGridView(Program.risksConnectionString, side_menu.rdgv, side_menu.tbs);

            for (int index = 0; index < filters.SelectedItems.Count; index++)
                side_menu.filters.Remove("" + filters.SelectedItems[index]);
        }

        // Updates the filters ListBox.
        private void update()
        {
            side_menu.filterDataGridView();
            filters.DataSource = null;
            filters.DataSource = side_menu.filters;
            side_menu.filterValue.ResetText();
            Program.checkNextRevision();
        }

        // Groups the filters in either an OR or AND corelation.
        private void groupFilters(String groupType)
        {
            Program.updateDataGridView(Program.risksConnectionString, side_menu.rdgv, side_menu.tbs);

            // Checks if at least two filters are selected.
            if (filters.SelectedIndex == -1 || filters.SelectedItems.Count < 2)
            {
                MessageBox.Show("Select two or more filters to group", "Could not group filters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Groups the filters with an OR or AND into a String.
            String group = "(" + filters.SelectedItems[0];
            for (int index = 1; index < filters.SelectedItems.Count; index++)
                group += " " + groupType + " " + filters.SelectedItems[index];
            group += ")";

            // Removes the selected filters.
            removeAllSelectedFilters();

            // Adds the new compound filter.
            side_menu.filters.Add(group);
            update();
        }

        private void filterList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void removeFilterButton_Click(object sender, EventArgs e)
        {
            // Checks if at least one filter is selecte.
            if (filters.SelectedIndex == -1)
            {
                MessageBox.Show("Select a filter to remove", "Could not remove filter", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
