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

        private void updateDeviceList()
        {
            // Get Device List from Config \\
            JObject deviceList = PluginConfig.getDeviceList();

            // Clear Item List \\
            listDevices.Items.Clear();

            // Update Item List \\
            foreach (var obj in deviceList)
            {
                string ip = obj.Key;
                JToken value = obj.Value;

                listDevices.Items.Add(ip.ToString());
            }
        }

        private void buttonDeviceDelete_Click(object sender, EventArgs e)
        {
            var selectedItem = listDevices.SelectedItem;
            if (selectedItem != null)
            {
                PluginConfig.RemoveDevice(IPAddress.Parse(selectedItem.ToString()));
            }

            // Update Device List \\
            updateDeviceList();
        }

        private void buttonDeviceAdd_Click(object sender, EventArgs e)
        {
            // Validate IP \\
            string ipInput = boxDeviceIP.Text;
            if (!string.IsNullOrEmpty(ipInput))
            {
                try
                {
                    IPAddress deviceIP = IPAddress.Parse(ipInput);
                    PluginConfig.AddDevice(deviceIP);

                    boxDeviceIP.Text = "";
                }
                catch (Exception ex)
                {
                    MacroDeckLogger.Info(Main.Instance, "Attempt to add IP Adress " + boxDeviceIP.Text + " cancelled: \n" + ex.Message);
                }
            }

            // Update Device List \\
            updateDeviceList();
        }

        private void buttonDeviceEdit_Click(object sender, EventArgs e)
        {
            var selectedItem = listDevices.SelectedItem;
            if (selectedItem != null)
            {
                MacroDeckLogger.Info(Main.Instance, "Test");
                using (var configurator = new DeviceConfigurator())
                {
                    configurator.ShowDialog();
                }
            }
        }

        private async void buttonDeviceSearch_ClickAsync(object sender, EventArgs e)
        {
            // Disable Controls \\
            foreach (Control ctrl in containerDevices.Controls)
            {
                ctrl.Enabled = false;
            }
            this.boxDeviceIP.Text = "Searching Devices...";

            // Start Discovery \\
            LightDiscovery.Timeout = 2000;
            List<Light> discoveredLights = await LightDiscovery.DiscoverAsync();

            // Process Discovery Result \\
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

            // Enable Controls
            foreach (Control ctrl in containerDevices.Controls)
            {
                ctrl.Enabled = true;
            }
            this.boxDeviceIP.Text = "";

            // Update Device List \\
            updateDeviceList();

            // Display Info Message \\
            using var messageBox = new SuchByte.MacroDeck.GUI.CustomControls.MessageBox();
            messageBox.ShowDialog("Device Discovery", "Found " + foundCount + " device(s)\nAdded " + addedCount + " new device(s)", MessageBoxButtons.OK);
        }

        private void PluginConfigurator_Load(object sender, EventArgs e)
        {
            toolTipMain.SetToolTip(this.buttonDeviceAdd, "Add a new custom device");
            toolTipMain.SetToolTip(this.buttonDeviceDelete, "Delete an existing device");
            toolTipMain.SetToolTip(this.buttonDeviceSearch, "Search for devices in your Local Network");

            updateDeviceList();
        }
    }
}
