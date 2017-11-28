namespace SimpleCrawlApp.SimpleModelTool
{
    partial class MyTaskFrm
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
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.SuspendLayout();
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(300, 300);
            this.skinGroupBox1.TabIndex = 0;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "新建任务类型";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // MyTaskFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.skinGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyTaskFrm";
            this.Text = "MyTaskFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
    }
}