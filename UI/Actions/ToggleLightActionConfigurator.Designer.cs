using SuchByte.MacroDeck.GUI.CustomControls;

namespace Xenox003.MagicHome.UI.Actions
{
    partial class ToggleLightActionConfigurator
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
            this.comboBoxDevice = new SuchByte.MacroDeck.GUI.CustomControls.RoundedComboBox();
            this.labelDevice = new System.Windows.Forms.Label();
            this.containerState = new System.Windows.Forms.GroupBox();
            this.radioStateToggle = new System.Windows.Forms.RadioButton();
            this.radioStateOff = new System.Windows.Forms.RadioButton();
            this.radioStateOn = new System.Windows.Forms.RadioButton();
            this.containerState.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDevice
            // 
            this.comboBoxDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.comboBoxDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDevice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxDevice.Icon = null;
            this.comboBoxDevice.Location = new System.Drawing.Point(100, 38);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.comboBoxDevice.SelectedIndex = -1;
            this.comboBoxDevice.SelectedItem = null;
            this.comboBoxDevice.Size = new System.Drawing.Size(349, 26);
            this.comboBoxDevice.TabIndex = 0;
            // 
            // labelDevice
            // 
            this.labelDevice.AutoSize = true;
            this.labelDevice.Location = new System.Drawing.Point(22, 38);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(72, 23);
            this.labelDevice.TabIndex = 1;
            this.labelDevice.Text = "Device:";
            // 
            // containerState
            // 
            this.containerState.Controls.Add(this.radioStateToggle);
            this.containerState.Controls.Add(this.radioStateOff);
            this.containerState.Controls.Add(this.radioStateOn);
            this.containerState.ForeColor = System.Drawing.Color.White;
            this.containerState.Location = new System.Drawing.Point(22, 113);
            this.containerState.Name = "containerState";
            this.containerState.Size = new System.Drawing.Size(142, 131);
            this.containerState.TabIndex = 2;
            this.containerState.TabStop = false;
            this.containerState.Text = "Device State";
            // 
            // radioStateToggle
            // 
            this.radioStateToggle.AutoSize = true;
            this.radioStateToggle.Location = new System.Drawing.Point(11, 95);
            this.radioStateToggle.Name = "radioStateToggle";
            this.radioStateToggle.Size = new System.Drawing.Size(85, 27);
            this.radioStateToggle.TabIndex = 2;
            this.radioStateToggle.TabStop = true;
            this.radioStateToggle.Text = "Toggle";
            this.radioStateToggle.UseVisualStyleBackColor = true;
            this.radioStateToggle.CheckedChanged += new System.EventHandler(this.radioStateToggle_CheckedChanged);
            // 
            // radioStateOff
            // 
            this.radioStateOff.AutoSize = true;
            this.radioStateOff.Location = new System.Drawing.Point(11, 62);
            this.radioStateOff.Name = "radioStateOff";
            this.radioStateOff.Size = new System.Drawing.Size(53, 27);
            this.radioStateOff.TabIndex = 1;
            this.radioStateOff.TabStop = true;
            this.radioStateOff.Text = "Off";
            this.radioStateOff.UseVisualStyleBackColor = true;
            this.radioStateOff.CheckedChanged += new System.EventHandler(this.radioStateOff_CheckedChanged);
            // 
            // radioStateOn
            // 
            this.radioStateOn.AutoSize = true;
            this.radioStateOn.Location = new System.Drawing.Point(11, 29);
            this.radioStateOn.Name = "radioStateOn";
            this.radioStateOn.Size = new System.Drawing.Size(52, 27);
            this.radioStateOn.TabIndex = 0;
            this.radioStateOn.TabStop = true;
            this.radioStateOn.Text = "On";
            this.radioStateOn.UseVisualStyleBackColor = true;
            this.radioStateOn.CheckedChanged += new System.EventHandler(this.radioStateOn_CheckedChanged);
            // 
            // ToggleLightActionConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.containerState);
            this.Controls.Add(this.labelDevice);
            this.Controls.Add(this.comboBoxDevice);
            this.Name = "ToggleLightActionConfigurator";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.ToggleLightActionConfigurator_Load);
            this.containerState.ResumeLayout(false);
            this.containerState.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedComboBox comboBoxDevice;
        private System.Windows.Forms.Label labelDevice;
        private System.Windows.Forms.GroupBox containerState;
        private System.Windows.Forms.RadioButton radioStateToggle;
        private System.Windows.Forms.RadioButton radioStateOff;
        private System.Windows.Forms.RadioButton radioStateOn;
    }
}