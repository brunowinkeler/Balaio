using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace Balaio.Controllers.Utility
{
    static public class CUtil_IO
    {
        static public string[] loadFile(string filename)
        {
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                return lines;
            }
            else
                return null;
        }

        public static void WriteDataTableToFile(DataTable submittedDataTable, string submittedFilePath)
        {
            int i = 0;
            StreamWriter sw = null;
            sw = new StreamWriter(submittedFilePath, false);

            for (i = 0; i < submittedDataTable.Columns.Count - 1; i++)
            {
                sw.Write(submittedDataTable.Columns[i].ColumnName + ";");
            }

            sw.Write(submittedDataTable.Columns[i].ColumnName);
            sw.WriteLine();

            foreach (DataRow row in submittedDataTable.Rows)
            {
                object[] array = row.ItemArray;

                for (i = 0; i < array.Length - 1; i++)
                {
                    sw.Write(array[i].ToString() + ";");
                }

                sw.Write(array[i].ToString());
                sw.WriteLine();
            }
            sw.Close();
        }
    }
}
