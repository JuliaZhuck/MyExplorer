using System;
using System.Collections;
using System.Windows.Forms;


namespace MyExplorer
{
    class ListItemsComparer : IComparer
    {
        public enum ListItemCompareType
        {
            /*byName,*/ bySize, byChanged
        }

        private ListItemCompareType compareType;
        private int columnNumber = 0;
        private bool sortAcend;

        public ListItemsComparer(ListItemCompareType compType, int col, bool sortAcending)
        {
            this.compareType = compType;
            this.columnNumber = col;
            this.sortAcend = sortAcending;
        }

        public int Compare(object x, object y)
        {
            ListViewItem itemX = null, itemY = null;
            if (sortAcend)
            {
                itemX = x as ListViewItem;
                itemY = y as ListViewItem;
            }
            else
            {
                itemX = y as ListViewItem;
                itemY = x as ListViewItem;
            }
            switch (compareType)
            {
                //case ListItemCompareType.byName:
                //   return String.Compare (itemX.SubItems[columnNumber].Text, 
                //      itemY.SubItems[columnNumber].Text);
                case ListItemCompareType.bySize:
                   {
                       int sizeX = -1, sizeY = -1;
                       if (itemX.SubItems[columnNumber].Text != "")
                           sizeX = Int32.Parse(itemX.SubItems[columnNumber].Text);
                       if (itemY.SubItems[columnNumber].Text != "")
                          sizeY = Int32.Parse(itemY.SubItems[columnNumber].Text);
                       return sizeX.CompareTo(sizeY);
                   }
                case ListItemCompareType.byChanged:
                    return DateTime.Compare (DateTime.Parse (itemX.SubItems[columnNumber].Text), 
                      DateTime.Parse (itemY.SubItems[columnNumber].Text));
                default:
                    return 0;
            }
        }
    }
}
