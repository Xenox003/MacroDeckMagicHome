﻿using Newtonsoft.Json.Linq;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xenox003.MagicHome.Manager
{
    public class PluginConfigManager
    {
        public static void initialize()
        {
            if (PluginConfiguration.GetValue(Main.Instance, "discoveryTimeout") == null) PluginConfiguration.SetValue(Main.Instance, "discoveryTimeout", "1000");
            if (PluginConfiguration.GetValue(Main.Instance, "deviceList") == null) PluginConfiguration.SetValue(Main.Instance, "deviceList", "[]");
        }

        public static void updateDiscoveryTimeout(int discoveryTimeout)
        {
            PluginConfiguration.SetValue(Main.Instance, "discoveryTimeout", discoveryTimeout.ToString());
        }
        public static int getDiscoveryTimeout()
        {
            return Int32.Parse(PluginConfiguration.GetValue(Main.Instance, "discoveryTimeout"));
        }

        public static void updateDeviceList(JArray deviceList)
        {
            PluginConfiguration.SetValue(Main.Instance, "deviceList", deviceList.ToString());
        }
        public static JArray getDeviceList()
        {
            return JArray.Parse(PluginConfiguration.GetValue(Main.Instance, "deviceList"));
        }
    }
}
