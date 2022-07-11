using Newtonsoft.Json.Linq;
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
using Xenox003.MagicHome.Manager;
using static Xenox003.MagicHome.Actions.ToggleLightAction;

namespace Xenox003.MagicHome.UI.Actions
{
    public partial class ChangeColorActionConfigurator : ActionConfigControl
    {
        private PluginAction _action;
        private API.Color selectedColor = new API.Color(0,0,0);

        public ChangeColorActionConfigurator(PluginAction action, ActionConfigurator actionConfigurator)
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
                    config["color"] = selectedColor.ToString();

                    this._action.ConfigurationSummary = config["deviceIP"] + " " + config["color"];
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

                API.Color savedColor = null;
                try
                {
                    savedColor = API.Color.Parse(config["color"].ToString());
                } catch (Exception ex) { MacroDeckLogger.Info(Main.Instance, "Internal Color Parsing error:\n" + ex.Message); }

                if (savedColor != null)
                {
                    colorDialog.Color = System.Drawing.Color.FromArgb(1,savedColor.Red, savedColor.Green, savedColor.Blue);
                    this.labelColorIndicator.Text = savedColor.ToString();
                }
            }
            else
            {
            }
            
        }

        private void buttonSelectColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = new API.Color(colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);

                this.labelColorIndicator.Text = selectedColor.ToString();
            }
        }
    }
}
