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

            deviceUpdateSignal();
            return device;
        }

        public static void removeDevice(Device device)
        {
            deviceList.Remove(device);
            deviceUpdateSignal();
        }

        public static void deviceUpdateSignal()
        {
            JArray deviceListJson = new JArray();
            foreach (var device in deviceList)
            {
                deviceListJson.Add(device.toJObject());
            }
            PluginConfiguration.SetValue(Main.Instance, "deviceList", deviceListJson.ToString());
        }
    }
}
