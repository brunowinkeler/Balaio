using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using Balaio.Controllers;

namespace Balaio.Models
{
    public class CDataAccess
    {

        #region Attributes

        private CControlData dataControl;

        #endregion


        #region Properties

        public bool DataAccessOK
        {
            get
            {
                try
                {
                    SqlConnection connection = new SqlConnection(dataControl.StringConnection);
                    connection.Open();
                    connection.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        #endregion


        #region Constructor

        public CDataAccess(CControlData c)
        {
            dataControl = c;
        }

        #endregion


        #region Public Methods - User-defined


        #region Create Methods
        
        public void CreateTable(string tableName, DataTable columns)
        {
            string query = "CREATE TABLE";
        }

        #endregion


        #region Save Methods
        
        #endregion


        #region Select Methods

        public DataTable GetTablesNames()
        {
            return execSelect("select * from " + dataControl.DataBaseName + ".information_schema.tables");
        }
    
        public DataTable GetTableValues(string tableName)
        {
            return execSelect("select * from " + dataControl.DataBaseName + "." + tableName);
        }

        #endregion
            

        #region Exclude Methods

        public int ExcludeTable(string tableName)
        {
            string query = "DROP TABLE " + tableName;
            return execNonQuery(query);
        }


        #endregion


        #endregion


        #region Private Methods - User-defined

        private int execNonQuery(string query)
        {
            try
            {
                SqlConnection conn = this.getConnection();
                conn.Open();
                SqlCommand sqlcmd = new SqlCommand(query, conn);
                int rowsAffected = sqlcmd.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;
            }
            catch
            {
                return 0;
            }
        }

        private SqlConnection getConnection()
        {
            if (dataControl == null) throw new ArgumentNullException();

            SqlConnection connection;
            try
            {
                connection = new SqlConnection(dataControl.StringConnection);
                return connection;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        private DataTable execSelect(String query)
        {
            SqlConnection conn = this.getConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandTimeout = 120;
            cmd.CommandText = query;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            conn.Open();
            da.Fill(ds);
            conn.Close();

            return ds.Tables[0];
        }

        #endregion


    }
}
