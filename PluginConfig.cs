using Newtonsoft.Json.Linq;
using SuchByte.MacroDeck.Logging;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json;

namespace Xenox003.MagicHome
{
    public class PluginConfig
    {
        private static void UpdateDeviceList(JObject deviceList)
        {
            PluginConfiguration.SetValue(Main.Instance, "devices", deviceList.ToString());
            //MacroDeckLogger.Info(Main.Instance, deviceList.ToString());
        }
        public static JObject getDeviceList()
        {
            String configStr = PluginConfiguration.GetValue(Main.Instance, "devices");
            if (string.IsNullOrEmpty(configStr))
            {
                JObject deviceList = new JObject();
                PluginConfiguration.SetValue(Main.Instance, "devices", deviceList.ToString());
                return deviceList;
            } else
            {
                JObject deviceList = JObject.Parse(configStr);
                return deviceList;
            }
        }
        public static JObject getDevice(IPAddress IP)
        {
            JObject deviceList = getDeviceList();
            if (deviceList[IP.ToString()] != null)
            {
                return deviceList[IP.ToString()] as JObject;
            }
            return null;
        }
        public static bool AddDevice(IPAddress IP)
        {
            JObject deviceList = getDeviceList();
            if (deviceList[IP.ToString()] == null)
            {
                JObject newDevice = new JObject();
                newDevice["name"] = "";
                newDevice["useUpdateCycle"] = "false";
                newDevice["onStateChangeVariable"] = "";
                newDevice["onColorChangeVariable"] = "";

                deviceList[IP.ToString()] = newDevice;

                UpdateDeviceList(deviceList);
                MacroDeckLogger.Info(Main.Instance, "Added " + IP.ToString() + " to Device List");

                return true;
            }
            return false;
        }
        public static bool RemoveDevice(IPAddress IP)
        {
            JObject deviceList = getDeviceList();
            if (deviceList[IP.ToString()] != null)
            {
                MacroDeckLogger.Info(Main.Instance, deviceList.ToString());
                deviceList.Remove(IP.ToString());
                MacroDeckLogger.Info(Main.Instance, deviceList.ToString());

                UpdateDeviceList(deviceList);
                MacroDeckLogger.Info(Main.Instance, "Removed " + IP.ToString() + " from Device List");

                return true;
            }
            return false;
        }
        public static void UpdateDevice(IPAddress IP,String key, Object value)
        {
            JObject deviceList = getDeviceList();
            if (deviceList[IP.ToString()] != null)
            {
                JObject device = deviceList[IP.ToString()] as JObject;

                device[key] = value.ToString();

                deviceList[IP.ToString()] = device;

                UpdateDeviceList(deviceList);
            }
        }
    }
}
