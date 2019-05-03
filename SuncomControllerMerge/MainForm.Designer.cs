namespace SuncomControllerMerge
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lblVjoyStat = new System.Windows.Forms.Label();
            this.lblWheelStat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHandbrakeStat = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VJoy:";
            // 
            // lblVjoyStat
            // 
            this.lblVjoyStat.AutoSize = true;
            this.lblVjoyStat.Location = new System.Drawing.Point(167, 9);
            this.lblVjoyStat.Name = "lblVjoyStat";
            this.lblVjoyStat.Size = new System.Drawing.Size(52, 13);
            this.lblVjoyStat.TabIndex = 1;
            this.lblVjoyStat.Text = "Waiting...";
            // 
            // lblWheelStat
            // 
            this.lblWheelStat.AutoSize = true;
            this.lblWheelStat.Location = new System.Drawing.Point(167, 24);
            this.lblWheelStat.Name = "lblWheelStat";
            this.lblWheelStat.Size = new System.Drawing.Size(52, 13);
            this.lblWheelStat.TabIndex = 2;
            this.lblWheelStat.Text = "Waiting...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CHRZ Handbrake:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "MS SideWinder Wheel:";
            // 
            // lblHandbrakeStat
            // 
            this.lblHandbrakeStat.AutoSize = true;
            this.lblHandbrakeStat.Location = new System.Drawing.Point(167, 39);
            this.lblHandbrakeStat.Name = "lblHandbrakeStat";
            this.lblHandbrakeStat.Size = new System.Drawing.Size(52, 13);
            this.lblHandbrakeStat.TabIndex = 5;
            this.lblHandbrakeStat.Text = "Waiting...";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "CHRZControllerMerge minimized.\r\nDouble click to restore.";
            this.notifyIcon1.BalloonTipTitle = "CHRZ Controller Merge";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 67);
            this.Controls.Add(this.lblHandbrakeStat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblWheelStat);
            this.Controls.Add(this.lblVjoyStat);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CHRZ Controller Merger";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVjoyStat;
        private System.Windows.Forms.Label lblWheelStat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHandbrakeStat;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

