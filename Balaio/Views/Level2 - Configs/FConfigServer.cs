using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Balaio.Controllers;
using Microsoft.Data.ConnectionUI;
using WeifenLuo.WinFormsUI.Docking;

namespace Balaio.Views
{
    public partial class FConfigServer : DockContent
    {

        #region Attributes

        CControlData dataControl;
        FMainBalaio parent;
        FDataBaseManipulation fdata;

        #endregion


        #region Properties
        
        public CControlData DataControl
        {
            get { return dataControl; }
        }

        #endregion


        #region Constructor

        public FConfigServer(FMainBalaio p)
        {
            InitializeComponent();

            dataControl = new CControlData();
            parent = p;
        }

        #endregion


        #region Buttons' Events

        private void butConfig_Click(object sender, EventArgs e)
        {
            string outConnectionString = "";
            if (TryGetDataConnectionStringFromUser(out outConnectionString))
            {
                if (!dataControl.TestConnection(outConnectionString))
                    MessageBox.Show("There's no connection!");
                else
                {
                    fdata = new FDataBaseManipulation(dataControl);
                    fdata.Show(parent.MainDock, WeifenLuo.WinFormsUI.Docking.DockState.Document);
                }
                this.propGridConfig.SelectedObject = dataControl;
            }
            else
                dataControl.StringConnection = null;
        }

        private void butLoadSave_Click(object sender, EventArgs e)
        {

        }


        #endregion


        #region Private Methods - User-defined

        private bool TryGetDataConnectionStringFromUser(out string outConnectionString)
        {
            using (var dialog = new DataConnectionDialog())
            {
                // If you want the user to select from any of the available data sources, do this:
                //DataSource.AddStandardDataSources(dialog);

                // OR, if you want only certain data sources to be available
                // (e.g. only SQL Server), do something like this instead: 
                dialog.DataSources.Add(DataSource.SqlDataSource);
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

        #endregion


    }
}
