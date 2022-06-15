namespace Xenox003.MagicHome.Views
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
            this.containerDevices = new System.Windows.Forms.GroupBox();
            this.buttonDeviceSearch = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.boxDeviceIP = new System.Windows.Forms.TextBox();
            this.buttonDeviceDelete = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.buttonDeviceAdd = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.listDevices = new System.Windows.Forms.ListBox();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.buttonDeviceEdit = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.containerDevices.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerDevices
            // 
            this.containerDevices.Controls.Add(this.buttonDeviceEdit);
            this.containerDevices.Controls.Add(this.buttonDeviceSearch);
            this.containerDevices.Controls.Add(this.boxDeviceIP);
            this.containerDevices.Controls.Add(this.buttonDeviceDelete);
            this.containerDevices.Controls.Add(this.buttonDeviceAdd);
            this.containerDevices.Controls.Add(this.listDevices);
            this.containerDevices.ForeColor = System.Drawing.Color.White;
            this.containerDevices.Location = new System.Drawing.Point(3, 38);
            this.containerDevices.Name = "containerDevices";
            this.containerDevices.Size = new System.Drawing.Size(256, 323);
            this.containerDevices.TabIndex = 3;
            this.containerDevices.TabStop = false;
            this.containerDevices.Text = "Device Management";
            // 
            // buttonDeviceSearch
            // 
            this.buttonDeviceSearch.BorderRadius = 8;
            this.buttonDeviceSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeviceSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeviceSearch.ForeColor = System.Drawing.Color.White;
            this.buttonDeviceSearch.HoverColor = System.Drawing.Color.Empty;
            this.buttonDeviceSearch.Icon = global::Xenox003.MagicHome.Properties.Resources.Search_450;
            this.buttonDeviceSearch.Location = new System.Drawing.Point(215, 22);
            this.buttonDeviceSearch.Name = "buttonDeviceSearch";
            this.buttonDeviceSearch.Progress = 0;
            this.buttonDeviceSearch.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(94)))));
            this.buttonDeviceSearch.Size = new System.Drawing.Size(34, 34);
            this.buttonDeviceSearch.TabIndex = 16;
            this.buttonDeviceSearch.UseVisualStyleBackColor = true;
            this.buttonDeviceSearch.UseWindowsAccentColor = true;
            this.buttonDeviceSearch.Click += new System.EventHandler(this.buttonDeviceSearch_ClickAsync);
            // 
            // boxDeviceIP
            // 
            this.boxDeviceIP.Location = new System.Drawing.Point(6, 62);
            this.boxDeviceIP.Name = "boxDeviceIP";
            this.boxDeviceIP.PlaceholderText = "IP Address";
            this.boxDeviceIP.Size = new System.Drawing.Size(243, 23);
            this.boxDeviceIP.TabIndex = 15;
            // 
            // buttonDeviceDelete
            // 
            this.buttonDeviceDelete.BorderRadius = 8;
            this.buttonDeviceDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeviceDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeviceDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDeviceDelete.HoverColor = System.Drawing.Color.Empty;
            this.buttonDeviceDelete.Icon = global::Xenox003.MagicHome.Properties.Resources.Delete_450;
            this.buttonDeviceDelete.Location = new System.Drawing.Point(46, 22);
            this.buttonDeviceDelete.Name = "buttonDeviceDelete";
            this.buttonDeviceDelete.Progress = 0;
            this.buttonDeviceDelete.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(94)))));
            this.buttonDeviceDelete.Size = new System.Drawing.Size(34, 34);
            this.buttonDeviceDelete.TabIndex = 13;
            this.buttonDeviceDelete.UseVisualStyleBackColor = true;
            this.buttonDeviceDelete.UseWindowsAccentColor = true;
            this.buttonDeviceDelete.Click += new System.EventHandler(this.buttonDeviceDelete_Click);
            // 
            // buttonDeviceAdd
            // 
            this.buttonDeviceAdd.BorderRadius = 8;
            this.buttonDeviceAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeviceAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeviceAdd.ForeColor = System.Drawing.Color.White;
            this.buttonDeviceAdd.HoverColor = System.Drawing.Color.Empty;
            this.buttonDeviceAdd.Icon = global::Xenox003.MagicHome.Properties.Resources.Add_450;
            this.buttonDeviceAdd.Location = new System.Drawing.Point(6, 22);
            this.buttonDeviceAdd.Name = "buttonDeviceAdd";
            this.buttonDeviceAdd.Progress = 0;
            this.buttonDeviceAdd.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(94)))));
            this.buttonDeviceAdd.Size = new System.Drawing.Size(34, 34);
            this.buttonDeviceAdd.TabIndex = 12;
            this.buttonDeviceAdd.UseVisualStyleBackColor = true;
            this.buttonDeviceAdd.UseWindowsAccentColor = true;
            this.buttonDeviceAdd.Click += new System.EventHandler(this.buttonDeviceAdd_Click);
            // 
            // listDevices
            // 
            this.listDevices.FormattingEnabled = true;
            this.listDevices.ItemHeight = 16;
            this.listDevices.Location = new System.Drawing.Point(6, 88);
            this.listDevices.Name = "listDevices";
            this.listDevices.Size = new System.Drawing.Size(243, 228);
            this.listDevices.TabIndex = 0;
            // 
            // buttonDeviceEdit
            // 
            this.buttonDeviceEdit.BorderRadius = 8;
            this.buttonDeviceEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeviceEdit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeviceEdit.ForeColor = System.Drawing.Color.White;
            this.buttonDeviceEdit.HoverColor = System.Drawing.Color.Empty;
            this.buttonDeviceEdit.Icon = global::Xenox003.MagicHome.Properties.Resources.Edit_450;
            this.buttonDeviceEdit.Location = new System.Drawing.Point(86, 22);
            this.buttonDeviceEdit.Name = "buttonDeviceEdit";
            this.buttonDeviceEdit.Progress = 0;
            this.buttonDeviceEdit.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(94)))));
            this.buttonDeviceEdit.Size = new System.Drawing.Size(34, 34);
            this.buttonDeviceEdit.TabIndex = 17;
            this.buttonDeviceEdit.UseVisualStyleBackColor = true;
            this.buttonDeviceEdit.UseWindowsAccentColor = true;
            this.buttonDeviceEdit.Click += new System.EventHandler(this.buttonDeviceEdit_Click);
            // 
            // PluginConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(264, 367);
            this.Controls.Add(this.containerDevices);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PluginConfigurator";
            this.Load += new System.EventHandler(this.PluginConfigurator_Load);
            this.Controls.SetChildIndex(this.containerDevices, 0);
            this.containerDevices.ResumeLayout(false);
            this.containerDevices.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.GroupBox containerDevices;
        private System.Windows.Forms.ListBox listDevices;
        private SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary buttonDeviceAdd;
        private SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary buttonDeviceDelete;
        private System.Windows.Forms.TextBox boxDeviceIP;
        private SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary buttonDeviceSearch;
        private System.Windows.Forms.ToolTip toolTipMain;
        private SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary buttonDeviceEdit;
    }
}