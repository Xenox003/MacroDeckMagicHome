namespace Xenox003.MagicHome.Views
{
    partial class DeviceConfigurator
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
            this.labelDeviceIP = new System.Windows.Forms.Label();
            this.textBoxDeviceName = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelConnected = new System.Windows.Forms.Label();
            this.labelDeviceConnected = new System.Windows.Forms.Label();
            this.buttonDeviceConnect = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.containerVariables = new System.Windows.Forms.GroupBox();
            this.labelVariablesDescription = new System.Windows.Forms.Label();
            this.checkVariables = new System.Windows.Forms.CheckBox();
            this.onColorChangeBox = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.onStateChangeBox = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.labelVariableColor = new System.Windows.Forms.Label();
            this.labelVariableState = new System.Windows.Forms.Label();
            this.buttonSave = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.labelConnectOutput = new System.Windows.Forms.Label();
            this.containerVariables.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDeviceIP
            // 
            this.labelDeviceIP.AutoSize = true;
            this.labelDeviceIP.Location = new System.Drawing.Point(104, 35);
            this.labelDeviceIP.Name = "labelDeviceIP";
            this.labelDeviceIP.Size = new System.Drawing.Size(103, 16);
            this.labelDeviceIP.TabIndex = 2;
            this.labelDeviceIP.Text = "000.000.000.000";
            // 
            // textBoxDeviceName
            // 
            this.textBoxDeviceName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.textBoxDeviceName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDeviceName.Icon = null;
            this.textBoxDeviceName.Location = new System.Drawing.Point(104, 61);
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
            this.textBoxDeviceName.Size = new System.Drawing.Size(293, 25);
            this.textBoxDeviceName.TabIndex = 3;
            this.textBoxDeviceName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelIP
            // 
            this.labelIP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIP.Location = new System.Drawing.Point(4, 35);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(94, 15);
            this.labelIP.TabIndex = 4;
            this.labelIP.Text = "IP Address:";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(4, 61);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(94, 25);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Device Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelConnected
            // 
            this.labelConnected.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConnected.Location = new System.Drawing.Point(7, 89);
            this.labelConnected.Name = "labelConnected";
            this.labelConnected.Size = new System.Drawing.Size(91, 28);
            this.labelConnected.TabIndex = 6;
            this.labelConnected.Text = "Connected: ";
            this.labelConnected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDeviceConnected
            // 
            this.labelDeviceConnected.AutoSize = true;
            this.labelDeviceConnected.Location = new System.Drawing.Point(104, 95);
            this.labelDeviceConnected.Name = "labelDeviceConnected";
            this.labelDeviceConnected.Size = new System.Drawing.Size(22, 16);
            this.labelDeviceConnected.TabIndex = 7;
            this.labelDeviceConnected.Text = "No";
            // 
            // buttonDeviceConnect
            // 
            this.buttonDeviceConnect.AutoSize = true;
            this.buttonDeviceConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDeviceConnect.BorderRadius = 8;
            this.buttonDeviceConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeviceConnect.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeviceConnect.ForeColor = System.Drawing.Color.White;
            this.buttonDeviceConnect.HoverColor = System.Drawing.Color.Empty;
            this.buttonDeviceConnect.Icon = null;
            this.buttonDeviceConnect.Location = new System.Drawing.Point(142, 89);
            this.buttonDeviceConnect.MinimumSize = new System.Drawing.Size(50, 25);
            this.buttonDeviceConnect.Name = "buttonDeviceConnect";
            this.buttonDeviceConnect.Progress = 0;
            this.buttonDeviceConnect.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(94)))));
            this.buttonDeviceConnect.Size = new System.Drawing.Size(65, 28);
            this.buttonDeviceConnect.TabIndex = 17;
            this.buttonDeviceConnect.Text = "Connect";
            this.buttonDeviceConnect.UseVisualStyleBackColor = true;
            this.buttonDeviceConnect.UseWindowsAccentColor = true;
            // 
            // containerVariables
            // 
            this.containerVariables.Controls.Add(this.labelVariablesDescription);
            this.containerVariables.Controls.Add(this.checkVariables);
            this.containerVariables.Controls.Add(this.onColorChangeBox);
            this.containerVariables.Controls.Add(this.onStateChangeBox);
            this.containerVariables.Controls.Add(this.labelVariableColor);
            this.containerVariables.Controls.Add(this.labelVariableState);
            this.containerVariables.ForeColor = System.Drawing.Color.White;
            this.containerVariables.Location = new System.Drawing.Point(7, 123);
            this.containerVariables.Name = "containerVariables";
            this.containerVariables.Size = new System.Drawing.Size(390, 175);
            this.containerVariables.TabIndex = 18;
            this.containerVariables.TabStop = false;
            this.containerVariables.Text = "Manage Variables";
            // 
            // labelVariablesDescription
            // 
            this.labelVariablesDescription.AutoSize = true;
            this.labelVariablesDescription.Location = new System.Drawing.Point(6, 45);
            this.labelVariablesDescription.MaximumSize = new System.Drawing.Size(375, 0);
            this.labelVariablesDescription.Name = "labelVariablesDescription";
            this.labelVariablesDescription.Size = new System.Drawing.Size(349, 48);
            this.labelVariablesDescription.TabIndex = 24;
            this.labelVariablesDescription.Text = "WARNING: When using variables, your network traffic will increase because the plu" +
    "gin needs to send a request to the device every update cycle to update the varia" +
    "bles.";
            // 
            // checkVariables
            // 
            this.checkVariables.AutoSize = true;
            this.checkVariables.Location = new System.Drawing.Point(6, 22);
            this.checkVariables.Name = "checkVariables";
            this.checkVariables.Size = new System.Drawing.Size(104, 20);
            this.checkVariables.TabIndex = 23;
            this.checkVariables.Text = "Use Variables";
            this.checkVariables.UseVisualStyleBackColor = true;
            this.checkVariables.CheckedChanged += new System.EventHandler(this.checkVariables_CheckedChanged);
            // 
            // onColorChangeBox
            // 
            this.onColorChangeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.onColorChangeBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.onColorChangeBox.Icon = null;
            this.onColorChangeBox.Location = new System.Drawing.Point(210, 140);
            this.onColorChangeBox.MaxCharacters = 32767;
            this.onColorChangeBox.Multiline = false;
            this.onColorChangeBox.Name = "onColorChangeBox";
            this.onColorChangeBox.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.onColorChangeBox.PasswordChar = false;
            this.onColorChangeBox.PlaceHolderColor = System.Drawing.Color.Gray;
            this.onColorChangeBox.PlaceHolderText = "";
            this.onColorChangeBox.ReadOnly = false;
            this.onColorChangeBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.onColorChangeBox.SelectionStart = 0;
            this.onColorChangeBox.Size = new System.Drawing.Size(150, 25);
            this.onColorChangeBox.TabIndex = 22;
            this.onColorChangeBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // onStateChangeBox
            // 
            this.onStateChangeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.onStateChangeBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.onStateChangeBox.Icon = null;
            this.onStateChangeBox.Location = new System.Drawing.Point(10, 140);
            this.onStateChangeBox.MaxCharacters = 32767;
            this.onStateChangeBox.Multiline = false;
            this.onStateChangeBox.Name = "onStateChangeBox";
            this.onStateChangeBox.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.onStateChangeBox.PasswordChar = false;
            this.onStateChangeBox.PlaceHolderColor = System.Drawing.Color.Gray;
            this.onStateChangeBox.PlaceHolderText = "";
            this.onStateChangeBox.ReadOnly = false;
            this.onStateChangeBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.onStateChangeBox.SelectionStart = 0;
            this.onStateChangeBox.Size = new System.Drawing.Size(150, 25);
            this.onStateChangeBox.TabIndex = 20;
            this.onStateChangeBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelVariableColor
            // 
            this.labelVariableColor.AutoSize = true;
            this.labelVariableColor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVariableColor.Location = new System.Drawing.Point(210, 121);
            this.labelVariableColor.Name = "labelVariableColor";
            this.labelVariableColor.Size = new System.Drawing.Size(112, 16);
            this.labelVariableColor.TabIndex = 21;
            this.labelVariableColor.Text = "onColorChanged";
            this.labelVariableColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVariableState
            // 
            this.labelVariableState.AutoSize = true;
            this.labelVariableState.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVariableState.Location = new System.Drawing.Point(10, 121);
            this.labelVariableState.Name = "labelVariableState";
            this.labelVariableState.Size = new System.Drawing.Size(150, 16);
            this.labelVariableState.TabIndex = 20;
            this.labelVariableState.Text = "onDeviceStateChange";
            this.labelVariableState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.BorderRadius = 8;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.HoverColor = System.Drawing.Color.Empty;
            this.buttonSave.Icon = null;
            this.buttonSave.Location = new System.Drawing.Point(175, 308);
            this.buttonSave.MinimumSize = new System.Drawing.Size(50, 25);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Progress = 0;
            this.buttonSave.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(94)))));
            this.buttonSave.Size = new System.Drawing.Size(50, 28);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.UseWindowsAccentColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelConnectOutput
            // 
            this.labelConnectOutput.Location = new System.Drawing.Point(213, 89);
            this.labelConnectOutput.Name = "labelConnectOutput";
            this.labelConnectOutput.Size = new System.Drawing.Size(184, 28);
            this.labelConnectOutput.TabIndex = 19;
            this.labelConnectOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeviceConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(405, 340);
            this.Controls.Add(this.labelConnectOutput);
            this.Controls.Add(this.containerVariables);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDeviceConnect);
            this.Controls.Add(this.labelDeviceConnected);
            this.Controls.Add(this.labelConnected);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.textBoxDeviceName);
            this.Controls.Add(this.labelDeviceIP);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "DeviceConfigurator";
            this.Controls.SetChildIndex(this.labelDeviceIP, 0);
            this.Controls.SetChildIndex(this.textBoxDeviceName, 0);
            this.Controls.SetChildIndex(this.labelIP, 0);
            this.Controls.SetChildIndex(this.labelName, 0);
            this.Controls.SetChildIndex(this.labelConnected, 0);
            this.Controls.SetChildIndex(this.labelDeviceConnected, 0);
            this.Controls.SetChildIndex(this.buttonDeviceConnect, 0);
            this.Controls.SetChildIndex(this.buttonSave, 0);
            this.Controls.SetChildIndex(this.containerVariables, 0);
            this.Controls.SetChildIndex(this.labelConnectOutput, 0);
            this.containerVariables.ResumeLayout(false);
            this.containerVariables.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label labelDeviceIP;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox textBoxDeviceName;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelConnected;
        private System.Windows.Forms.Label labelDeviceConnected;
        private SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary buttonDeviceConnect;
        private System.Windows.Forms.GroupBox containerVariables;
        private SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary buttonSave;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox onColorChangeBox;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox onStateChangeBox;
        private System.Windows.Forms.Label labelVariableColor;
        private System.Windows.Forms.Label labelVariableState;
        private System.Windows.Forms.Label labelConnectOutput;
        private System.Windows.Forms.Label labelVariablesDescription;
        private System.Windows.Forms.CheckBox checkVariables;
    }
}