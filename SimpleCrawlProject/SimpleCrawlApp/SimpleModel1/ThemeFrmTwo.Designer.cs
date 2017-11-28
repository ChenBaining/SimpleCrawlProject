namespace SimpleCrawlApp.SimpleModel1
{
    partial class ThemeFrmTwo
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
            this.components = new System.ComponentModel.Container();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.taskURLWaterTextBox = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.upBtn = new CCWin.SkinControl.SkinButton();
            this.backBtn = new CCWin.SkinControl.SkinButton();
            this.skinPanel3 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel2.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.taskURLWaterTextBox);
            this.skinPanel2.Controls.Add(this.skinLabel1);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(0, 40);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Size = new System.Drawing.Size(784, 422);
            this.skinPanel2.TabIndex = 3;
            // 
            // taskURLWaterTextBox
            // 
            this.taskURLWaterTextBox.Location = new System.Drawing.Point(100, 15);
            this.taskURLWaterTextBox.Name = "taskURLWaterTextBox";
            this.taskURLWaterTextBox.Size = new System.Drawing.Size(390, 21);
            this.taskURLWaterTextBox.TabIndex = 8;
            this.taskURLWaterTextBox.Text = "http://www.czxx.gansu.gov.cn:81/index.php?dir=/政府信息公开/信息公开目录/政策法规";
            this.taskURLWaterTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.taskURLWaterTextBox.WaterText = "";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(25, 20);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(68, 17);
            this.skinLabel1.TabIndex = 4;
            this.skinLabel1.Text = "采集网址：";
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.upBtn);
            this.skinPanel1.Controls.Add(this.backBtn);
            this.skinPanel1.Controls.Add(this.skinPanel3);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(784, 40);
            this.skinPanel1.TabIndex = 2;
            // 
            // upBtn
            // 
            this.upBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.upBtn.BackColor = System.Drawing.Color.Transparent;
            this.upBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.upBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.upBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.upBtn.DownBack = null;
            this.upBtn.Location = new System.Drawing.Point(673, 12);
            this.upBtn.MouseBack = null;
            this.upBtn.Name = "upBtn";
            this.upBtn.NormlBack = null;
            this.upBtn.Size = new System.Drawing.Size(75, 23);
            this.upBtn.TabIndex = 6;
            this.upBtn.Text = "下一步";
            this.upBtn.UseVisualStyleBackColor = false;
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.backBtn.DownBack = null;
            this.backBtn.Location = new System.Drawing.Point(592, 12);
            this.backBtn.MouseBack = null;
            this.backBtn.Name = "backBtn";
            this.backBtn.NormlBack = null;
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "上一步";
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // skinPanel3
            // 
            this.skinPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPanel3.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel3.DownBack = null;
            this.skinPanel3.Location = new System.Drawing.Point(3, 3);
            this.skinPanel3.MouseBack = null;
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.NormlBack = null;
            this.skinPanel3.Size = new System.Drawing.Size(551, 35);
            this.skinPanel3.TabIndex = 4;
            // 
            // ThemeFrmTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.skinPanel2);
            this.Controls.Add(this.skinPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemeFrmTwo";
            this.Text = "ThemeFrmTwo";
            this.skinPanel2.ResumeLayout(false);
            this.skinPanel2.PerformLayout();
            this.skinPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel2;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinButton upBtn;
        private CCWin.SkinControl.SkinButton backBtn;
        private CCWin.SkinControl.SkinPanel skinPanel3;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinWaterTextBox taskURLWaterTextBox;
    }
}