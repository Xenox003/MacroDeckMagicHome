using Newtonsoft.Json.Linq;
using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Logging;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;
using System.Text;
using Xenox003.MagicHome.Views;

namespace Xenox003.MagicHome.Actions
{
    public class UpdateLightAction : PluginAction
    {
        public override string Name => "Update Light";

        public override string Description => "Update values of your Magic Home LED Device";

        public override bool CanConfigure => true;

        public override ActionConfigControl GetActionConfigControl(ActionConfigurator actionConfigurator)
        {
            return new UpdateLightConfigurator(this, actionConfigurator);
        }

        public override void Trigger(string clientId, ActionButton actionButton)
        {
            /*
            JObject config = JObject.Parse(this.Configuration);

            List<Light> lights = Main.getDiscoveredLights();
            Light light = lights.Find(x => x.getIP().ToString() == config["selectedLightIP"].ToString());

            if (light != null)
            {
                if (!light.Connected)
                {
                    await light.ConnectAsync();
                }

                if (config["change"] != null)
                {
                    if (config["change"]["state"] != null)
                    {
                        switch (config["change"]["state"].ToString())
                        {
                            case "actionStateOn":
                                await light.TurnOnAsync();
                                break;
                            case "actionStateOff":
                                await light.TurnOffAsync();
                                break;
                            case "actionStateToggle":
                                if (light.getPower())
                                {
                                    await light.TurnOffAsync();
                                } else
                                {
                                    await light.TurnOnAsync();
                                }
                                break;
                            default:
                                MacroDeckLogger.Warning(PluginInstance.Main, "Attempt to apply unknown state: " + config["change"]["state"].ToString());
                                break;
                        }
                    }

                    if (config["change"]["color"] != null)
                    {
                        Color color = new Color(config["change"]["color"]["R"].ToObject<Byte>(), config["change"]["color"]["G"].ToObject<Byte>(), config["change"]["color"]["B"].ToObject<Byte>());
                        await light.SetColorAsync(color);
                    }
                }
            }
            */
        }
    }
}
