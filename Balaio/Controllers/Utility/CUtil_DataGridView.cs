using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Balaio.Controllers.Utility
{
    static public class CUtil_DataGridView
    {
        static public DataTable DataGridViewToDataTable(DataGridView dataGrid)
        {
            if (dataGrid == null) return null;

            DataTable dt = new DataTable();

            removeDataGridViewEmptyLines(dataGrid);

            foreach (var itemCol in dataGrid.Columns)
            {
                DataGridViewColumn column = itemCol as DataGridViewColumn;
                DataColumn dataColumn = new DataColumn(column.HeaderText);
                dt.Columns.Add(dataColumn);
            }

            foreach (var item in dataGrid.Rows)
            {
                DataGridViewRow row = item as DataGridViewRow;
                object[] dataRowContent = new object[row.Cells.Count];

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    DataGridViewCell cell = row.Cells[i] as DataGridViewCell;
                    dataRowContent[i] = cell.FormattedValue.ToString();
                }
                dt.Rows.Add(dataRowContent);
            }

            dt.Rows.RemoveAt(dt.Rows.Count - 1); //Removes last line.
            return dt;
        }

        static private void removeDataGridViewEmptyLines(DataGridView dataG)
        {
            foreach (var item in dataG.Rows)
            {
                DataGridViewRow row = item as DataGridViewRow;
                object[] dataRowContent = new object[row.Cells.Count];
                int count = 0;
                int countCheckBox = 0;

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    DataGridViewCell cell = row.Cells[i] as DataGridViewCell;
                    dataRowContent[i] = cell.FormattedValue.ToString();
                    if (cell is DataGridViewCheckBoxCell)
                        countCheckBox++;

                    if (dataRowContent[i] == "")
                        count++;
                }
                
                if (count == (row.Cells.Count - countCheckBox))
                    dataG.Rows.Remove(row);
            }
        }
    }
}
