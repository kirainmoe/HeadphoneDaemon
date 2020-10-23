using Microsoft.Win32;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace HeadphoneDaemon
{
    public partial class HeadphoneDaemon : Form
    {
        Dictionary<String, String> devices = new Dictionary<String, String>();

        private static NotificationClientImplementation notificationClient;

        public HeadphoneDaemon(NotificationClientImplementation client)
        {
            InitializeComponent();
            notificationClient = client;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 注意判断关闭事件reason来源于窗体按钮，否则用菜单退出时无法退出!
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //取消"关闭窗口"事件
                e.Cancel = true; // 取消关闭窗体 

                //使关闭时窗口向右下角缩小的效果
                this.WindowState = FormWindowState.Minimized;
                this.mainNotifyIcon.Visible = true;
                //this.m_cartoonForm.CartoonClose();
                this.Hide();
                return;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var dev in DirectSoundOut.Devices)
            {
                deviceComboBox.Items.Add(dev.Description);
                devices[dev.Description] = dev.ModuleName;
                if (dev.Description.Contains("扬声器") || dev.Description.Contains("Speaker"))
                {
                    deviceComboBox.SelectedIndex = deviceComboBox.Items.IndexOf(dev.Description);
                    notificationClient.setMonitorDeviceId(dev.ModuleName);
                }
            }
            this.Visible = false;
            this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Hide();
        }

        private void deviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            notificationClient.setMonitorDeviceId(devices[deviceComboBox.SelectedItem.ToString()]);
        }

        private void SetOutputDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1_MouseDoubleClick(sender, null);
        }

        private static RegistryKey _rlocal = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");


        /// <summary>
        /// 根据 app.config 中"isAuto"，设置是否开机启动
        /// </summary>
        public static void setAutoRun()
        {
            RegistryKey r_local = Registry.LocalMachine;//registrykey r_local = registry.currentuser;
            RegistryKey r_run = r_local.OpenSubKey(@"software\microsoft\windows\currentversion\run", false);
            var isAutorun = false;
            if (r_run.GetValue("HeadphoneDaemon") != null)
            {
                isAutorun = true;
            }
            r_run.Close();
            r_local.Close();

            try
            {
                if (!isAutorun)
                {
                    r_local = Registry.LocalMachine;//registrykey r_local = registry.currentuser;
                    r_run = r_local.CreateSubKey(@"software\microsoft\windows\currentversion\run");
                    r_run.SetValue("HeadphoneDaemon", Application.ExecutablePath);
                    MessageBox.Show("已设置开机启动~");
                    r_run.Close();
                    r_local.Close();
                }
                else
                {
                    r_local = Registry.LocalMachine;//registrykey r_local = registry.currentuser;
                    r_run = r_local.CreateSubKey(@"software\microsoft\windows\currentversion\run");
                    r_run.DeleteValue("HeadphoneDaemon", false);
                    MessageBox.Show("已取消开机启动~");
                    r_run.Close();
                    r_local.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("您需要管理员权限修改", "提示");
            }

        }

        private void SetOnBootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setAutoRun();
        }
    }
}
