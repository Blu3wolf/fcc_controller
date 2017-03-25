﻿namespace Fcc3_configurator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonApply = new System.Windows.Forms.Button();
            this.checkBoxRotate = new System.Windows.Forms.CheckBox();
            this.checkBoxForceMapping = new System.Windows.Forms.CheckBox();
            this.radioButton4Kg = new System.Windows.Forms.RadioButton();
            this.radioButton6Kg = new System.Windows.Forms.RadioButton();
            this.radioButton9Kg = new System.Windows.Forms.RadioButton();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.numericUserDefined = new System.Windows.Forms.NumericUpDown();
            this.buttonDefaults = new System.Windows.Forms.Button();
            this.toolTipMainForm = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxSensitivity = new System.Windows.Forms.GroupBox();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.labelForceUser = new System.Windows.Forms.Label();
            this.labelForce9kg = new System.Windows.Forms.Label();
            this.labelForce6kg = new System.Windows.Forms.Label();
            this.labelForce4Kg = new System.Windows.Forms.Label();
            this.labelCurrentUserDefined = new System.Windows.Forms.Label();
            this.groupBoxFeatures = new System.Windows.Forms.GroupBox();
            this.labelForceMapping = new System.Windows.Forms.Label();
            this.labelSensorRotation = new System.Windows.Forms.Label();
            this.buttonUpdateFw = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.tabPageFirmware = new System.Windows.Forms.TabPage();
            this.labelVersionDetected = new System.Windows.Forms.Label();
            this.labelVesrion = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonBrowsHex = new System.Windows.Forms.Button();
            this.textBoxHexPath = new System.Windows.Forms.TextBox();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUserDefined)).BeginInit();
            this.groupBoxSensitivity.SuspendLayout();
            this.groupBoxFeatures.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageFirmware.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonApply.Location = new System.Drawing.Point(3, 219);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(224, 43);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "&Apply Config";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // checkBoxRotate
            // 
            this.checkBoxRotate.AutoSize = true;
            this.checkBoxRotate.Location = new System.Drawing.Point(6, 19);
            this.checkBoxRotate.Name = "checkBoxRotate";
            this.checkBoxRotate.Size = new System.Drawing.Size(151, 17);
            this.checkBoxRotate.TabIndex = 1;
            this.checkBoxRotate.Text = "Sensor &Rotation Emulation";
            this.checkBoxRotate.UseVisualStyleBackColor = true;
            // 
            // checkBoxForceMapping
            // 
            this.checkBoxForceMapping.AutoSize = true;
            this.checkBoxForceMapping.Location = new System.Drawing.Point(6, 42);
            this.checkBoxForceMapping.Name = "checkBoxForceMapping";
            this.checkBoxForceMapping.Size = new System.Drawing.Size(156, 17);
            this.checkBoxForceMapping.TabIndex = 2;
            this.checkBoxForceMapping.Text = "Proportional Force &Mapping";
            this.checkBoxForceMapping.UseVisualStyleBackColor = true;
            // 
            // radioButton4Kg
            // 
            this.radioButton4Kg.AutoSize = true;
            this.radioButton4Kg.Checked = true;
            this.radioButton4Kg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButton4Kg.Location = new System.Drawing.Point(6, 19);
            this.radioButton4Kg.Name = "radioButton4Kg";
            this.radioButton4Kg.Size = new System.Drawing.Size(104, 17);
            this.radioButton4Kg.TabIndex = 3;
            this.radioButton4Kg.TabStop = true;
            this.radioButton4Kg.Text = "&4.5 Kg/f (10 lb/f)";
            this.radioButton4Kg.UseVisualStyleBackColor = true;
            // 
            // radioButton6Kg
            // 
            this.radioButton6Kg.AutoSize = true;
            this.radioButton6Kg.Location = new System.Drawing.Point(6, 42);
            this.radioButton6Kg.Name = "radioButton6Kg";
            this.radioButton6Kg.Size = new System.Drawing.Size(101, 17);
            this.radioButton6Kg.TabIndex = 4;
            this.radioButton6Kg.Text = "&6 Kg/f   (13 lb/f)";
            this.radioButton6Kg.UseVisualStyleBackColor = true;
            // 
            // radioButton9Kg
            // 
            this.radioButton9Kg.AutoSize = true;
            this.radioButton9Kg.Location = new System.Drawing.Point(6, 65);
            this.radioButton9Kg.Name = "radioButton9Kg";
            this.radioButton9Kg.Size = new System.Drawing.Size(101, 17);
            this.radioButton9Kg.TabIndex = 5;
            this.radioButton9Kg.Text = "&9 Kg/f   (20 lb/f)";
            this.radioButton9Kg.UseVisualStyleBackColor = true;
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.Location = new System.Drawing.Point(6, 88);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(148, 17);
            this.radioButtonUser.TabIndex = 6;
            this.radioButtonUser.Text = "&User Defined force setting";
            this.radioButtonUser.UseVisualStyleBackColor = true;
            // 
            // numericUserDefined
            // 
            this.numericUserDefined.DecimalPlaces = 1;
            this.numericUserDefined.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUserDefined.Location = new System.Drawing.Point(32, 111);
            this.numericUserDefined.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            65536});
            this.numericUserDefined.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.numericUserDefined.Name = "numericUserDefined";
            this.numericUserDefined.Size = new System.Drawing.Size(46, 20);
            this.numericUserDefined.TabIndex = 7;
            this.numericUserDefined.Value = new decimal(new int[] {
            30,
            0,
            0,
            65536});
            // 
            // buttonDefaults
            // 
            this.buttonDefaults.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonDefaults.Location = new System.Drawing.Point(4, 268);
            this.buttonDefaults.Name = "buttonDefaults";
            this.buttonDefaults.Size = new System.Drawing.Size(111, 23);
            this.buttonDefaults.TabIndex = 9;
            this.buttonDefaults.Text = "&Restore Defaults";
            this.buttonDefaults.UseVisualStyleBackColor = true;
            this.buttonDefaults.Click += new System.EventHandler(this.buttonDefaults_Click);
            // 
            // groupBoxSensitivity
            // 
            this.groupBoxSensitivity.Controls.Add(this.comboBoxUnit);
            this.groupBoxSensitivity.Controls.Add(this.labelForceUser);
            this.groupBoxSensitivity.Controls.Add(this.labelForce9kg);
            this.groupBoxSensitivity.Controls.Add(this.labelForce6kg);
            this.groupBoxSensitivity.Controls.Add(this.labelForce4Kg);
            this.groupBoxSensitivity.Controls.Add(this.labelCurrentUserDefined);
            this.groupBoxSensitivity.Controls.Add(this.radioButton4Kg);
            this.groupBoxSensitivity.Controls.Add(this.radioButton6Kg);
            this.groupBoxSensitivity.Controls.Add(this.radioButtonUser);
            this.groupBoxSensitivity.Controls.Add(this.numericUserDefined);
            this.groupBoxSensitivity.Controls.Add(this.radioButton9Kg);
            this.groupBoxSensitivity.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSensitivity.Name = "groupBoxSensitivity";
            this.groupBoxSensitivity.Size = new System.Drawing.Size(224, 138);
            this.groupBoxSensitivity.TabIndex = 12;
            this.groupBoxSensitivity.TabStop = false;
            this.groupBoxSensitivity.Text = "Sensitivity Settings";
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Items.AddRange(new object[] {
            "Kg/f",
            "lb/f"});
            this.comboBoxUnit.Location = new System.Drawing.Point(84, 111);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(44, 21);
            this.comboBoxUnit.TabIndex = 16;
            this.comboBoxUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnit_SelectedIndexChanged);
            // 
            // labelForceUser
            // 
            this.labelForceUser.AutoSize = true;
            this.labelForceUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelForceUser.ForeColor = System.Drawing.Color.Green;
            this.labelForceUser.Location = new System.Drawing.Point(196, 90);
            this.labelForceUser.Name = "labelForceUser";
            this.labelForceUser.Size = new System.Drawing.Size(15, 13);
            this.labelForceUser.TabIndex = 13;
            this.labelForceUser.Text = "●";
            this.labelForceUser.Visible = false;
            // 
            // labelForce9kg
            // 
            this.labelForce9kg.AutoSize = true;
            this.labelForce9kg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelForce9kg.ForeColor = System.Drawing.Color.Green;
            this.labelForce9kg.Location = new System.Drawing.Point(196, 67);
            this.labelForce9kg.Name = "labelForce9kg";
            this.labelForce9kg.Size = new System.Drawing.Size(15, 13);
            this.labelForce9kg.TabIndex = 12;
            this.labelForce9kg.Text = "●";
            this.labelForce9kg.Visible = false;
            // 
            // labelForce6kg
            // 
            this.labelForce6kg.AutoSize = true;
            this.labelForce6kg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelForce6kg.ForeColor = System.Drawing.Color.Green;
            this.labelForce6kg.Location = new System.Drawing.Point(196, 44);
            this.labelForce6kg.Name = "labelForce6kg";
            this.labelForce6kg.Size = new System.Drawing.Size(15, 13);
            this.labelForce6kg.TabIndex = 11;
            this.labelForce6kg.Text = "●";
            this.labelForce6kg.Visible = false;
            // 
            // labelForce4Kg
            // 
            this.labelForce4Kg.AutoSize = true;
            this.labelForce4Kg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelForce4Kg.ForeColor = System.Drawing.Color.Green;
            this.labelForce4Kg.Location = new System.Drawing.Point(196, 21);
            this.labelForce4Kg.Name = "labelForce4Kg";
            this.labelForce4Kg.Size = new System.Drawing.Size(15, 13);
            this.labelForce4Kg.TabIndex = 10;
            this.labelForce4Kg.Text = "●";
            this.labelForce4Kg.Visible = false;
            // 
            // labelCurrentUserDefined
            // 
            this.labelCurrentUserDefined.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentUserDefined.AutoSize = true;
            this.labelCurrentUserDefined.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCurrentUserDefined.Location = new System.Drawing.Point(157, 113);
            this.labelCurrentUserDefined.Name = "labelCurrentUserDefined";
            this.labelCurrentUserDefined.Size = new System.Drawing.Size(54, 13);
            this.labelCurrentUserDefined.TabIndex = 9;
            this.labelCurrentUserDefined.Text = "0.0 Kg/f";
            this.labelCurrentUserDefined.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBoxFeatures
            // 
            this.groupBoxFeatures.Controls.Add(this.labelForceMapping);
            this.groupBoxFeatures.Controls.Add(this.labelSensorRotation);
            this.groupBoxFeatures.Controls.Add(this.checkBoxRotate);
            this.groupBoxFeatures.Controls.Add(this.checkBoxForceMapping);
            this.groupBoxFeatures.Location = new System.Drawing.Point(3, 147);
            this.groupBoxFeatures.Name = "groupBoxFeatures";
            this.groupBoxFeatures.Size = new System.Drawing.Size(224, 66);
            this.groupBoxFeatures.TabIndex = 13;
            this.groupBoxFeatures.TabStop = false;
            this.groupBoxFeatures.Text = "Special Features";
            // 
            // labelForceMapping
            // 
            this.labelForceMapping.AutoSize = true;
            this.labelForceMapping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelForceMapping.ForeColor = System.Drawing.Color.Red;
            this.labelForceMapping.Location = new System.Drawing.Point(181, 43);
            this.labelForceMapping.Name = "labelForceMapping";
            this.labelForceMapping.Size = new System.Drawing.Size(30, 13);
            this.labelForceMapping.TabIndex = 16;
            this.labelForceMapping.Text = "OFF";
            // 
            // labelSensorRotation
            // 
            this.labelSensorRotation.AutoSize = true;
            this.labelSensorRotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSensorRotation.ForeColor = System.Drawing.Color.Red;
            this.labelSensorRotation.Location = new System.Drawing.Point(181, 20);
            this.labelSensorRotation.Name = "labelSensorRotation";
            this.labelSensorRotation.Size = new System.Drawing.Size(30, 13);
            this.labelSensorRotation.TabIndex = 15;
            this.labelSensorRotation.Text = "OFF";
            // 
            // buttonUpdateFw
            // 
            this.buttonUpdateFw.Enabled = false;
            this.buttonUpdateFw.Location = new System.Drawing.Point(7, 250);
            this.buttonUpdateFw.Name = "buttonUpdateFw";
            this.buttonUpdateFw.Size = new System.Drawing.Size(226, 47);
            this.buttonUpdateFw.TabIndex = 1;
            this.buttonUpdateFw.Text = "Upload Firmware";
            this.buttonUpdateFw.UseVisualStyleBackColor = true;
            this.buttonUpdateFw.Click += new System.EventHandler(this.buttonUpdateFw_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCenter);
            this.panel1.Controls.Add(this.groupBoxSensitivity);
            this.panel1.Controls.Add(this.buttonApply);
            this.panel1.Controls.Add(this.groupBoxFeatures);
            this.panel1.Controls.Add(this.buttonDefaults);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 297);
            this.panel1.TabIndex = 16;
            // 
            // buttonCenter
            // 
            this.buttonCenter.Location = new System.Drawing.Point(116, 268);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Size = new System.Drawing.Size(111, 23);
            this.buttonCenter.TabIndex = 14;
            this.buttonCenter.Text = "Center";
            this.buttonCenter.UseVisualStyleBackColor = true;
            this.buttonCenter.Click += new System.EventHandler(this.buttonCenter_Click);
            // 
            // tabPageFirmware
            // 
            this.tabPageFirmware.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageFirmware.Controls.Add(this.labelVersionDetected);
            this.tabPageFirmware.Controls.Add(this.labelVesrion);
            this.tabPageFirmware.Controls.Add(this.labelPath);
            this.tabPageFirmware.Controls.Add(this.buttonBrowsHex);
            this.tabPageFirmware.Controls.Add(this.textBoxHexPath);
            this.tabPageFirmware.Controls.Add(this.buttonUpdateFw);
            this.tabPageFirmware.Location = new System.Drawing.Point(4, 22);
            this.tabPageFirmware.Name = "tabPageFirmware";
            this.tabPageFirmware.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFirmware.Size = new System.Drawing.Size(241, 303);
            this.tabPageFirmware.TabIndex = 1;
            this.tabPageFirmware.Text = "Firmware Update";
            // 
            // labelVersionDetected
            // 
            this.labelVersionDetected.AutoSize = true;
            this.labelVersionDetected.Location = new System.Drawing.Point(114, 69);
            this.labelVersionDetected.Name = "labelVersionDetected";
            this.labelVersionDetected.Size = new System.Drawing.Size(31, 13);
            this.labelVersionDetected.TabIndex = 10;
            this.labelVersionDetected.Text = "0.0.0";
            // 
            // labelVesrion
            // 
            this.labelVesrion.AutoSize = true;
            this.labelVesrion.Location = new System.Drawing.Point(10, 69);
            this.labelVesrion.Name = "labelVesrion";
            this.labelVesrion.Size = new System.Drawing.Size(98, 13);
            this.labelVesrion.TabIndex = 9;
            this.labelVesrion.Text = "Version on device: ";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(7, 16);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(109, 13);
            this.labelPath.TabIndex = 8;
            this.labelPath.Text = "Select HEX to upload";
            // 
            // buttonBrowsHex
            // 
            this.buttonBrowsHex.Location = new System.Drawing.Point(208, 30);
            this.buttonBrowsHex.Name = "buttonBrowsHex";
            this.buttonBrowsHex.Size = new System.Drawing.Size(25, 23);
            this.buttonBrowsHex.TabIndex = 7;
            this.buttonBrowsHex.Text = "...";
            this.buttonBrowsHex.UseVisualStyleBackColor = true;
            this.buttonBrowsHex.Click += new System.EventHandler(this.buttonBrowsHex_Click);
            // 
            // textBoxHexPath
            // 
            this.textBoxHexPath.AllowDrop = true;
            this.textBoxHexPath.Location = new System.Drawing.Point(7, 32);
            this.textBoxHexPath.Name = "textBoxHexPath";
            this.textBoxHexPath.Size = new System.Drawing.Size(195, 20);
            this.textBoxHexPath.TabIndex = 6;
            this.textBoxHexPath.TextChanged += new System.EventHandler(this.textBoxHexPath_TextChanged);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSettings.Controls.Add(this.panel1);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(241, 303);
            this.tabPageSettings.TabIndex = 0;
            this.tabPageSettings.Text = "Settings";
            // 
            // tabControlMain
            // 
            this.tabControlMain.AllowDrop = true;
            this.tabControlMain.Controls.Add(this.tabPageSettings);
            this.tabControlMain.Controls.Add(this.tabPageFirmware);
            this.tabControlMain.Location = new System.Drawing.Point(1, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(249, 329);
            this.tabControlMain.TabIndex = 14;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelColor,
            this.toolStripStatusLabelInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 332);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(250, 24);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelColor
            // 
            this.toolStripStatusLabelColor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabelColor.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelColor.Name = "toolStripStatusLabelColor";
            this.toolStripStatusLabelColor.Size = new System.Drawing.Size(17, 19);
            this.toolStripStatusLabelColor.Text = "●";
            this.toolStripStatusLabelColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // toolStripStatusLabelInfo
            // 
            this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(122, 19);
            this.toolStripStatusLabelInfo.Text = "No Device Connected";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(250, 356);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "FCC Configurator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUserDefined)).EndInit();
            this.groupBoxSensitivity.ResumeLayout(false);
            this.groupBoxSensitivity.PerformLayout();
            this.groupBoxFeatures.ResumeLayout(false);
            this.groupBoxFeatures.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPageFirmware.ResumeLayout(false);
            this.tabPageFirmware.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.CheckBox checkBoxRotate;
        private System.Windows.Forms.CheckBox checkBoxForceMapping;
        private System.Windows.Forms.RadioButton radioButton4Kg;
        private System.Windows.Forms.RadioButton radioButton6Kg;
        private System.Windows.Forms.RadioButton radioButton9Kg;
        private System.Windows.Forms.RadioButton radioButtonUser;
        private System.Windows.Forms.NumericUpDown numericUserDefined;
        private System.Windows.Forms.Button buttonDefaults;
        private System.Windows.Forms.ToolTip toolTipMainForm;
        private System.Windows.Forms.GroupBox groupBoxSensitivity;
        private System.Windows.Forms.GroupBox groupBoxFeatures;
        private System.Windows.Forms.Button buttonUpdateFw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPageFirmware;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.Label labelForceMapping;
        private System.Windows.Forms.Label labelSensorRotation;
        private System.Windows.Forms.Label labelCurrentUserDefined;
        private System.Windows.Forms.Label labelForce4Kg;
        private System.Windows.Forms.Label labelForceUser;
        private System.Windows.Forms.Label labelForce9kg;
        private System.Windows.Forms.Label labelForce6kg;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelColor;
        private System.Windows.Forms.Button buttonCenter;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonBrowsHex;
        private System.Windows.Forms.TextBox textBoxHexPath;
        private System.Windows.Forms.Label labelVersionDetected;
        private System.Windows.Forms.Label labelVesrion;
    }
}
