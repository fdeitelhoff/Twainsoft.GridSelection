using System;

namespace Twainsoft.GridSelection {

    public class GridSelectedEventArgs : EventArgs {

        public int Row { get; set; }

        public int Column { get; set; }

        public GridSelectedEventArgs(int row, int column) {
            Row = row;
            Column = column;
        }
    }
}