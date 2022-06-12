namespace Xenox003.MagicHome.Views
{
    partial class UpdateLightConfigurator
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
            this.selectLabel = new System.Windows.Forms.Label();
            this.selectList = new SuchByte.MacroDeck.GUI.CustomControls.RoundedComboBox();
            this.actionLabel = new System.Windows.Forms.Label();
            this.actionStateOn = new System.Windows.Forms.RadioButton();
            this.actionStateOff = new System.Windows.Forms.RadioButton();
            this.actionToggleOnOff = new System.Windows.Forms.CheckBox();
            this.actionChangeColor = new System.Windows.Forms.CheckBox();
            this.actionColorR = new System.Windows.Forms.TrackBar();
            this.actionColorRLabel = new System.Windows.Forms.Label();
            this.actionColorGLabel = new System.Windows.Forms.Label();
            this.actionColorBLabel = new System.Windows.Forms.Label();
            this.actionColorB = new System.Windows.Forms.TrackBar();
            this.actionColorG = new System.Windows.Forms.TrackBar();
            this.actionColorRValue = new System.Windows.Forms.Label();
            this.actionColorGValue = new System.Windows.Forms.Label();
            this.actionColorBValue = new System.Windows.Forms.Label();
            this.actionStateToggle = new System.Windows.Forms.RadioButton();
            this.actionStateContainer = new System.Windows.Forms.Panel();
            this.actionColorContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.actionColorR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionColorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionColorG)).BeginInit();
            this.actionStateContainer.SuspendLayout();
            this.actionColorContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(3, 0);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(121, 23);
            this.selectLabel.TabIndex = 0;
            this.selectLabel.Text = "Select Device";
            // 
            // selectList
            // 
            this.selectList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.selectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectList.Icon = null;
            this.selectList.Location = new System.Drawing.Point(0, 26);
            this.selectList.Name = "selectList";
            this.selectList.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.selectList.SelectedIndex = -1;
            this.selectList.SelectedItem = null;
            this.selectList.Size = new System.Drawing.Size(512, 26);
            this.selectList.TabIndex = 1;
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Location = new System.Drawing.Point(3, 55);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(64, 23);
            this.actionLabel.TabIndex = 2;
            this.actionLabel.Text = "Values";
            // 
            // actionStateOn
            // 
            this.actionStateOn.AutoSize = true;
            this.actionStateOn.Checked = true;
            this.actionStateOn.Location = new System.Drawing.Point(10, 18);
            this.actionStateOn.Name = "actionStateOn";
            this.actionStateOn.Size = new System.Drawing.Size(52, 27);
            this.actionStateOn.TabIndex = 3;
            this.actionStateOn.TabStop = true;
            this.actionStateOn.Text = "On";
            this.actionStateOn.UseVisualStyleBackColor = true;
            // 
            // actionStateOff
            // 
            this.actionStateOff.AutoSize = true;
            this.actionStateOff.Location = new System.Drawing.Point(68, 18);
            this.actionStateOff.Name = "actionStateOff";
            this.actionStateOff.Size = new System.Drawing.Size(53, 27);
            this.actionStateOff.TabIndex = 4;
            this.actionStateOff.Text = "Off";
            this.actionStateOff.UseVisualStyleBackColor = true;
            // 
            // actionToggleOnOff
            // 
            this.actionToggleOnOff.AutoSize = true;
            this.actionToggleOnOff.Location = new System.Drawing.Point(3, 93);
            this.actionToggleOnOff.Name = "actionToggleOnOff";
            this.actionToggleOnOff.Size = new System.Drawing.Size(200, 27);
            this.actionToggleOnOff.TabIndex = 5;
            this.actionToggleOnOff.Text = "Update On/Off State";
            this.actionToggleOnOff.UseVisualStyleBackColor = true;
            this.actionToggleOnOff.CheckedChanged += new System.EventHandler(this.actionToggleOnOff_CheckedChanged);
            // 
            // actionChangeColor
            // 
            this.actionChangeColor.AutoSize = true;
            this.actionChangeColor.Location = new System.Drawing.Point(277, 93);
            this.actionChangeColor.Name = "actionChangeColor";
            this.actionChangeColor.Size = new System.Drawing.Size(137, 27);
            this.actionChangeColor.TabIndex = 6;
            this.actionChangeColor.Text = "Update Color";
            this.actionChangeColor.UseVisualStyleBackColor = true;
            this.actionChangeColor.CheckedChanged += new System.EventHandler(this.actionChangeColor_CheckedChanged);
            // 
            // actionColorR
            // 
            this.actionColorR.Location = new System.Drawing.Point(70, 11);
            this.actionColorR.Maximum = 255;
            this.actionColorR.Name = "actionColorR";
            this.actionColorR.Size = new System.Drawing.Size(254, 45);
            this.actionColorR.TabIndex = 7;
            this.actionColorR.Scroll += new System.EventHandler(this.actionColorR_Scroll);
            // 
            // actionColorRLabel
            // 
            this.actionColorRLabel.AutoSize = true;
            this.actionColorRLabel.Location = new System.Drawing.Point(3, 11);
            this.actionColorRLabel.Name = "actionColorRLabel";
            this.actionColorRLabel.Size = new System.Drawing.Size(43, 23);
            this.actionColorRLabel.TabIndex = 8;
            this.actionColorRLabel.Text = "Red";
            // 
            // actionColorGLabel
            // 
            this.actionColorGLabel.AutoSize = true;
            this.actionColorGLabel.Location = new System.Drawing.Point(3, 60);
            this.actionColorGLabel.Name = "actionColorGLabel";
            this.actionColorGLabel.Size = new System.Drawing.Size(61, 23);
            this.actionColorGLabel.TabIndex = 9;
            this.actionColorGLabel.Text = "Green";
            // 
            // actionColorBLabel
            // 
            this.actionColorBLabel.AutoSize = true;
            this.actionColorBLabel.Location = new System.Drawing.Point(3, 111);
            this.actionColorBLabel.Name = "actionColorBLabel";
            this.actionColorBLabel.Size = new System.Drawing.Size(46, 23);
            this.actionColorBLabel.TabIndex = 10;
            this.actionColorBLabel.Text = "Blue";
            // 
            // actionColorB
            // 
            this.actionColorB.Location = new System.Drawing.Point(70, 111);
            this.actionColorB.Maximum = 255;
            this.actionColorB.Name = "actionColorB";
            this.actionColorB.Size = new System.Drawing.Size(254, 45);
            this.actionColorB.TabIndex = 11;
            this.actionColorB.Scroll += new System.EventHandler(this.actionColorB_Scroll);
            // 
            // actionColorG
            // 
            this.actionColorG.Location = new System.Drawing.Point(70, 60);
            this.actionColorG.Maximum = 255;
            this.actionColorG.Name = "actionColorG";
            this.actionColorG.Size = new System.Drawing.Size(254, 45);
            this.actionColorG.TabIndex = 12;
            this.actionColorG.Scroll += new System.EventHandler(this.actionColorG_Scroll);
            // 
            // actionColorRValue
            // 
            this.actionColorRValue.AutoSize = true;
            this.actionColorRValue.Location = new System.Drawing.Point(330, 9);
            this.actionColorRValue.Name = "actionColorRValue";
            this.actionColorRValue.Size = new System.Drawing.Size(20, 23);
            this.actionColorRValue.TabIndex = 13;
            this.actionColorRValue.Text = "0";
            // 
            // actionColorGValue
            // 
            this.actionColorGValue.AutoSize = true;
            this.actionColorGValue.Location = new System.Drawing.Point(330, 60);
            this.actionColorGValue.Name = "actionColorGValue";
            this.actionColorGValue.Size = new System.Drawing.Size(20, 23);
            this.actionColorGValue.TabIndex = 14;
            this.actionColorGValue.Text = "0";
            // 
            // actionColorBValue
            // 
            this.actionColorBValue.AutoSize = true;
            this.actionColorBValue.Location = new System.Drawing.Point(330, 111);
            this.actionColorBValue.Name = "actionColorBValue";
            this.actionColorBValue.Size = new System.Drawing.Size(20, 23);
            this.actionColorBValue.TabIndex = 15;
            this.actionColorBValue.Text = "0";
            // 
            // actionStateToggle
            // 
            this.actionStateToggle.AutoSize = true;
            this.actionStateToggle.Location = new System.Drawing.Point(127, 18);
            this.actionStateToggle.Name = "actionStateToggle";
            this.actionStateToggle.Size = new System.Drawing.Size(85, 27);
            this.actionStateToggle.TabIndex = 16;
            this.actionStateToggle.TabStop = true;
            this.actionStateToggle.Text = "Toggle";
            this.actionStateToggle.UseVisualStyleBackColor = true;
            // 
            // actionStateContainer
            // 
            this.actionStateContainer.Controls.Add(this.actionStateToggle);
            this.actionStateContainer.Controls.Add(this.actionStateOn);
            this.actionStateContainer.Controls.Add(this.actionStateOff);
            this.actionStateContainer.Location = new System.Drawing.Point(3, 128);
            this.actionStateContainer.Name = "actionStateContainer";
            this.actionStateContainer.Size = new System.Drawing.Size(243, 160);
            this.actionStateContainer.TabIndex = 18;
            // 
            // actionColorContainer
            // 
            this.actionColorContainer.Controls.Add(this.actionColorRLabel);
            this.actionColorContainer.Controls.Add(this.actionColorR);
            this.actionColorContainer.Controls.Add(this.actionColorBValue);
            this.actionColorContainer.Controls.Add(this.actionColorGLabel);
            this.actionColorContainer.Controls.Add(this.actionColorGValue);
            this.actionColorContainer.Controls.Add(this.actionColorBLabel);
            this.actionColorContainer.Controls.Add(this.actionColorRValue);
            this.actionColorContainer.Controls.Add(this.actionColorB);
            this.actionColorContainer.Controls.Add(this.actionColorG);
            this.actionColorContainer.Location = new System.Drawing.Point(277, 128);
            this.actionColorContainer.Name = "actionColorContainer";
            this.actionColorContainer.Size = new System.Drawing.Size(431, 160);
            this.actionColorContainer.TabIndex = 19;
            // 
            // TestActionConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.Controls.Add(this.actionColorContainer);
            this.Controls.Add(this.actionStateContainer);
            this.Controls.Add(this.actionChangeColor);
            this.Controls.Add(this.actionToggleOnOff);
            this.Controls.Add(this.actionLabel);
            this.Controls.Add(this.selectList);
            this.Controls.Add(this.selectLabel);
            this.Name = "TestActionConfigurator";
            this.Load += new System.EventHandler(this.TestActionConfigurator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actionColorR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionColorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionColorG)).EndInit();
            this.actionStateContainer.ResumeLayout(false);
            this.actionStateContainer.PerformLayout();
            this.actionColorContainer.ResumeLayout(false);
            this.actionColorContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label selectLabel;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedComboBox selectList;
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.RadioButton actionStateOn;
        private System.Windows.Forms.RadioButton actionStateOff;
        private System.Windows.Forms.CheckBox actionToggleOnOff;
        private System.Windows.Forms.CheckBox actionChangeColor;
        private System.Windows.Forms.TrackBar actionColorR;
        private System.Windows.Forms.Label actionColorRLabel;
        private System.Windows.Forms.Label actionColorGLabel;
        private System.Windows.Forms.Label actionColorBLabel;
        private System.Windows.Forms.TrackBar actionColorB;
        private System.Windows.Forms.TrackBar actionColorG;
        private System.Windows.Forms.Label actionColorRValue;
        private System.Windows.Forms.Label actionColorGValue;
        private System.Windows.Forms.Label actionColorBValue;
        private System.Windows.Forms.RadioButton actionStateToggle;
        private System.Windows.Forms.Panel actionStateContainer;
        private System.Windows.Forms.Panel actionColorContainer;
    }
}