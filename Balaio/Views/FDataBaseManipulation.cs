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
using Balaio.Controllers.Utility;

using WeifenLuo.WinFormsUI.Docking;

namespace Balaio.Views
{
    public partial class FDataBaseManipulation : DockContent
    {
        #region Attributes

        CControlData dataControl;

        #endregion


        #region Constructor

        public FDataBaseManipulation(CControlData c)
        {
            InitializeComponent();
            dataControl = c;
            this.Text = "Data Tables from " + dataControl.DataBaseName;

            iniDataGridTable();
        }

        #endregion


        #region Private Methods - User-defined

        private void iniDataGridTable()
        {
            DataTable dt = dataControl.GetTablesNames();
            dataGridTable.DataSource = dt;
        }


        #endregion


        #region Buttons' Events

        private void butDeleteTable_Click(object sender, EventArgs e)
        {
            //dataControl.ExcludeTables(CUtil_ListView.getListViewItemsChecked(this.listViewTables));
            iniDataGridTable();
        }

        private void butAddTable_Click(object sender, EventArgs e)
        {
            FAddTable fadd = new FAddTable(dataControl);
            fadd.ShowDialog();
        }

        #endregion


    }
}
