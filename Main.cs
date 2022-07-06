using System;
using SuchByte.MacroDeck.Plugins;
using System.Collections.Generic;
using Xenox003.MagicHome.UI.Views;
using Xenox003.MagicHome.Manager;
using Xenox003.MagicHome.Actions;

namespace Xenox003.MagicHome
{

    public class Main : MacroDeckPlugin
    {
        public static Main Instance;
        public override bool CanConfigure => true;

        public Main()
        {
            Instance = this;
        }

        public override void Enable()
        {
            // Register Actions \\
            this.Actions = new List<PluginAction>
            {
                new ToggleLightAction()
            };

            // Init Managers
            PluginConfigManager.initialize();
            DeviceManager.initialize();
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
