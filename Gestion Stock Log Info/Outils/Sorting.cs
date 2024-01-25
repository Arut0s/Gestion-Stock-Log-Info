
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStockLogInfo.outils
{
    /// <summary>
    /// Classe permet de trier la listview en fonction des colonnes
    /// </summary>
    class ListViewItemComparer : IComparer
    {
        public SortOrder Order = SortOrder.Ascending;
        public int Column;

        public ListViewItemComparer()
        {
            Column = 0;
        }
        public ListViewItemComparer(int column)
        {
            Column = column;
        }
        public int Compare(object x, object y)
        {
            if (Column == 6)
            {
                int returnVal = DateTime.Compare(DateTime.Parse(((ListViewItem)x).SubItems[Column].Text),
               DateTime.Parse(((ListViewItem)y).SubItems[Column].Text));

                if (Order == SortOrder.Descending)
                    return -returnVal;
                else
                    return returnVal;
            }
            else
            {

                int returnVal = String.Compare(((ListViewItem)x).SubItems[Column].Text,
                ((ListViewItem)y).SubItems[Column].Text);

                if (Order == SortOrder.Descending)
                    return -returnVal;
                else
                    return returnVal;
            }
        }
    }
}
