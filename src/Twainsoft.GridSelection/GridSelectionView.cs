using System;
using System.Drawing;
using System.Windows.Forms;

namespace Twainsoft.GridSelection
{
    public partial class GridSelectionView : Form
    {
        private int Row { get; set; }
        private int Column { get; set; }

        private string ElementsSelectedText { get; set; }
        private string NoElementsSelectedText { get; set; }

        public GridSelectionView()
        {
            InitializeComponent();

            ElementsSelectedText = "{0}x{1} elements selected";
            NoElementsSelectedText = "No elements selected";
            Row = 1;
            Column = 1;

            Location = new Point(100, 100);
            MouseLeave += flowLayoutPanel_MouseLeave;

            GridSelectionPanel last = null;

            for (var i = 0; i < 108; i++) {
                var p = new GridSelectionPanel(this, flowLayoutPanel);
                p.MouseClick += p_MouseClick;
                p.MouseEnter += p_MouseEnter;
                flowLayoutPanel.Controls.Add(p);

                if (last != null)
                {
                    if (p.Location.X < last.Location.X)
                    {
                        Row++;
                        Column = 1;
                    }

                    if (p.Location.Y <= last.Location.Y)
                    {
                        Column++;
                    }
                }

                p.Row = Row;
                p.Column = Column;
                last = p;
            }
        }

        void flowLayoutPanel_MouseLeave(object sender, EventArgs e)
        {
            Row = 0;
            Column = 0;

            ChangeGridSelection();
        }

        void p_MouseEnter(object sender, EventArgs e)
        {
            Row = ((GridSelectionPanel)sender).Row;
            Column = ((GridSelectionPanel)sender).Column;

            ChangeGridSelection();
        }

        private void ChangeGridSelection()
        {
            for (var i = 0; i < 108; i++)
            {
                var p = (GridSelectionPanel)flowLayoutPanel.Controls[i];

                p.SetBackColor(Row, Column);
            }

            flowLayoutPanel.Invalidate();

            if (Row > 0 && Column > 0)
            {
                oLblSelectedElements.Text = string.Format(ElementsSelectedText, Column, Row);
            }
            else
            {
                oLblSelectedElements.Text = NoElementsSelectedText;
            }
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
        }

        private void HandleInput(MouseEventArgs mouseEventArgs)
        {
            if (mouseEventArgs.Button == MouseButtons.Left)
            {
                Close();
            }
        }
    }
}