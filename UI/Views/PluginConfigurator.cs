using SuchByte.MacroDeck.GUI.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Xenox003.MagicHome.Manager;

namespace Xenox003.MagicHome.UI.Views
{
    public partial class PluginConfigurator : DialogForm
    {
        public PluginConfigurator()
        {
            InitializeComponent();
        }

        private void updateDeviceList()
        {
            listDevices.Items.Clear();
            foreach (var device in DeviceManager.deviceList)
            {
                listDevices.Items.Add(device);
            }
        }

        private void PluginConfigurator_Load(object sender, EventArgs e)
        {
            toolTipMain.SetToolTip(this.buttonDeviceAdd, "Add a new custom device");
            toolTipMain.SetToolTip(this.buttonDeviceRemove, "Delete an existing device");
            toolTipMain.SetToolTip(this.buttonDeviceDiscover, "Search for devices in your Local Network");

            updateDeviceList();
        }
    }
}
