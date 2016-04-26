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

namespace Balaio.Views
{
    public partial class FMainBalaio : Form
    {

        #region Attributes

        private FConfigServer fconfig;

        #endregion


        #region Constructor

        public FMainBalaio()
        {
            InitializeComponent();

            var theme = new VS2012LightTheme();
            this.dockPanelMain.Theme = theme;

            fconfig = new FConfigServer(this);
            fconfig.Show(dockPanelMain, DockState.DockLeftAutoHide);

        }

        #endregion

        #region Properties

        public DockPanel MainDock
        {
            get { return dockPanelMain; }
        }

        #endregion

    }
}
