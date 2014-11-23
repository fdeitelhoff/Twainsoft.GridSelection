using System;
using System.Drawing;
using System.Windows.Forms;

namespace Twainsoft.GridSelection
{
    public partial class GridSelectionPanel : Panel
    {
        public int Row { get; set; }
        public int Column { get; set; }

        private Rectangle PanelRectangle { get; set; }
        private bool IsBackcolorActive { get; set; }

        private GridSelectionPanel()
        {
            InitializeComponent();

            PanelRectangle = new Rectangle(Location.X - 1, Location.Y - 1, Width + 2, Height + 2);
        }

        public GridSelectionPanel(GridSelectionView gridSelectionView, FlowLayoutPanel flowLayoutPanel) 
            : this()
        {
            flowLayoutPanel.MouseMove += flp_MouseMove;
            flowLayoutPanel.Invalidated += flowLayoutPanel_Invalidated;
            gridSelectionView.MouseLeave += frmGridSelection_MouseLeave;
        }

        void frmGridSelection_MouseLeave(object sender, EventArgs e)
        {
            IsBackcolorActive = false;
            BackColor = Color.White;
        }

        void flowLayoutPanel_Invalidated(object sender, InvalidateEventArgs e)
        {
            BackColor = IsBackcolorActive ? Color.Orange : Color.White;
        }

        void flp_MouseMove(object sender, MouseEventArgs e)
        {
            if (PanelRectangle.Contains(e.Location.X, e.Location.Y))
            {
                OnMouseEnter(EventArgs.Empty);
            }
        }
        
        public void SetBackColor(int row, int column)
        {
            if (Row <= row && Column <= column)
            {
                IsBackcolorActive = true;
            } else {
                IsBackcolorActive = false;
            }
        }
    }
}