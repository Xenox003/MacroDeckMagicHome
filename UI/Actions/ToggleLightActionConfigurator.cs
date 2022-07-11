using Newtonsoft.Json.Linq;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Xenox003.MagicHome.API;
using Xenox003.MagicHome.Manager;
using static Xenox003.MagicHome.Actions.ToggleLightAction;

namespace Xenox003.MagicHome.UI.Actions
{
    public partial class ToggleLightActionConfigurator : ActionConfigControl
    {
        private PluginAction _action;
        private ToggleState selectedState;

        public ToggleLightActionConfigurator(PluginAction action, ActionConfigurator actionConfigurator)
        {
            this._action = action;
            InitializeComponent();
        }

        public override bool OnActionSave()
        {
            if (comboBoxDevice.SelectedItem != null)
            {
                JObject config = new JObject();
                Light device = comboBoxDevice.SelectedItem as Light;

                if (device != null)
                {
                    config["deviceIP"] = device.getIP().ToString();
                    config["toggleOption"] = selectedState.ToString();

                    this._action.ConfigurationSummary = config["deviceIP"] + " " + config["toggleOption"];
                    this._action.Configuration = config.ToString();

                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        private void ToggleLightActionConfigurator_Load(object sender, EventArgs e)
        {
            comboBoxDevice.Items.Clear();

            for (int i = 0; i < DeviceManager.deviceList.Count; i++)
            {
                comboBoxDevice.Items.Add(DeviceManager.deviceList[i]);
                if (this._action.Configuration != null && (DeviceManager.deviceList[i].getIP().ToString() == JObject.Parse(this._action.Configuration)["deviceIP"].ToString()))
                {
                    comboBoxDevice.SelectedIndex = i;
                }
            }

            if (this._action.Configuration != null)
            {
                JObject config = JObject.Parse(this._action.Configuration);

                ToggleState toggleState = (ToggleState) Enum.Parse(typeof(ToggleState), config["toggleOption"].ToString());
                switch (toggleState) {
                    case ToggleState.TOGGLE:
                        this.radioStateToggle.Checked = true;
                        break;
                    case ToggleState.ON:
                        this.radioStateOn.Checked = true;
                        break;
                    case ToggleState.OFF:
                        this.radioStateOff.Checked = true;
                        break;
                    default:
                        break;
                }

                this.selectedState = toggleState;
            }
            else
            {
                radioStateToggle.Checked = true;
                this.selectedState = ToggleState.TOGGLE;
            }
            
        }

        private void radioStateOn_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedState = ToggleState.ON;
        }

        private void radioStateOff_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedState = ToggleState.OFF;
        }

        private void radioStateToggle_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedState = ToggleState.TOGGLE;
        }
    }
}
