using System;
using SuchByte.MacroDeck.Plugins;
using SuchByte.MacroDeck.Logging;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using Xenox003.MagicHome.Actions;
using Xenox003.MagicHome.Views;
using Xenox003.MagicHome.API;

namespace Xenox003.MagicHome
{
    public class PluginInstance
    {
        public static Main Main { get; set; }
    }

    public class Main : MacroDeckPlugin
    {
        private static List<Light> discoveredLights;

        public static Main Instance;

        // Optional; If your plugin can be configured, set to "true". It'll make the "Configure" button appear in the package manager.
        public override bool CanConfigure => true;

        // Gets called when the plugin is loaded
        public override async void Enable()
        {
            this.Actions = new List<PluginAction>
            {
                new TestAction()
            };

            MacroDeckLogger.Info(this, "Searching for Devices...");
            LightDiscovery.Timeout = 2000;
            discoveredLights = await LightDiscovery.DiscoverAsync();

            foreach (var light in discoveredLights)
            {
                await light.ConnectAsync();
            }

            MacroDeckLogger.Info(this,"Found " + discoveredLights.Count.ToString() + " device(s)");
        }

        public override void OpenConfigurator()
        {
            using (var configurator = new PluginConfigurator())
            {
                configurator.ShowDialog();
            }
        }

        public Main()
        {
            Instance = this;
            PluginInstance.Main = this;
        }

        public static List<Light> getDiscoveredLights()
        {
            return discoveredLights;
        }
    }
}
