using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Balaio.Models;

namespace Balaio.Controllers
{
    public class CControlData
    {

        #region Attributes

        private string strConnection;
        private string tablesSchema;
        private string serverName;
        private string dataBaseName;
        private string userName;

        private CDataAccess cdata;

        #endregion


        #region Properties

        [Browsable(false)]
        public string StringConnection
        {
            get { return strConnection; }
            set
            {
                if(strConnection != value)
                {
                    strConnection = value;
                    updateAttr();
                }
            }
        }

        [Category("Data Base")]
        [DisplayName("Data Source")]
        [Description("Server's name of SLQ Server.")]
        [ReadOnly(true)]
        public string ServerName
        {
            get { return serverName; }
        }

        [Category("Data Base")]
        [DisplayName("Initial Catalog")]
        [Description("Data Base's name of SQL Server.")]
        [ReadOnly(true)]
        public string DataBaseName
        {
            get { return dataBaseName; }
        }

        [Category("Data Base")]
        [DisplayName("User ID")]
        [Description("User's name of SQL Server.")]
        [ReadOnly(true)]
        public string UserName
        {
            get { return userName; }
        }

        [Browsable(false)]
        public string TablesSchema
        {
            get { return tablesSchema; }
        }

        #endregion


        #region Constructor

        public CControlData()
        {
            strConnection = "";
            serverName = "";
            dataBaseName = "";
            userName = "";

            cdata = new CDataAccess(this);
        }

        #endregion


        #region Private Methods - User-Defined

        private void updateAttr()
        {
            if (strConnection != null)
            {
                string[] conn = strConnection.Split(';');
                foreach (var item in conn)
                {
                    string[] aux = item.Split('=');
                    if (item.Contains("Data Source"))
                    {
                        serverName = aux.Last();
                    }
                    else if (item.Contains("Initial Catalog"))
                    {
                        dataBaseName = aux.Last();
                    }
                    else if (item.Contains("User ID"))
                    {
                        userName = aux.Last();
                    }
                }
            }
        }

        #endregion


        #region Public Methods - User-defined

        #region TEST CONNECTION

        public bool TestConnection(string conn)
        {
            StringConnection = conn;
            return cdata.DataAccessOK;
        }

        #endregion


        #region EXCLUDE

        public void ExcludeTables(List<string> tableNames)
        {
            if (tableNames.Count > 0)
            {
                foreach (var item in tableNames)
                {
                    cdata.ExcludeTable(item);
                }
            }
        }

        #endregion


        #region SELECT

        public List<string> GetTablesNamesToList()
        {
            List<string> listTables = new List<string>();
            DataTable tables = cdata.GetTablesNames();
            foreach (DataRow item in tables.Rows)
            {
                listTables.Add(item[tables.Columns.IndexOf("TABLE_NAME")].ToString());
            }
            return listTables;
        }

        public DataTable GetTablesNames()
        {
            return cdata.GetTablesNames();
        }

        #endregion


        #region CREATE

        public void CreateTable(string tableName, DataTable col)
        {
            if(tableName != "" || tableName != null)
            {
                cdata.CreateTable(tableName, col);
            }
        }

        #endregion

        #endregion

    }
}
