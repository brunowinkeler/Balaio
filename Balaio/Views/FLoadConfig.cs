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

namespace Balaio.Views
{
    public partial class FLoadConfig : Form
    {

        #region Attributes

        private FConfigServer parent;

        #endregion


        #region Constructor

        public FLoadConfig(FConfigServer p)
        {
            InitializeComponent();

            parent = p;

            iniListViewLoad();

        }

        #endregion


        #region Private Methods - User-defined

        private void iniListViewLoad()
        {
            listViewLoad.Columns.Clear();
            listViewLoad.Items.Clear();

            listViewLoad.Columns.Add("Server");
            listViewLoad.Columns.Add("DataBase");

            string filename = Directory.GetCurrentDirectory() + "/SavedConfig.txt";
            string[] configs = CUtil_IO.loadFile(filename);
            if (configs != null)
            {
                auxIniListViewLoad(configs);
            }
        }

        private void auxIniListViewLoad(string[] configs)
        {
            string server = "";
            string database = "";
            foreach (var item in configs)
            {
                string[] split = item.Split(';');
                foreach (var item2 in split)
                {
                    if (item2.Contains("Server"))
                    {
                        server = item2.Split('=').Last();
                    }
                    else if (item2.Contains("Database"))
                    {
                        database = item2.Split('=').Last();
                    }
                }

                if (server != "" && database != "")
                {
                    ListViewItem it = new ListViewItem(server);
                    it.SubItems.Add(database);

                    listViewLoad.Items.Add(it);
                }
            }
        }

        #endregion


        #region Buttons' Events

        private void butSave_Click(object sender, EventArgs e)
        {
            if (listViewLoad.SelectedItems != null)
            {

            }
        }

        private void butLoad_Click(object sender, EventArgs e)
        {

        }

        #endregion
        
    }
}
