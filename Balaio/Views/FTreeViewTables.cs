using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI.Docking;
using Balaio.Controllers;

namespace Balaio.Views
{
    public partial class FTreeViewTables : DockContent
    {
        private CControlData dataControl;

        public FTreeViewTables(CControlData c)
        {
            InitializeComponent();

            dataControl = c;
            iniTreeViewTables();
            this.Text = "Tables from " + dataControl.DataBaseName;
        }

        private void iniTreeViewTables()
        {
            List<string> listTables = dataControl.GetTablesNamesToList();
            listTables.Sort();
            treeViewTables.Nodes.Clear();
            foreach (var item in listTables)
            {
                treeViewTables.Nodes.Add(item);
            }

        }
    }
}
