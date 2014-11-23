using System;
using System.Drawing;
using System.Windows.Forms;

namespace Twainsoft.GridSelection
{
    public partial class GridSelectionView : Form
    {
        private string elementsSelectedText = "$rowx$column elements selected";
        private string noElementsSelectedText = "No elements selected";

        private int row;
        private int column;

        public string ElementsSelectedText {
            get { return elementsSelectedText; }
            set { elementsSelectedText = value; }
        }

        public string NoElementsSelectedText {
            get { return noElementsSelectedText; }
            set { noElementsSelectedText = value; }
        }

        public delegate void GridSelectedEventHandler(object sender, GridSelectedEventArgs e);
        public event GridSelectedEventHandler GridSelected;

        public GridSelectionView()
        {
            InitializeComponent();

            Location = new Point(100, 100);
            MouseLeave += flowLayoutPanel_MouseLeave;
            flowLayoutPanel.MouseHover += flowLayoutPanel_MouseHover;
            int row = 1;
            int column = 1;
            GridSelectionPanel last = null;

            for (int i = 0; i < 108; i++) {
                GridSelectionPanel p = new GridSelectionPanel(this, flowLayoutPanel);
                p.MouseClick += p_MouseClick;
                p.MouseEnter += p_MouseEnter;
                p.MouseHover += p_MouseHover;
                flowLayoutPanel.Controls.Add(p);

                if (last != null)
                {
                    if (p.Location.X < last.Location.X)
                    {
                        row++;
                        column = 1;
                    }

                    if (p.Location.Y <= last.Location.Y)
                    {
                        column++;
                    }
                }

                p.Row = row;
                p.Column = column;
                last = p;
            }
        }

        void flowLayoutPanel_MouseHover(object sender, EventArgs e)
        {
            OnGridSelected();
        }

        void p_MouseHover(object sender, EventArgs e)
        {
            OnGridSelected();
        }

        void flowLayoutPanel_MouseLeave(object sender, EventArgs e)
        {
            row = 0;
            column = 0;

            ChangeGridSelection();
        }

        void p_MouseEnter(object sender, EventArgs e)
        {
            row = ((GridSelectionPanel)sender).Row;
            column = ((GridSelectionPanel)sender).Column;

            ChangeGridSelection();
        }

        private void ChangeGridSelection()
        {
            for (int i = 0; i < 108; i++) {
                GridSelectionPanel p = (GridSelectionPanel)flowLayoutPanel.Controls[i];

                p.SetBackColor(row, column);
            }

            flowLayoutPanel.Invalidate();

            string text = "";
            if (row != 0 && column != 0)
                text = elementsSelectedText;
            else
                text = noElementsSelectedText;

            oLblSelectedElements.Text = text.Replace("$row", row.ToString()).Replace("$column",
                column.ToString()).Replace("$result", (row * column).ToString());
        }

        void p_MouseClick(object sender, MouseEventArgs e)
        {
            HandleInput(e);
        }

        private void FrmGridSelection_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void FrmGridSelection_MouseClick(object sender, MouseEventArgs e)
        {
            HandleInput(e);
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            HandleInput(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawRectangle(new Pen(Brushes.Black, 2), new Rectangle(0, 0, Width, Height));

            e.Graphics.DrawLine(new Pen(Brushes.Black, 2), new Point(1, 21), new Point(Width, 21));

            e.Graphics.Dispose();
        }

        private void HandleInput(MouseEventArgs mouseEventArgs)
        {
            OnGridSelected();

            if (mouseEventArgs.Button == MouseButtons.Left)
            {
                Close();
            }
        }

        private void OnGridSelected()
        {
            if (GridSelected != null)
            {
                GridSelected(this, new GridSelectedEventArgs(row, column));
            }
        }
    }
}