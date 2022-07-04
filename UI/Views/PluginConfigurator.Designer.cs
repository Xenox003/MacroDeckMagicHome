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
            this.labelDeviceIPTitle = new System.Windows.Forms.Label();
            this.buttonDeviceAdd = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.buttonDeviceRemove = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.buttonDeviceDiscover = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.labelDevices = new System.Windows.Forms.Label();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.roundedTextBox1 = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.labelDeviceIP = new System.Windows.Forms.Label();
            this.containerDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // listDevices
            // 
            this.listDevices.FormattingEnabled = true;
            this.listDevices.ItemHeight = 16;
            this.listDevices.Location = new System.Drawing.Point(4, 58);
            this.listDevices.Name = "listDevices";
            this.listDevices.Size = new System.Drawing.Size(172, 228);
            this.listDevices.TabIndex = 2;
            // 
            // containerDevice
            // 
            this.containerDevice.Controls.Add(this.labelDeviceIP);
            this.containerDevice.Controls.Add(this.label1);
            this.containerDevice.Controls.Add(this.roundedTextBox1);
            this.containerDevice.Controls.Add(this.labelDeviceIPTitle);
            this.containerDevice.ForeColor = System.Drawing.Color.White;
            this.containerDevice.Location = new System.Drawing.Point(182, 51);
            this.containerDevice.Name = "containerDevice";
            this.containerDevice.Size = new System.Drawing.Size(441, 235);
            this.containerDevice.TabIndex = 3;
            this.containerDevice.TabStop = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedTextBox1
            // 
            this.roundedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.roundedTextBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundedTextBox1.Icon = null;
            this.roundedTextBox1.Location = new System.Drawing.Point(58, 49);
            this.roundedTextBox1.MaxCharacters = 32767;
            this.roundedTextBox1.Multiline = false;
            this.roundedTextBox1.Name = "roundedTextBox1";
            this.roundedTextBox1.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.roundedTextBox1.PasswordChar = false;
            this.roundedTextBox1.PlaceHolderColor = System.Drawing.Color.Gray;
            this.roundedTextBox1.PlaceHolderText = "";
            this.roundedTextBox1.ReadOnly = false;
            this.roundedTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.roundedTextBox1.SelectionStart = 0;
            this.roundedTextBox1.Size = new System.Drawing.Size(370, 25);
            this.roundedTextBox1.TabIndex = 2;
            this.roundedTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
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
            // PluginConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 312);
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
        private System.Windows.Forms.Label label1;
        private RoundedTextBox roundedTextBox1;
        private System.Windows.Forms.Label labelDeviceIP;
    }
}