namespace SimpleCrawlApp.SimpleModelTool
{
    partial class MenuFrm
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
            this.menuPanel = new CCWin.SkinControl.SkinPanel();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.DownBack = null;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.MouseBack = null;
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.NormlBack = null;
            this.menuPanel.Size = new System.Drawing.Size(300, 300);
            this.menuPanel.TabIndex = 0;
            // 
            // MenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuFrm";
            this.Text = "MenuFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel menuPanel;
    }
}