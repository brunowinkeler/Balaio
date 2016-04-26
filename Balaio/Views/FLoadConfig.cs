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

namespace Balaio.Views
{
    public partial class FLoadConfig : Form
    {

        private FConfigServer parent;

        public FLoadConfig(FConfigServer p)
        {
            InitializeComponent();

            parent = p;

            iniListViewLoad();

        }

        private string[] loadConfigFile()
        {
            string filename = Directory.GetCurrentDirectory() + "/SavedConfig.txt";
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                return lines;
            }
            else
                return null;
        }

        private void iniListViewLoad()
        {
            listViewLoad.Columns.Clear();
            listViewLoad.Items.Clear();

            listViewLoad.Columns.Add("Server");
            listViewLoad.Columns.Add("DataBase");
            
            string[] configs = loadConfigFile();
            if(configs != null)
            {
                string server = "";
                string database = "";
                foreach (var item in configs)
                {
                    string[] split = item.Split(';');
                    foreach (var item2 in split)
                    {
                        if(item2.Contains("Server"))
                        {
                            server = item2.Split('=').Last();
                        }
                        else if(item2.Contains("Database"))
                        {
                            database = item2.Split('=').Last();
                        }
                    }

                    if (server != "")
                    {
                        ListViewItem it = new ListViewItem(server);
                        it.SubItems.Add(database);

                        listViewLoad.Items.Add(it);
                    }
                }
            }
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if(listViewLoad.SelectedItems != null)
            {

            }
        }

        private void butLoad_Click(object sender, EventArgs e)
        {

        }
    }
}
