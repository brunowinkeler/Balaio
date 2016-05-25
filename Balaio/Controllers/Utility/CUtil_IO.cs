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
        static public string SavedConnectionsPath = Directory.GetCurrentDirectory() + "/SavedConfig.txt";
        
        static public string[] LoadFile(string filepath)
        {
            if (File.Exists(filepath))
            {
                string[] lines = File.ReadAllLines(filepath);
                return lines;
            }
            else
                return null;
        }

        static public void WriteDataTableToFile(DataTable submittedDataTable, string submittedFilePath)
        {
            int i = 0;
            StreamWriter sw = new StreamWriter(submittedFilePath, false);

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

        static public bool SaveFile(string filepath, List<string> lines = null)
        {
            if (!File.Exists(filepath))
                File.Create(filepath);

            try
            {
                File.AppendAllLines(filepath, lines);
                return true;
            }
            catch
            {
                return false;
            }
        }

        static public bool CompareLineInAFile(string filepath, string line)
        {
            if (!File.Exists(filepath))
                return false;

            try
            {
                List<string> lines = File.ReadLines(filepath).ToList();
                foreach (var item in lines)
                {
                    if (string.Compare(item,line,true) == 0)
                        return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
