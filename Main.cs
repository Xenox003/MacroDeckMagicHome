using System;
using SuchByte.MacroDeck.Plugins;
using System.Collections.Generic;
using Xenox003.MagicHome.Actions;
using Xenox003.MagicHome.Views;
using Xenox003.MagicHome.Manager;

namespace Xenox003.MagicHome
{
    public class PluginInstance
    {
        public static Main Main { get; set; }
    }

    public class Main : MacroDeckPlugin
    {
        public static Main Instance;
        public override bool CanConfigure => true;

        public Main()
        {
            Instance = this;
            PluginInstance.Main = this;
        }

        public override void Enable()
        {
            // Register Actions \\
            this.Actions = new List<PluginAction>
            {
                new UpdateLightAction()
            };

            // Initialize Managers \\
            DeviceManager.initialize();
            GlobalConfigManager.initialize();
        }

        public override void OpenConfigurator()
        {
            using (var configurator = new PluginConfigurator())
            {
                configurator.ShowDialog();
            }
        }
    }
}
