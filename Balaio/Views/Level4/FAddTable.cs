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

namespace Balaio.Views
{
    public partial class FAddTable : Form
    {
        CControlData dataControl;
        
        public FAddTable(CControlData c)
        {
            InitializeComponent();

            dataControl = c;
            iniDataGridViewColumns();
        }

        private void iniDataGridViewColumns()
        {
            dataGridViewColumns.Columns.Clear();

            DataGridViewTextBoxColumn columnName = new DataGridViewTextBoxColumn();
            columnName.HeaderText = "Column Name";
            columnName.Name = "columnName";

            DataGridViewComboBoxColumn typeOfData = new DataGridViewComboBoxColumn();
            typeOfData.HeaderText = "Type of Data";
            typeOfData.Name = "typeOfData";
            typeOfData.Items.Add("bigint");
            typeOfData.Items.Add("binary(50)");
            typeOfData.Items.Add("bit");
            typeOfData.Items.Add("char(10)");
            typeOfData.Items.Add("date");
            typeOfData.Items.Add("datetime");
            typeOfData.Items.Add("datetime2(7)");
            typeOfData.Items.Add("datetimeoffset(7)");
            typeOfData.Items.Add("decimal(18,0)");
            typeOfData.Items.Add("geography");
            typeOfData.Items.Add("geometry");
            typeOfData.Items.Add("hierarchyid");
            typeOfData.Items.Add("image");
            typeOfData.Items.Add("int");
            typeOfData.Items.Add("money");
            typeOfData.Items.Add("nchar(10)");
            typeOfData.Items.Add("ntext");
            typeOfData.Items.Add("numeric(18,0)");
            typeOfData.Items.Add("nvarchar(50)");
            typeOfData.Items.Add("nvarchar(MAX)");
            typeOfData.Items.Add("real");
            typeOfData.Items.Add("smalldatetime");
            typeOfData.Items.Add("smallint");
            typeOfData.Items.Add("smallmoney");
            typeOfData.Items.Add("sql_variant");
            typeOfData.Items.Add("text");
            typeOfData.Items.Add("time(7)");
            typeOfData.Items.Add("timestamp");
            typeOfData.Items.Add("tinyint");
            typeOfData.Items.Add("uniqueidentifier");
            typeOfData.Items.Add("varbinary(50)");
            typeOfData.Items.Add("varbinary(MAX)");
            typeOfData.Items.Add("varchar(50)");
            typeOfData.Items.Add("varchar(MAX)");
            typeOfData.Items.Add("xml");

            DataGridViewCheckBoxColumn primaryKey = new DataGridViewCheckBoxColumn();
            primaryKey.HeaderText = "Primary Key";
            primaryKey.Name = "primaryKey";
            primaryKey.TrueValue = "true";
            primaryKey.IndeterminateValue = "false";
            primaryKey.FalseValue = "false";
            primaryKey.ThreeState = false;
            primaryKey.ValueType = typeof(string);

            DataGridViewCheckBoxColumn allowNull = new DataGridViewCheckBoxColumn();
            allowNull.HeaderText = "Allow Null";
            allowNull.Name = "allowNull";
            allowNull.TrueValue = "true";
            allowNull.IndeterminateValue = "false";
            allowNull.FalseValue = "false";
            allowNull.ThreeState = false;
            allowNull.ValueType = typeof(string);

            dataGridViewColumns.Columns.Add(columnName);
            dataGridViewColumns.Columns.Add(typeOfData);
            dataGridViewColumns.Columns.Add(primaryKey);
            dataGridViewColumns.Columns.Add(allowNull);

        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butCreateTable_Click(object sender, EventArgs e)
        {
            if (textBoxTableName.Text == "")
            {
                MessageBox.Show("Insert the name of the Table!", "Input Missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(dataGridViewColumns.Rows.Count == 1)
            {
                MessageBox.Show("Add at least one Column!", "Empty Table!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            createTable();
        }

        private void createTable()
        {
            DataTable dt = CUtil_DataGridView.DataGridViewToDataTable(this.dataGridViewColumns);

        }


    }
}
