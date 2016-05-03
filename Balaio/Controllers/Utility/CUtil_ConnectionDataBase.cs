using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Balaio.Controllers;
using Microsoft.Data.ConnectionUI;
using WeifenLuo.WinFormsUI.Docking;

namespace Balaio.Controllers.Utility
{
    static public class CUtil_ConnectionDataBase
    {
        static public string GetConnectionString()
        {
            string outConnectionString = "";
            if (TryGetDataConnectionStringFromUser(out outConnectionString))
                return outConnectionString;
            else return "";
        }

        static private bool TryGetDataConnectionStringFromUser(out string outConnectionString)
        {
            using (var dialog = new DataConnectionDialog())
            {
                // If you want the user to select from any of the available data sources, do this:
                DataSource.AddStandardDataSources(dialog);

                // OR, if you want only certain data sources to be available
                // (e.g. only SQL Server), do something like this instead: 
                //dialog.DataSources.Add(DataSource.SqlDataSource);
                //dialog.DataSources.Add(DataSource.SqlFileDataSource);

                // The way how you show the dialog is somewhat unorthodox; `dialog.ShowDialog()`
                // would throw a `NotSupportedException`. Do it this way instead:
                DialogResult userChoice = DataConnectionDialog.Show(dialog);

                // Return the resulting connection string if a connection was selected:
                if (userChoice == DialogResult.OK)
                {
                    outConnectionString = dialog.ConnectionString;
                    return true;
                }
                else
                {
                    outConnectionString = null;
                    return false;
                }
            }
        }
    }
}
