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
    public partial class PluginConfigurator : DialogForm
    {
        public PluginConfigurator()
        {
            InitializeComponent();
        }

        private void buttonDeviceSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeviceDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeviceAdd_Click(object sender, EventArgs e)
        {

        }

        private async void buttonDeviceSearch_ClickAsync(object sender, EventArgs e)
        {
            using var messageBox = new SuchByte.MacroDeck.GUI.CustomControls.MessageBox();
            LightDiscovery.Timeout = 2000;
            List<Light> discoveredLights = await LightDiscovery.DiscoverAsync();
            

            int foundCount = discoveredLights.Count;
            int addedCount = 0;
            foreach (Light light in discoveredLights)
            {
                bool added = PluginConfig.AddDevice(light.getIP());
                if (added)
                {
                    addedCount++;
                }
            }
            messageBox.ShowDialog("Device Discovery", "Found " + foundCount + " device(s)\nAdded " + addedCount + " new device(s)", MessageBoxButtons.OK);
        }

        private void PluginConfigurator_Load(object sender, EventArgs e)
        {
            toolTipMain.SetToolTip(this.buttonDeviceAdd, "Add a new custom device");
            toolTipMain.SetToolTip(this.buttonDeviceDelete, "Delete an existing device");
            toolTipMain.SetToolTip(this.buttonDeviceSave, "Save configuration");
            toolTipMain.SetToolTip(this.buttonDeviceSearch, "Search for devices in your Local Network");
        }
    }
}
