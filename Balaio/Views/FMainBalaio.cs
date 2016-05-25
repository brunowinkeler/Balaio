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
using Balaio.Controllers.Utility;

namespace Balaio.Views
{
    public partial class FMainBalaio : Form
    {

        #region Attributes

        private FConfigServer fconfig;
        private FDataBaseManipulation fdata;
        private FTreeViewTables Ftables;

        private FLoadConfig fload;
        private FAbout fabout;

        private CControlData dataControl;

        #endregion


        #region Constructor

        public FMainBalaio()
        {
            InitializeComponent();

            var theme = new VS2012LightTheme();
            //var theme = new VS2013BlueTheme();
            this.dockPanelMain.Theme = theme;

            dataControl = new CControlData();

        }

        #endregion


        #region Properties

        public DockPanel MainDock
        {
            get { return dockPanelMain; }
        }

        #endregion


        public void iniForms()
        {
            fdata = new FDataBaseManipulation(dataControl);
            fdata.Show(MainDock, WeifenLuo.WinFormsUI.Docking.DockState.Document);

            fconfig = new FConfigServer(dataControl);
            fconfig.Show(MainDock, WeifenLuo.WinFormsUI.Docking.DockState.DockRight);

            Ftables = new FTreeViewTables(dataControl);
            Ftables.Show(MainDock, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);
        }

        #region Events

        #region ToolStripMenu

        private void newConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string conn = CUtil_ConnectionDataBase.GetConnectionString();
            if (dataControl.TestConnection(conn))
            {
                iniForms();
                dataControl.SaveConnection(conn);
            }
            else
            {
                MessageBox.Show("There's no connection!", "Connection Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fload = new FLoadConfig(dataControl, this);
            fload.ShowDialog();
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fabout = new FAbout();
            fabout.ShowDialog();
        }

        #endregion

        

        

        #endregion

    }
}
