using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Balaio.Controllers.Utility;
using Balaio.Controllers;

namespace Balaio.Views
{
    public partial class FLoadConfig : Form
    {

        #region Attributes
        private FMainBalaio parent;
        private CControlData dataControl;
        private string[] configs;
        #endregion


        #region Constructor

        public FLoadConfig(CControlData c, FMainBalaio p)
        {
            InitializeComponent();

            parent = p;
            dataControl = c;

            iniListViewLoad();
        }

        #endregion


        #region Private Methods - User-defined

        private void iniListViewLoad()
        {
            listViewLoad.Items.Clear();
            listViewLoad.FullRowSelect = true;

            configs = CUtil_IO.LoadFile(CUtil_IO.SavedConnectionsPath);
            if (configs != null)
                auxIniListViewLoad(configs);
        }

        private void auxIniListViewLoad(string[] configs)
        {
            string dataSource = "";
            string initialCatalog = "";
            string integratedSecurity = "";
            string userID = "";

            foreach (var item in configs)
            {
                string[] split = item.Split(';');
                foreach (var item2 in split)
                {
                    if (item2.Contains("Data Source"))
                    {
                        dataSource = item2.Split('=').Last();
                    }
                    else if (item2.Contains("Initial Catalog"))
                    {
                        initialCatalog = item2.Split('=').Last();
                    }
                    else if(item2.Contains("User ID"))
                    {
                        userID = item2.Split('=').Last();
                        integratedSecurity = "false";
                    }
                    else if (item2.Contains("Integrated Security"))
                    {
                        integratedSecurity = item2.Split('=').Last();
                        userID = "";
                    }
                }

                ListViewItem it = new ListViewItem(dataSource);
                it.SubItems.Add(initialCatalog);
                it.SubItems.Add(integratedSecurity);
                it.SubItems.Add(userID);

                listViewLoad.Items.Add(it);

            }
            listViewLoad.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        #endregion


        #region Buttons' Events

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butLoad_Click(object sender, EventArgs e)
        {
            //----------------------------------
            Cursor.Current = Cursors.WaitCursor;
            //----------------------------------

            foreach (var item in listViewLoad.Items)
            {
                ListViewItem it = item as ListViewItem;
                if(it.Checked)
                {
                    string conn = configs[it.Index];

                    if (dataControl.TestConnection(conn))
                        parent.iniForms();
                    else
                        MessageBox.Show("There's no connection!", "Connection Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //----------------------------------
                    Cursor.Current = Cursors.Default;
                    //----------------------------------

                    this.Close();
                }
            }
        }

        #endregion


        #region Events - ListView
        private void listViewLoad_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            foreach (var item in listViewLoad.Items)
            {
                ListViewItem lstIt = item as ListViewItem;
                if (lstIt != e.Item)
                {
                    lstIt.Checked = false;
                }
            }
        }

        #endregion

    }
}
