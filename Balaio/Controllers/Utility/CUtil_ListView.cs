using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balaio.Controllers.Utility
{
    static public class CUtil_ListView
    {
        static public List<string> getListViewItemsChecked(ListView list)
        {
            List<string> chkItems = new List<string>();
            var checkedItems = list.CheckedItems;
            if (checkedItems.Count > 0)
            {
                foreach (var item in checkedItems)
                {
                    ListViewItem itemList = item as ListViewItem;
                    chkItems.Add(itemList.Text);
                }
            }
            return chkItems;
        }

        static public List<string> getListViewItemsSelected(ListView list)
        {
            List<string> selItems = new List<string>();
            var selectedItems = list.SelectedItems;
            if (selectedItems.Count > 0)
            {
                foreach (var item in selectedItems)
                {
                    ListViewItem itemList = item as ListViewItem;
                    selItems.Add(itemList.Text);
                }
            }
            return selItems;
        }

        
    }
}
