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
        FDataBaseManipulation fdata;

        #endregion


        #region Properties
        
        public CControlData DataControl
        {
            get { return dataControl; }
        }

        #endregion


        #region Constructor

        public FConfigServer(CControlData c)
        {
            InitializeComponent();

            dataControl = c;
            this.propGridConfig.SelectedObject = dataControl;
            this.Text = "Data Base Configuration from " + dataControl.DataBaseName;
        }

        #endregion


        #region Buttons' Events

        #endregion


        #region Private Methods - User-defined

        #endregion


    }
}
