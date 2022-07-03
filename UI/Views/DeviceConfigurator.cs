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
using System.Net;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Xenox003.MagicHome.Objects;

// Hi everyone reading, the code down here is very bad and can most likely be done way cleaner but am no pro in C# so here:

namespace Xenox003.MagicHome.Views
{
    public partial class DeviceConfigurator : DialogForm
    {
        public Device device;

        public DeviceConfigurator(Device device)
        {
            InitializeComponent();

            this.device = device;

            this.labelDeviceIP.Text = this.device.IP.ToString();
            this.textBoxDeviceName.Text = this.device.Name;
            this.labelConnected.Text = this.device.Connected ? "Yes" : "No";
            this.checkVariables.Checked = this.device.UseUpdateCycle;

            this.onStateChangeBox.Text = this.device.onStateChangeVarName == null ? "" : this.device.onStateChangeVarName;
            this.onColorChangeBox.Text = this.device.onColorChangeVarName == null ? "" : this.device.onColorChangeVarName;

            this.checkVariables_CheckedChanged(null,null);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.textBoxDeviceName.Text != "") device.setName(this.textBoxDeviceName.Text);
            device.UseUpdateCycle = this.checkVariables.Checked;
            if (device.UseUpdateCycle)
            {
                device.setOnStateChangeVarName(this.onStateChangeBox.Text);
                device.setOnColorChangeVarName(this.onColorChangeBox.Text);
            } else
            {
                device.setOnStateChangeVarName(null);
                device.setOnColorChangeVarName(null);
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
