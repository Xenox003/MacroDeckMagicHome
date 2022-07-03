using Newtonsoft.Json.Linq;
using SuchByte.MacroDeck.Logging;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Xenox003.MagicHome.Objects;

namespace Xenox003.MagicHome.Manager
{
    public class DeviceManager
    {
        public static List<Device> deviceList { get; private set; } = new List<Device>();

        public static void initialize()
        {
            string configStr = PluginConfiguration.GetValue(Main.Instance, "deviceList");
            JArray configArray = JArray.Parse(configStr);
            if (configArray != null)
            {
                foreach (JToken token in configArray)
                {
                    JObject obj = token as JObject;
                    deviceList.Add(Device.fromJObject(obj));
                }
            }
        }
        public static Device createDevice(IPAddress IP)
        {
            Device device = new Device(IP);
            deviceList.Add(device);

            deviceUpdateSignal(device);
            return device;
        }

        public static Light createLight(IPAddress IP)
        {
            Light light = new Light(IP);
            deviceList.Add(light);

            deviceUpdateSignal(light);
            return light;
        }

        public static void removeDevice(Device device)
        {
            deviceList.Remove(device);
            deviceUpdateSignal(device);
        }

        public static async void deviceUpdateSignal(Device device)
        {
            JArray deviceListJson = new JArray();
            foreach (var dev in deviceList)
            {
                deviceListJson.Add(dev.toJObject());
            }
            PluginConfiguration.SetValue(Main.Instance, "deviceList", deviceListJson.ToString());

            if (device is Light)
            {
                Light light = device as Light;
                if (!device.Connected)
                {

                    await light.ConnectAsync();
                    MacroDeckLogger.Info(Main.Instance, "Connecting " + light.IP);
                }
            }
        }
    }
}
