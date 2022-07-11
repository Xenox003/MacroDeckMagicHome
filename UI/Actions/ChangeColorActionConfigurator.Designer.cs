using SuchByte.MacroDeck.GUI.CustomControls;

namespace Xenox003.MagicHome.UI.Actions
{
    partial class ChangeColorActionConfigurator
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonSelectColor = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.labelColorIndicator = new System.Windows.Forms.Label();
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
            // buttonSelectColor
            // 
            this.buttonSelectColor.BorderRadius = 8;
            this.buttonSelectColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectColor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSelectColor.ForeColor = System.Drawing.Color.White;
            this.buttonSelectColor.HoverColor = System.Drawing.Color.Empty;
            this.buttonSelectColor.Icon = null;
            this.buttonSelectColor.Location = new System.Drawing.Point(100, 70);
            this.buttonSelectColor.Name = "buttonSelectColor";
            this.buttonSelectColor.Progress = 0;
            this.buttonSelectColor.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(205)))));
            this.buttonSelectColor.Size = new System.Drawing.Size(91, 23);
            this.buttonSelectColor.TabIndex = 2;
            this.buttonSelectColor.Text = "Select Color";
            this.buttonSelectColor.UseVisualStyleBackColor = true;
            this.buttonSelectColor.UseWindowsAccentColor = true;
            this.buttonSelectColor.Click += new System.EventHandler(this.buttonSelectColor_Click);
            // 
            // labelColorIndicator
            // 
            this.labelColorIndicator.AutoSize = true;
            this.labelColorIndicator.Location = new System.Drawing.Point(197, 70);
            this.labelColorIndicator.Name = "labelColorIndicator";
            this.labelColorIndicator.Size = new System.Drawing.Size(88, 23);
            this.labelColorIndicator.TabIndex = 3;
            this.labelColorIndicator.Text = "R0 G0 B0";
            // 
            // ChangeColorActionConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelColorIndicator);
            this.Controls.Add(this.buttonSelectColor);
            this.Controls.Add(this.labelDevice);
            this.Controls.Add(this.comboBoxDevice);
            this.Name = "ChangeColorActionConfigurator";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.ToggleLightActionConfigurator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedComboBox comboBoxDevice;
        private System.Windows.Forms.Label labelDevice;
        private System.Windows.Forms.ColorDialog colorDialog;
        private SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary buttonSelectColor;
        private System.Windows.Forms.Label labelColorIndicator;
    }
}