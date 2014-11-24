namespace Twainsoft.GridSelection {
    partial class GridSelectionView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.oLblSelectedElements = new System.Windows.Forms.Label();
            this.pnlButtonBright3d = new System.Windows.Forms.Panel();
            this.pnlButtonDark3d = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(204, 131);
            this.flowLayoutPanel.TabIndex = 0;
            this.flowLayoutPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.oLblSelectedElements);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 20);
            this.panel1.TabIndex = 1;
            // 
            // oLblSelectedElements
            // 
            this.oLblSelectedElements.Dock = System.Windows.Forms.DockStyle.Top;
            this.oLblSelectedElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oLblSelectedElements.Location = new System.Drawing.Point(0, 0);
            this.oLblSelectedElements.Name = "oLblSelectedElements";
            this.oLblSelectedElements.Size = new System.Drawing.Size(208, 19);
            this.oLblSelectedElements.TabIndex = 0;
            this.oLblSelectedElements.Text = "No Elements selected";
            this.oLblSelectedElements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlButtonBright3d
            // 
            this.pnlButtonBright3d.Location = new System.Drawing.Point(0, 0);
            this.pnlButtonBright3d.Name = "pnlButtonBright3d";
            this.pnlButtonBright3d.Size = new System.Drawing.Size(200, 100);
            this.pnlButtonBright3d.TabIndex = 0;
            // 
            // pnlButtonDark3d
            // 
            this.pnlButtonDark3d.Location = new System.Drawing.Point(0, 0);
            this.pnlButtonDark3d.Name = "pnlButtonDark3d";
            this.pnlButtonDark3d.Size = new System.Drawing.Size(200, 100);
            this.pnlButtonDark3d.TabIndex = 0;
            // 
            // GridSelectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(210, 158);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GridSelectionView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGridSelection_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmGridSelection_MouseClick);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label oLblSelectedElements;
        private System.Windows.Forms.Panel pnlButtonBright3d;
        private System.Windows.Forms.Panel pnlButtonDark3d;
    }
}