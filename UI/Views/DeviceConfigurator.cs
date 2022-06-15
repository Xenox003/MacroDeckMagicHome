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
using System.Threading.Tasks;

// Hi everyone reading, the code down here is very bad and can most likely be done way cleaner but am no pro in C# so here:

namespace Xenox003.MagicHome.Views
{
    public partial class DeviceConfigurator : DialogForm
    {
        public IPAddress IP;
        public JObject Config;

        public DeviceConfigurator(IPAddress deviceIP)
        {
            InitializeComponent();

            IP = deviceIP;
            Config = PluginConfig.getDevice(deviceIP);

            this.labelDeviceIP.Text = deviceIP.ToString();
            this.textBoxDeviceName.Text = Config["name"].ToString();
            this.checkVariables.Checked = Config["useUpdateCycle"].ToObject<bool>();

            this.onStateChangeBox.Text = Config["onStateChangeVariable"].ToString();
            this.onColorChangeBox.Text = Config["onColorChangeVariable"].ToString();

            this.checkVariables_CheckedChanged(null,null);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.textBoxDeviceName.Text != "") PluginConfig.UpdateDevice(this.IP, "name", this.textBoxDeviceName.Text);
            PluginConfig.UpdateDevice(this.IP, "useUpdateCycle", this.checkVariables.Checked);
            if (this.checkVariables.Checked)
            {
                PluginConfig.UpdateDevice(this.IP, "onStateChangeVariable", this.onStateChangeBox.Text);
                PluginConfig.UpdateDevice(this.IP, "onStateColorVariable", this.onColorChangeBox.Text);
            } else
            {
                PluginConfig.UpdateDevice(this.IP, "onStateChangeVariable", "");
                PluginConfig.UpdateDevice(this.IP, "onStateColorVariable", "");
            }

            this.Dispose();

        }

        private void checkVariables_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.containerVariables.Controls)
            {
                RoundedTextBox textBox = ctrl as RoundedTextBox;
                if (textBox != null)
                {
                    textBox.Enabled = this.checkVariables.Checked;
                }
            }
        }
    }
}
