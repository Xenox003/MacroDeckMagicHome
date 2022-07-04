using Newtonsoft.Json.Linq;
using SuchByte.MacroDeck.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Xenox003.MagicHome.API;

namespace Xenox003.MagicHome.Manager
{
    public class DeviceManager
    {
        public static List<Light> deviceList { get; private set; } = new List<Light>();

        public static async void initialize()
        {
            // Config Load
            JArray deviceList = PluginConfigManager.getDeviceList();
            
            foreach (var token in deviceList)
            {
                MacroDeckLogger.Info(Main.Instance, "1");
                JObject obj = token as JObject;
                deviceList.Add(Light.fromJObject(obj));
            }

            
            // Light Discovery
            LightDiscovery.Timeout = PluginConfigManager.getDiscoveryTimeout();
            List<Light> discoveredLights = await LightDiscovery.DiscoverAsync();

            foreach (Light device in discoveredLights)
            {
                createDevice(device.getIP());
            }
        }

        public static Light createDevice(IPAddress IP)
        {
            Light device = new Light(IP.ToString());
            deviceList.Add(device);

            updateDeviceSignal(device);
            return device;
        }
        public static void removeDevice(Light device)
        {
            deviceList.Remove(device);
            updateDeviceListConfig();
        }

        public static void updateDeviceListConfig()
        {
            JArray deviceListJSON = new JArray();

            foreach (var device in deviceList)
            {
                deviceListJSON.Add(device.toJObject());
            }

            PluginConfigManager.updateDeviceList(deviceListJSON);
        }
        public static void updateDeviceSignal(Light device)
        {
            updateDeviceListConfig();
        }
    }
}
