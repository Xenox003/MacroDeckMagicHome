using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Logging;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Xenox003.MagicHome.API;
using System.Net;
using Newtonsoft.Json.Linq;

// Hi everyone reading, the code down here is very bad and can most likely be done way cleaner but am no pro in C# so here:

namespace Xenox003.MagicHome.Views
{
    public partial class UpdateLightConfigurator : ActionConfigControl
    {
        private PluginAction _action;
        private List<Light> lights;
        public UpdateLightConfigurator(PluginAction action, ActionConfigurator actionConfigurator)
        {
            this._action = action;
            InitializeComponent();

            
        }

        public override bool OnActionSave()
        {
            if (selectList.SelectedItem != null)
            {
                try
                {
                    JObject configuration = new JObject();

                    configuration["selectedLightIP"] = selectList.SelectedItem.ToString();

                    JObject change = new JObject();
                    if (actionChangeColor.Checked)
                    {
                        JObject color = new JObject();
                        color["R"] = actionColorR.Value;
                        color["G"] = actionColorG.Value;
                        color["B"] = actionColorB.Value;

                        change["color"] = color;
                    }
                    if (actionToggleOnOff.Checked)
                    {
                        foreach (var control in actionStateContainer.Controls)
                        {
                            RadioButton radio = control as RadioButton;
                            if (radio != null && radio.Checked)
                            {
                                change["state"] = radio.Name;
                            }
                        }
                    }

                    configuration["change"] = change;

                    this._action.ConfigurationSummary = configuration["selectedLightIP"].ToString();
                    this._action.Configuration = configuration.ToString();
                }
                catch { }

                return true;
            }
            else
            {
                return false;
            }
        }

        private void TestActionConfigurator_Load(object sender, EventArgs e)
        {
            this.lights = Main.getDiscoveredLights();
            foreach (Light light in this.lights)
            {
                selectList.Items.Add(light.getIP().ToString());
            }

            actionChangeColor.Checked = true;
            actionToggleOnOff.Checked = true;

            if (this._action.Configuration != null)
            {
                JObject config = JObject.Parse(this._action.Configuration);
                if (config["selectedLightIP"] != null)
                {
                    selectList.SelectedItem = config["selectedLightIP"].ToString();
                }

                if (config["change"] != null)
                {
                    if (config["change"]["color"] != null)
                    {
                        actionChangeColor.Checked = true;

                        actionColorR.Value = config["change"]["color"]["R"].ToObject<int>();
                        actionColorG.Value = config["change"]["color"]["G"].ToObject<int>();
                        actionColorB.Value = config["change"]["color"]["B"].ToObject<int>();

                        actionColorRValue.Text = config["change"]["color"]["R"].ToObject<String>();
                        actionColorGValue.Text = config["change"]["color"]["G"].ToObject<String>();
                        actionColorBValue.Text = config["change"]["color"]["B"].ToObject<String>();
                    } else
                    {
                        actionChangeColor.Checked = false;
                    }
                    if (config["change"]["state"] != null)
                    {
                        RadioButton button = actionStateContainer.Controls.Find(config["change"]["state"].ToString(),true)[0] as RadioButton;
                        if (button != null)
                        {
                            button.Checked = true;
                        }
                    } else
                    {
                        actionToggleOnOff.Checked = false;
                    }
                }
            }
        }

        private void actionColorR_Scroll(object sender, EventArgs e)
        {
            actionColorRValue.Text = actionColorR.Value.ToString();
        }

        private void actionColorB_Scroll(object sender, EventArgs e)
        {
            actionColorBValue.Text = actionColorB.Value.ToString();
        }

        private void actionColorG_Scroll(object sender, EventArgs e)
        {
            actionColorGValue.Text = actionColorG.Value.ToString();
        }

        private void actionToggleOnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (!actionToggleOnOff.Checked && !actionChangeColor.Checked)
            {
                actionChangeColor.Checked = true;
            }
            actionToggleUpdate(sender, e);
        }

        private void actionChangeColor_CheckedChanged(object sender, EventArgs e)
        {
            if (!actionChangeColor.Checked && !actionToggleOnOff.Checked)
            {
                actionToggleOnOff.Checked = true;
            }
            actionToggleUpdate(sender, e);
        }

        private void actionToggleUpdate(object sender, EventArgs e)
        {
            // Color Changer
            foreach (var element in actionColorContainer.Controls)
            {
                Control controlElement = element as Control;
                if (controlElement != null)
                {
                    controlElement.Enabled = actionChangeColor.Checked;
                }
            }

            // State Changer
            foreach (var element in actionStateContainer.Controls)
            {
                Control controlElement = element as Control;
                if (controlElement != null)
                {
                    controlElement.Enabled = actionToggleOnOff.Checked;
                }
            }
        }
    }
}
