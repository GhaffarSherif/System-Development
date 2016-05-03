using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication1
{
    class exportMethods
    {
        public static void exportExcel(String fileName)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range xlRange;
            object missingValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(missingValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            int i = 0;
            int j = 0;

            for (int index = 0; index < side_menu.rdgv.ColumnCount; index++ )
            {
                xlWorkSheet.Cells[1, index + 1] = side_menu.rdgv.Columns[index].HeaderText;
            }

            for (i = 0; i <= side_menu.rdgv.RowCount - 1; i++)
            {
                for (j = 0; j <= side_menu.rdgv.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = side_menu.rdgv[j, i];
                    xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                }
            }

            xlRange = xlWorkSheet.get_Range("A1", "P" + j);
            xlRange.Columns.AutoFit();
            xlWorkBook.SaveAs(fileName + ".xls", Excel.XlFileFormat.xlWorkbookNormal, missingValue, missingValue, missingValue, missingValue, Excel.XlSaveAsAccessMode.xlExclusive, missingValue, missingValue, missingValue, missingValue, missingValue);
            xlWorkBook.Close(true, missingValue, missingValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file in " + fileName + ".xls");
        }

        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}
