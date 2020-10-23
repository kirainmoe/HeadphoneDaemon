namespace HeadphoneDaemon
{
    partial class HeadphoneDaemon
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeadphoneDaemon));
            this.mainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.headphoneDaemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetOutputDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SetOnBootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainNotifyIcon
            // 
            this.mainNotifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.mainNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("mainNotifyIcon.Icon")));
            this.mainNotifyIcon.Text = "HeadphoneDaemon";
            this.mainNotifyIcon.Visible = true;
            this.mainNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.headphoneDaemonToolStripMenuItem,
            this.SetOutputDeviceToolStripMenuItem,
            this.SetOnBootToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(240, 135);
            // 
            // headphoneDaemonToolStripMenuItem
            // 
            this.headphoneDaemonToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.headphoneDaemonToolStripMenuItem.Enabled = false;
            this.headphoneDaemonToolStripMenuItem.Name = "headphoneDaemonToolStripMenuItem";
            this.headphoneDaemonToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.headphoneDaemonToolStripMenuItem.Text = "Headphone Daemon";
            // 
            // SetOutputDeviceToolStripMenuItem
            // 
            this.SetOutputDeviceToolStripMenuItem.Name = "SetOutputDeviceToolStripMenuItem";
            this.SetOutputDeviceToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.SetOutputDeviceToolStripMenuItem.Text = "设置输出设备";
            this.SetOutputDeviceToolStripMenuItem.Click += new System.EventHandler(this.SetOutputDeviceToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceComboBox.Font = new System.Drawing.Font("微软雅黑", 10.37288F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(149, 23);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(415, 31);
            this.deviceComboBox.TabIndex = 1;
            this.deviceComboBox.SelectedIndexChanged += new System.EventHandler(this.deviceComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "默认输出设备";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(553, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "* 当系统从其它输出设备（如耳机）切换到默认输出设备时，会自动静音默认输出设备。";
            // 
            // SetOnBootToolStripMenuItem
            // 
            this.SetOnBootToolStripMenuItem.Name = "SetOnBootToolStripMenuItem";
            this.SetOnBootToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.SetOnBootToolStripMenuItem.Text = "开机启动";
            this.SetOnBootToolStripMenuItem.Click += new System.EventHandler(this.SetOnBootToolStripMenuItem_Click);
            // 
            // HeadphoneDaemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 112);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deviceComboBox);
            this.Name = "HeadphoneDaemon";
            this.Text = "Headphone Daemon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon mainNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem SetOutputDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headphoneDaemonToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem SetOnBootToolStripMenuItem;
    }
}

