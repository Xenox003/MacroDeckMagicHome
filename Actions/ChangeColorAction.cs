using Newtonsoft.Json.Linq;
using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;
using System.Text;
using Xenox003.MagicHome.API;
using Xenox003.MagicHome.Manager;
using Xenox003.MagicHome.UI.Actions;

namespace Xenox003.MagicHome.Actions
{
    public class ChangeColorAction : PluginAction
    {
        public enum ToggleState
        {
            ON,
            OFF,
            TOGGLE
        }

        public override string Name => "Change Light Color";

        public override string Description => "Change the RGB Value of an Light";

        public override bool CanConfigure => true;

        public override ActionConfigControl GetActionConfigControl(ActionConfigurator actionConfigurator)
        {
            return new ChangeColorActionConfigurator(this, actionConfigurator);
        }

        public override async void Trigger(string clientId, ActionButton actionButton)
        {
            JObject config = JObject.Parse(this.Configuration);

            API.Color color = API.Color.Parse(config["color"].ToString());
            Light device = DeviceManager.getDeviceByIP(System.Net.IPAddress.Parse(config["deviceIP"].ToString()));

            if (device != null)
            {
                await device.SetColorAsync(color);
            }
        }
    }
}
