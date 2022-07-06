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
            JArray deviceListArr = PluginConfigManager.getDeviceList();
            
            foreach (JToken token in deviceListArr)
            {
                JObject obj = token as JObject;
                if (obj != null)
                {
                    Light light = Light.fromJObject(obj);
                    deviceList.Add(light);
                    updateDeviceSignal(light);
                }
            }
            


            // Light Discovery
            
            LightDiscovery.Timeout = PluginConfigManager.getDiscoveryTimeout();
            List<Light> discoveredLights = await LightDiscovery.DiscoverAsync();

            foreach (Light device in discoveredLights)
            {
                
                createDevice(device.getIP());
            }

        }

        public static Light createDevice(IPAddress IP,bool disableDoubleCheck = false)
        {
            if (deviceList.FindAll(x => x.getIP().ToString() == IP.ToString()).Count == 0 || disableDoubleCheck == true)
            {
                Light device = new Light(IP.ToString());
                deviceList.Add(device);

                updateDeviceSignal(device);
                return device;
            }
            return null;
        }
        public static void removeDevice(Light device)
        {
            deviceList.Remove(device);
            updateDeviceListConfig();
        }

        public static Light getDeviceByIP(IPAddress IP)
        {
            List<Light> foundItems = deviceList.FindAll(x => x.getIP().ToString() == IP.ToString());
            if (foundItems.Count != 0)
            {
                return foundItems[0];
            }
            return null;
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
        public static async void updateDeviceSignal(Light device)
        {
            if (!device.Connected)
            {
                try
                {
                    await device.ConnectAsync();
                }
                catch (Exception ex)
                {
                    MacroDeckLogger.Warning(Main.Instance, "Could not connect to device " + device.getIP() + " | " + ex.Message);
                }
            }
            updateDeviceListConfig();
        }
    }
}
