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
    public class ToggleLightAction : PluginAction
    {
        public enum ToggleState
        {
            ON,
            OFF,
            TOGGLE
        }

        public override string Name => "Toggle Light";

        public override string Description => "Change a Light's On/Off State";

        public override bool CanConfigure => true;

        public override ActionConfigControl GetActionConfigControl(ActionConfigurator actionConfigurator)
        {
            return new ToggleLightActionConfigurator(this, actionConfigurator);
        }

        public override async void Trigger(string clientId, ActionButton actionButton)
        {
            JObject config = JObject.Parse(this.Configuration);

            ToggleState toggleState = (ToggleState) Enum.Parse(typeof(ToggleState), config["toggleOption"].ToString());
            Light device = DeviceManager.getDeviceByIP(System.Net.IPAddress.Parse(config["deviceIP"].ToString()));

            if (device != null)
            {
                switch (toggleState)
                {
                    case ToggleState.TOGGLE:
                        await device.SetPowerAsync(!device.getPower());
                        break;
                    case ToggleState.ON:
                        await device.TurnOnAsync();
                        break;
                    case ToggleState.OFF:
                        await device.TurnOffAsync();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
