using System;
using System.Windows.Forms;

using NAudio.CoreAudioApi;
using NAudio.Wave;

namespace HeadphoneDaemon
{
    public class NotificationClientImplementation : NAudio.CoreAudioApi.Interfaces.IMMNotificationClient
    {
        private string monitorDeviceId;

        public void OnDefaultDeviceChanged(DataFlow dataFlow, Role role, string defaultDeviceId)
        {
            Console.WriteLine("OnDefaultDeviceChanged --> {0}", dataFlow.ToString());
            Console.WriteLine("Default Device ID is: {0}", defaultDeviceId);
            if (defaultDeviceId == this.monitorDeviceId)
            {

                Console.WriteLine("Monitor State Change!");
                var deviceEnumerator = new MMDeviceEnumerator();
                var device = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
                device.AudioEndpointVolume.Mute = true;
            }
        }

        public void setMonitorDeviceId(string id)
        {
            this.monitorDeviceId = id;
        }

        public void OnDeviceAdded(string deviceId) { }
        public void OnDeviceRemoved(string deviceId) { }
        public void OnDeviceStateChanged(string deviceId, DeviceState newState) { }
        public NotificationClientImplementation() { }
        public void OnPropertyValueChanged(string deviceId, PropertyKey propertyKey) { }
    }

    static class Program
    {
        private static MMDeviceEnumerator deviceEnum = new MMDeviceEnumerator();
        private static NotificationClientImplementation notificationClient;
        private static NAudio.CoreAudioApi.Interfaces.IMMNotificationClient notifyClient;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            foreach (var dev in DirectSoundOut.Devices)
            {
                Console.WriteLine($"{dev.Guid} {dev.ModuleName} {dev.Description}");
            }

            notificationClient = new NotificationClientImplementation();
            notificationClient.setMonitorDeviceId("{0.0.0.00000000}.{299801a3-11d5-4ae6-a926-0362223cebba}");
            notifyClient = (NAudio.CoreAudioApi.Interfaces.IMMNotificationClient)notificationClient;
            deviceEnum.RegisterEndpointNotificationCallback(notifyClient);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HeadphoneDaemon(notificationClient));
        }
    }
}
