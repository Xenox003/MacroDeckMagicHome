using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Xenox003.MagicHome.API;
using Xenox003.MagicHome.Manager;

namespace Xenox003.MagicHome.UI.Views
{
    public partial class PluginConfigurator : DialogForm
    {
        public PluginConfigurator()
        {
            InitializeComponent();
        }


        private void updateDeviceEditor()
        {
            Light selectedDevice = listDevices.SelectedItem as Light;

            if (selectedDevice != null)
            {
                labelDeviceIP.Text = selectedDevice.getIP().ToString();
                textBoxDeviceName.Text = selectedDevice.Name;
                labelDeviceConnected.Text = selectedDevice.Connected.ToString();
            }
            else
            {
                labelDeviceIP.Text = "";
                textBoxDeviceName.Text = "";
                labelDeviceConnected.Text = "";
            }
        }
        private void updateDeviceList()
        {
            listDevices.Items.Clear();
            foreach (var device in DeviceManager.deviceList)
            {
                listDevices.Items.Add(device);
            }

            if (listDevices.Items.Count > 0)
            {
                listDevices.SelectedIndex = 0;
            }
        }

        private void PluginConfigurator_Load(object sender, EventArgs e)
        {
            toolTipMain.SetToolTip(this.buttonDeviceAdd, "Add a new custom device");
            toolTipMain.SetToolTip(this.buttonDeviceRemove, "Delete an existing device");
            toolTipMain.SetToolTip(this.buttonDeviceDiscover, "Search for devices in your Local Network");

            textBoxDiscoveryTimeout.Text = "" + PluginConfigManager.getDiscoveryTimeout();

            updateDeviceList();

            updateDeviceEditor();
        }

        private void listDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDeviceEditor();
        }

        private void buttonDeviceAdd_Click(object sender, EventArgs e)
        {
            SuchByte.MacroDeck.GUI.CustomControls.MessageBox msgBox = new SuchByte.MacroDeck.GUI.CustomControls.MessageBox();
            String ipInput = textBoxNew.Text;

            if (!string.IsNullOrEmpty(ipInput))
            {
                try
                {
                    IPAddress IP = IPAddress.Parse(ipInput);
                    DeviceManager.createDevice(IP);
                    this.textBoxNew.Text = "";
                    updateDeviceList();
                }
                catch (Exception ex)
                {
                    msgBox.ShowDialog("Device Creation", "Cannot create device with given IP Addess:\n" + ex.Message, MessageBoxButtons.OK);
                    MacroDeckLogger.Info(Main.Instance, "Attempt to add IP Adress " + ipInput + " cancelled: \n" + ex.Message);
                }
            }
        }

        private void buttonDeviceRemove_Click(object sender, EventArgs e)
        {
            Light selectedDevice = listDevices.SelectedItem as Light;

            if (selectedDevice != null)
            {
                DeviceManager.removeDevice(selectedDevice);
                updateDeviceList();
                updateDeviceEditor();
            }
        }

        private async void buttonDeviceDiscover_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Enabled = false;
            }
            this.textBoxNew.Text = "Searching Devices...";

            LightDiscovery.Timeout = PluginConfigManager.getDiscoveryTimeout();
            List<Light> discoveredLights = await LightDiscovery.DiscoverAsync();

            int addedCount = 0;
            int foundCount = discoveredLights.Count;

            foreach (Light device in discoveredLights)
            {
                Light l = DeviceManager.createDevice(device.getIP());
                if (l != null)
                {
                    addedCount++;
                }
            }

            foreach (Control ctrl in this.Controls)
            {
                ctrl.Enabled = true;
            }
            this.textBoxNew.Text = "";

            updateDeviceList();

            using var messageBox = new SuchByte.MacroDeck.GUI.CustomControls.MessageBox();
            messageBox.ShowDialog("Device Discovery","Found " + foundCount + " device(s)\nAdded " + addedCount + " new device(s)",MessageBoxButtons.OK);
        }

        private void buttonDiscoveryTimeoutSave_Click(object sender, EventArgs e)
        {
            using var messageBox = new SuchByte.MacroDeck.GUI.CustomControls.MessageBox();

            try
            {
                int timeout = Int32.Parse(textBoxDiscoveryTimeout.Text);
                PluginConfigManager.updateDiscoveryTimeout(timeout);
                messageBox.ShowDialog("Discovery Timeout", "Set Discovery Timeout to " + timeout + " ms", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                messageBox.ShowDialog("Discovery Timeout", "Error parsing number: " + ex.Message, MessageBoxButtons.OK);
            }
        }

        private void buttonSaveDevice_Click(object sender, EventArgs e)
        {
            Light selectedDevice = listDevices.SelectedItem as Light;
            if (selectedDevice != null)
            {
                using var messageBox = new SuchByte.MacroDeck.GUI.CustomControls.MessageBox();

                selectedDevice.setName(textBoxDeviceName.Text);

                DeviceManager.updateDeviceSignal(selectedDevice);
                updateDeviceList();
                updateDeviceEditor();

                messageBox.ShowDialog("Device Settings", "Saved configuration for " + selectedDevice.ToString() + "", MessageBoxButtons.OK);
            }
        }
    }
}
