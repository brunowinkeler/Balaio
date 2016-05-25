using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Balaio.Models;
using Balaio.Controllers.Utility;

namespace Balaio.Controllers
{
    public class CControlData
    {

        #region Attributes

        private string strConnection;
        private string serverName;
        private string dataBaseName;
        private string userName;

        private Dictionary<string, string> tablesNamesAndSchemas;

        private CDataAccess dataAccess;

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
        public Dictionary<string,string> TablesNamesAndSchemas
        {
            get { return tablesNamesAndSchemas; }
        }

        #endregion


        #region Constructor

        public CControlData()
        {
            strConnection = "";
            serverName = "";
            dataBaseName = "";
            userName = "";

            dataAccess = new CDataAccess(this);

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

        private void getTablesNamesAndSchemas()
        {
            DataTable tables = dataAccess.GetTablesNames();
            foreach (DataRow item in tables.Rows)
            {
                string tableName = item[tables.Columns.IndexOf("TABLE_NAME")].ToString();
                string tableSchema = item[tables.Columns.IndexOf("TABLE_SCHEMA")].ToString();
                tablesNamesAndSchemas.Add(tableName, tableSchema);
            }
        }

        #endregion


        #region Public Methods - User-defined

        #region TEST CONNECTION

        public bool TestConnection(string conn)
        {
            StringConnection = conn;
            return dataAccess.DataAccessOK;
        }

        #endregion


        #region EXCLUDE

        public void ExcludeTables(List<string> tableNames)
        {
            if (tableNames.Count > 0)
            {
                foreach (var item in tableNames)
                {
                    dataAccess.ExcludeTable(item);
                }
            }
        }

        #endregion


        #region SELECT

        public List<string> GetTablesNamesToList()
        {
            List<string> listTables = new List<string>();
            DataTable tables = dataAccess.GetTablesNames();
            foreach (DataRow item in tables.Rows)
            {
                listTables.Add(item[tables.Columns.IndexOf("TABLE_NAME")].ToString());
            }
            return listTables;
        }

        public DataTable GetTablesNames()
        {
            return dataAccess.GetTablesNames();
        }

        #endregion


        #region CREATE

        public void CreateTable(string tableName, DataTable col)
        {
            if(tableName != "" || tableName != null)
            {
                dataAccess.CreateTable(tableName, col);
            }
        }

        #endregion


        #region SAVE CONNECTION

        public void SaveConnection(string conn)
        {
            if (!CUtil_IO.CompareLineInAFile(CUtil_IO.SavedConnectionsPath, conn))
            {
                List<string> connection = new List<string>();
                connection.Add(conn);
                CUtil_IO.SaveFile(CUtil_IO.SavedConnectionsPath, connection);
            }
        }

        #endregion

        #endregion
    }
}
