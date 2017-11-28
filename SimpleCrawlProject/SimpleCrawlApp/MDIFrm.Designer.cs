namespace SimpleCrawlApp
{
    partial class MDIFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIFrm));
            this.MdiPanel = new CCWin.SkinControl.SkinPanel();
            this.MdiTabcontrol = new CCWin.SkinControl.SkinTabControl();
            this.MdiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MdiPanel
            // 
            this.MdiPanel.BackColor = System.Drawing.Color.Transparent;
            this.MdiPanel.Controls.Add(this.MdiTabcontrol);
            this.MdiPanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.MdiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MdiPanel.DownBack = null;
            this.MdiPanel.Location = new System.Drawing.Point(0, 0);
            this.MdiPanel.MouseBack = null;
            this.MdiPanel.Name = "MdiPanel";
            this.MdiPanel.NormlBack = null;
            this.MdiPanel.Size = new System.Drawing.Size(800, 500);
            this.MdiPanel.TabIndex = 1;
            // 
            // MdiTabcontrol
            // 
            this.MdiTabcontrol.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.MdiTabcontrol.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.MdiTabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MdiTabcontrol.HeadBack = null;
            this.MdiTabcontrol.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.MdiTabcontrol.ItemSize = new System.Drawing.Size(70, 36);
            this.MdiTabcontrol.Location = new System.Drawing.Point(0, 0);
            this.MdiTabcontrol.Name = "MdiTabcontrol";
            this.MdiTabcontrol.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("MdiTabcontrol.PageArrowDown")));
            this.MdiTabcontrol.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("MdiTabcontrol.PageArrowHover")));
            this.MdiTabcontrol.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("MdiTabcontrol.PageCloseHover")));
            this.MdiTabcontrol.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("MdiTabcontrol.PageCloseNormal")));
            this.MdiTabcontrol.PageDown = ((System.Drawing.Image)(resources.GetObject("MdiTabcontrol.PageDown")));
            this.MdiTabcontrol.PageHover = ((System.Drawing.Image)(resources.GetObject("MdiTabcontrol.PageHover")));
            this.MdiTabcontrol.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.MdiTabcontrol.PageNorml = null;
            this.MdiTabcontrol.Size = new System.Drawing.Size(800, 500);
            this.MdiTabcontrol.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MdiTabcontrol.TabIndex = 0;
            this.MdiTabcontrol.SelectedIndexChanged += new System.EventHandler(this.MdiTabcontrol_SelectedIndexChanged);
            // 
            // MDIFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.MdiPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MDIFrm";
            this.Text = "MDIFrm";
            this.MdiPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel MdiPanel;
        private CCWin.SkinControl.SkinTabControl MdiTabcontrol;
    }
}