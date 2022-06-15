using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xenox003.MagicHome.Manager
{
    public class GlobalConfigManager
    {
        public static void initialize()
        {
            // Check Global Config Integrity \\
            if (PluginConfiguration.GetValue(Main.Instance, "discoveryTimeout") == null) PluginConfiguration.SetValue(Main.Instance, "discoveryTimeout", "1000");
            if (PluginConfiguration.GetValue(Main.Instance, "deviceList") == null) PluginConfiguration.SetValue(Main.Instance, "deviceList", "[]");
        }
        public static void updateDiscoveryTimeout(int discoveryTimeout)
        {
            PluginConfiguration.SetValue(Main.Instance, "discoveryTimeout", discoveryTimeout.ToString());
        }
    }
}
