using SuchByte.MacroDeck.GUI.CustomControls;

namespace Xenox003.MagicHome.UI.Views
{
    partial class PluginConfigurator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginConfigurator));
            this.listDevices = new System.Windows.Forms.ListBox();
            this.containerDevice = new System.Windows.Forms.GroupBox();
            this.labelDeviceIP = new System.Windows.Forms.Label();
            this.labelDeviceName = new System.Windows.Forms.Label();
            this.textBoxDeviceName = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.labelDeviceIPTitle = new System.Windows.Forms.Label();
            this.buttonDeviceAdd = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.buttonDeviceRemove = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.buttonDeviceDiscover = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.labelDevices = new System.Windows.Forms.Label();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxNew = new System.Windows.Forms.TextBox();
            this.labelDiscoveryTimeout = new System.Windows.Forms.Label();
            this.textBoxDiscoveryTimeout = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.labelDiscoveryTimeoutSuffix = new System.Windows.Forms.Label();
            this.buttonDiscoveryTimeoutSave = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.buttonSaveDevice = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.labelDeviceConnectedTitle = new System.Windows.Forms.Label();
            this.labelDeviceConnected = new System.Windows.Forms.Label();
            this.containerDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // listDevices
            // 
            this.listDevices.FormattingEnabled = true;
            this.listDevices.ItemHeight = 16;
            this.listDevices.Location = new System.Drawing.Point(4, 90);
            this.listDevices.Name = "listDevices";
            this.listDevices.Size = new System.Drawing.Size(172, 196);
            this.listDevices.TabIndex = 2;
            this.listDevices.SelectedIndexChanged += new System.EventHandler(this.listDevices_SelectedIndexChanged);
            // 
            // containerDevice
            // 
            this.containerDevice.Controls.Add(this.labelDeviceConnected);
            this.containerDevice.Controls.Add(this.labelDeviceConnectedTitle);
            this.containerDevice.Controls.Add(this.buttonSaveDevice);
            this.containerDevice.Controls.Add(this.labelDeviceIP);
            this.containerDevice.Controls.Add(this.labelDeviceName);
            this.containerDevice.Controls.Add(this.textBoxDeviceName);
            this.containerDevice.Controls.Add(this.labelDeviceIPTitle);
            this.containerDevice.ForeColor = System.Drawing.Color.White;
            this.containerDevice.Location = new System.Drawing.Point(182, 54);
            this.containerDevice.Name = "containerDevice";
            this.containerDevice.Size = new System.Drawing.Size(441, 232);
            this.containerDevice.TabIndex = 3;
            this.containerDevice.TabStop = false;
            // 
            // labelDeviceIP
            // 
            this.labelDeviceIP.AutoSize = true;
            this.labelDeviceIP.Location = new System.Drawing.Point(58, 22);
            this.labelDeviceIP.Name = "labelDeviceIP";
            this.labelDeviceIP.Size = new System.Drawing.Size(103, 16);
            this.labelDeviceIP.TabIndex = 4;
            this.labelDeviceIP.Text = "000.000.000.000";
            this.labelDeviceIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDeviceName
            // 
            this.labelDeviceName.AutoSize = true;
            this.labelDeviceName.Location = new System.Drawing.Point(6, 53);
            this.labelDeviceName.Name = "labelDeviceName";
            this.labelDeviceName.Size = new System.Drawing.Size(45, 16);
            this.labelDeviceName.TabIndex = 3;
            this.labelDeviceName.Text = "Name:";
            this.labelDeviceName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDeviceName
            // 
            this.textBoxDeviceName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.textBoxDeviceName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDeviceName.Icon = null;
            this.textBoxDeviceName.Location = new System.Drawing.Point(58, 49);
            this.textBoxDeviceName.MaxCharacters = 32767;
            this.textBoxDeviceName.Multiline = false;
            this.textBoxDeviceName.Name = "textBoxDeviceName";
            this.textBoxDeviceName.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.textBoxDeviceName.PasswordChar = false;
            this.textBoxDeviceName.PlaceHolderColor = System.Drawing.Color.Gray;
            this.textBoxDeviceName.PlaceHolderText = "";
            this.textBoxDeviceName.ReadOnly = false;
            this.textBoxDeviceName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxDeviceName.SelectionStart = 0;
            this.textBoxDeviceName.Size = new System.Drawing.Size(370, 25);
            this.textBoxDeviceName.TabIndex = 2;
            this.textBoxDeviceName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelDeviceIPTitle
            // 
            this.labelDeviceIPTitle.AutoSize = true;
            this.labelDeviceIPTitle.Location = new System.Drawing.Point(6, 22);
            this.labelDeviceIPTitle.Name = "labelDeviceIPTitle";
            this.labelDeviceIPTitle.Size = new System.Drawing.Size(23, 16);
            this.labelDeviceIPTitle.TabIndex = 1;
            this.labelDeviceIPTitle.Text = "IP:";
            this.labelDeviceIPTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDeviceAdd
            // 
            this.buttonDeviceAdd.BorderRadius = 8;
            this.buttonDeviceAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeviceAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeviceAdd.ForeColor = System.Drawing.Color.White;
            this.buttonDeviceAdd.HoverColor = System.Drawing.Color.Empty;
            this.buttonDeviceAdd.Icon = global::Xenox003.MagicHome.Properties.Resources.Add_450;
            this.buttonDeviceAdd.Location = new System.Drawing.Point(89, 26);
            this.buttonDeviceAdd.Name = "buttonDeviceAdd";
            this.buttonDeviceAdd.Progress = 0;
            this.buttonDeviceAdd.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(205)))));
            this.buttonDeviceAdd.Size = new System.Drawing.Size(25, 25);
            this.buttonDeviceAdd.TabIndex = 0;
            this.buttonDeviceAdd.UseVisualStyleBackColor = true;
            this.buttonDeviceAdd.UseWindowsAccentColor = true;
            this.buttonDeviceAdd.Click += new System.EventHandler(this.buttonDeviceAdd_Click);
            // 
            // buttonDeviceRemove
            // 
            this.buttonDeviceRemove.BorderRadius = 8;
            this.buttonDeviceRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeviceRemove.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeviceRemove.ForeColor = System.Drawing.Color.White;
            this.buttonDeviceRemove.HoverColor = System.Drawing.Color.Empty;
            this.buttonDeviceRemove.Icon = ((System.Drawing.Image)(resources.GetObject("buttonDeviceRemove.Icon")));
            this.buttonDeviceRemove.Location = new System.Drawing.Point(120, 27);
            this.buttonDeviceRemove.Name = "buttonDeviceRemove";
            this.buttonDeviceRemove.Progress = 0;
            this.buttonDeviceRemove.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(205)))));
            this.buttonDeviceRemove.Size = new System.Drawing.Size(25, 25);
            this.buttonDeviceRemove.TabIndex = 4;
            this.buttonDeviceRemove.UseVisualStyleBackColor = true;
            this.buttonDeviceRemove.UseWindowsAccentColor = true;
            this.buttonDeviceRemove.Click += new System.EventHandler(this.buttonDeviceRemove_Click);
            // 
            // buttonDeviceDiscover
            // 
            this.buttonDeviceDiscover.BorderRadius = 8;
            this.buttonDeviceDiscover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeviceDiscover.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeviceDiscover.ForeColor = System.Drawing.Color.White;
            this.buttonDeviceDiscover.HoverColor = System.Drawing.Color.Empty;
            this.buttonDeviceDiscover.Icon = ((System.Drawing.Image)(resources.GetObject("buttonDeviceDiscover.Icon")));
            this.buttonDeviceDiscover.Location = new System.Drawing.Point(151, 27);
            this.buttonDeviceDiscover.Name = "buttonDeviceDiscover";
            this.buttonDeviceDiscover.Progress = 0;
            this.buttonDeviceDiscover.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(205)))));
            this.buttonDeviceDiscover.Size = new System.Drawing.Size(25, 25);
            this.buttonDeviceDiscover.TabIndex = 5;
            this.buttonDeviceDiscover.UseVisualStyleBackColor = true;
            this.buttonDeviceDiscover.UseWindowsAccentColor = true;
            this.buttonDeviceDiscover.Click += new System.EventHandler(this.buttonDeviceDiscover_Click);
            // 
            // labelDevices
            // 
            this.labelDevices.AutoSize = true;
            this.labelDevices.Location = new System.Drawing.Point(4, 35);
            this.labelDevices.Name = "labelDevices";
            this.labelDevices.Size = new System.Drawing.Size(50, 16);
            this.labelDevices.TabIndex = 6;
            this.labelDevices.Text = "Devices";
            // 
            // textBoxNew
            // 
            this.textBoxNew.Location = new System.Drawing.Point(4, 61);
            this.textBoxNew.Name = "textBoxNew";
            this.textBoxNew.PlaceholderText = "Enter new IP Address";
            this.textBoxNew.Size = new System.Drawing.Size(172, 23);
            this.textBoxNew.TabIndex = 7;
            // 
            // labelDiscoveryTimeout
            // 
            this.labelDiscoveryTimeout.AutoSize = true;
            this.labelDiscoveryTimeout.Location = new System.Drawing.Point(188, 31);
            this.labelDiscoveryTimeout.Name = "labelDiscoveryTimeout";
            this.labelDiscoveryTimeout.Size = new System.Drawing.Size(117, 16);
            this.labelDiscoveryTimeout.TabIndex = 6;
            this.labelDiscoveryTimeout.Text = "Discovery Timeout:";
            this.labelDiscoveryTimeout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDiscoveryTimeout
            // 
            this.textBoxDiscoveryTimeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.textBoxDiscoveryTimeout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDiscoveryTimeout.Icon = null;
            this.textBoxDiscoveryTimeout.Location = new System.Drawing.Point(310, 27);
            this.textBoxDiscoveryTimeout.MaxCharacters = 32767;
            this.textBoxDiscoveryTimeout.Multiline = false;
            this.textBoxDiscoveryTimeout.Name = "textBoxDiscoveryTimeout";
            this.textBoxDiscoveryTimeout.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.textBoxDiscoveryTimeout.PasswordChar = false;
            this.textBoxDiscoveryTimeout.PlaceHolderColor = System.Drawing.Color.Gray;
            this.textBoxDiscoveryTimeout.PlaceHolderText = "";
            this.textBoxDiscoveryTimeout.ReadOnly = false;
            this.textBoxDiscoveryTimeout.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxDiscoveryTimeout.SelectionStart = 0;
            this.textBoxDiscoveryTimeout.Size = new System.Drawing.Size(91, 25);
            this.textBoxDiscoveryTimeout.TabIndex = 5;
            this.textBoxDiscoveryTimeout.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelDiscoveryTimeoutSuffix
            // 
            this.labelDiscoveryTimeoutSuffix.AutoSize = true;
            this.labelDiscoveryTimeoutSuffix.Location = new System.Drawing.Point(407, 31);
            this.labelDiscoveryTimeoutSuffix.Name = "labelDiscoveryTimeoutSuffix";
            this.labelDiscoveryTimeoutSuffix.Size = new System.Drawing.Size(24, 16);
            this.labelDiscoveryTimeoutSuffix.TabIndex = 8;
            this.labelDiscoveryTimeoutSuffix.Text = "ms";
            this.labelDiscoveryTimeoutSuffix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDiscoveryTimeoutSave
            // 
            this.buttonDiscoveryTimeoutSave.BorderRadius = 8;
            this.buttonDiscoveryTimeoutSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiscoveryTimeoutSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDiscoveryTimeoutSave.ForeColor = System.Drawing.Color.White;
            this.buttonDiscoveryTimeoutSave.HoverColor = System.Drawing.Color.Empty;
            this.buttonDiscoveryTimeoutSave.Icon = null;
            this.buttonDiscoveryTimeoutSave.Location = new System.Drawing.Point(448, 29);
            this.buttonDiscoveryTimeoutSave.Name = "buttonDiscoveryTimeoutSave";
            this.buttonDiscoveryTimeoutSave.Progress = 0;
            this.buttonDiscoveryTimeoutSave.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(205)))));
            this.buttonDiscoveryTimeoutSave.Size = new System.Drawing.Size(75, 23);
            this.buttonDiscoveryTimeoutSave.TabIndex = 9;
            this.buttonDiscoveryTimeoutSave.Text = "Save";
            this.buttonDiscoveryTimeoutSave.UseVisualStyleBackColor = true;
            this.buttonDiscoveryTimeoutSave.UseWindowsAccentColor = true;
            this.buttonDiscoveryTimeoutSave.Click += new System.EventHandler(this.buttonDiscoveryTimeoutSave_Click);
            // 
            // buttonSaveDevice
            // 
            this.buttonSaveDevice.BorderRadius = 8;
            this.buttonSaveDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveDevice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveDevice.ForeColor = System.Drawing.Color.White;
            this.buttonSaveDevice.HoverColor = System.Drawing.Color.Empty;
            this.buttonSaveDevice.Icon = null;
            this.buttonSaveDevice.Location = new System.Drawing.Point(360, 203);
            this.buttonSaveDevice.Name = "buttonSaveDevice";
            this.buttonSaveDevice.Progress = 0;
            this.buttonSaveDevice.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(205)))));
            this.buttonSaveDevice.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveDevice.TabIndex = 10;
            this.buttonSaveDevice.Text = "Save";
            this.buttonSaveDevice.UseVisualStyleBackColor = true;
            this.buttonSaveDevice.UseWindowsAccentColor = true;
            this.buttonSaveDevice.Click += new System.EventHandler(this.buttonSaveDevice_Click);
            // 
            // labelDeviceConnectedTitle
            // 
            this.labelDeviceConnectedTitle.AutoSize = true;
            this.labelDeviceConnectedTitle.Location = new System.Drawing.Point(6, 86);
            this.labelDeviceConnectedTitle.Name = "labelDeviceConnectedTitle";
            this.labelDeviceConnectedTitle.Size = new System.Drawing.Size(72, 16);
            this.labelDeviceConnectedTitle.TabIndex = 11;
            this.labelDeviceConnectedTitle.Text = "Connected:";
            this.labelDeviceConnectedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDeviceConnected
            // 
            this.labelDeviceConnected.AutoSize = true;
            this.labelDeviceConnected.Location = new System.Drawing.Point(78, 86);
            this.labelDeviceConnected.Name = "labelDeviceConnected";
            this.labelDeviceConnected.Size = new System.Drawing.Size(37, 16);
            this.labelDeviceConnected.TabIndex = 12;
            this.labelDeviceConnected.Text = "------";
            this.labelDeviceConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PluginConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 312);
            this.Controls.Add(this.buttonDiscoveryTimeoutSave);
            this.Controls.Add(this.labelDiscoveryTimeoutSuffix);
            this.Controls.Add(this.labelDiscoveryTimeout);
            this.Controls.Add(this.textBoxNew);
            this.Controls.Add(this.textBoxDiscoveryTimeout);
            this.Controls.Add(this.labelDevices);
            this.Controls.Add(this.buttonDeviceDiscover);
            this.Controls.Add(this.buttonDeviceRemove);
            this.Controls.Add(this.buttonDeviceAdd);
            this.Controls.Add(this.containerDevice);
            this.Controls.Add(this.listDevices);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PluginConfigurator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PluginConfigurator_Load);
            this.Controls.SetChildIndex(this.listDevices, 0);
            this.Controls.SetChildIndex(this.containerDevice, 0);
            this.Controls.SetChildIndex(this.buttonDeviceAdd, 0);
            this.Controls.SetChildIndex(this.buttonDeviceRemove, 0);
            this.Controls.SetChildIndex(this.buttonDeviceDiscover, 0);
            this.Controls.SetChildIndex(this.labelDevices, 0);
            this.Controls.SetChildIndex(this.textBoxDiscoveryTimeout, 0);
            this.Controls.SetChildIndex(this.textBoxNew, 0);
            this.Controls.SetChildIndex(this.labelDiscoveryTimeout, 0);
            this.Controls.SetChildIndex(this.labelDiscoveryTimeoutSuffix, 0);
            this.Controls.SetChildIndex(this.buttonDiscoveryTimeoutSave, 0);
            this.containerDevice.ResumeLayout(false);
            this.containerDevice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listDevices;
        private System.Windows.Forms.GroupBox containerDevice;
        private ButtonPrimary buttonDeviceAdd;
        private ButtonPrimary buttonDeviceRemove;
        private ButtonPrimary buttonDeviceDiscover;
        private System.Windows.Forms.Label labelDevices;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.Label labelDeviceIPTitle;
        private System.Windows.Forms.Label labelDeviceName;
        private RoundedTextBox textBoxDeviceName;
        private System.Windows.Forms.Label labelDeviceIP;
        private System.Windows.Forms.TextBox textBoxNew;
        private System.Windows.Forms.Label labelDiscoveryTimeout;
        private RoundedTextBox textBoxDiscoveryTimeout;
        private System.Windows.Forms.Label labelDiscoveryTimeoutSuffix;
        private ButtonPrimary buttonDiscoveryTimeoutSave;
        private ButtonPrimary buttonSaveDevice;
        private System.Windows.Forms.Label labelDeviceConnected;
        private System.Windows.Forms.Label labelDeviceConnectedTitle;
    }
}