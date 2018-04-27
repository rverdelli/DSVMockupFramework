namespace IMOMS_Display_Mockup_Framework
{
    partial class imomsDisplayMockupFramework
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(imomsDisplayMockupFramework));
            this.newDisplay = new System.Windows.Forms.Button();
            this.loadDisplayComboBox = new System.Windows.Forms.ComboBox();
            this.loadDisplayLabel = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.displaysGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createDashboardButton = new System.Windows.Forms.Button();
            this.loadDashboardLabel = new System.Windows.Forms.Label();
            this.loadDashboardComboBox = new System.Windows.Forms.ComboBox();
            this.utilsGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regenerateAllButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.utilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaysToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ribbonsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.utilsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.componentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.displaysToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardsToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ribbonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.displaysToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editRibbonFolderButton = new System.Windows.Forms.Button();
            this.openRibbonsFolderButton = new System.Windows.Forms.Button();
            this.editDashboardsConfigFilesFolderButton = new System.Windows.Forms.Button();
            this.openDashboardsConfigFilesFolderButton = new System.Windows.Forms.Button();
            this.editDisplaysConfigFilesFolderButton = new System.Windows.Forms.Button();
            this.openDisplaysConfigFileFolderButton = new System.Windows.Forms.Button();
            this.editDashboardsFolderButton = new System.Windows.Forms.Button();
            this.openDashboardsFodlerButton = new System.Windows.Forms.Button();
            this.editDisplaysFolderButton = new System.Windows.Forms.Button();
            this.editComponentsFolderButton = new System.Windows.Forms.Button();
            this.openDisplaysFolderButton = new System.Windows.Forms.Button();
            this.openComponentsFolderButton = new System.Windows.Forms.Button();
            this.refreshDashboardsListButton = new System.Windows.Forms.Button();
            this.refreshDisplayListButton = new System.Windows.Forms.Button();
            this.componentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaysGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.utilsGroupBox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newDisplay
            // 
            resources.ApplyResources(this.newDisplay, "newDisplay");
            this.newDisplay.Name = "newDisplay";
            this.newDisplay.UseVisualStyleBackColor = true;
            this.newDisplay.Click += new System.EventHandler(this.newDisplay_Click);
            // 
            // loadDisplayComboBox
            // 
            resources.ApplyResources(this.loadDisplayComboBox, "loadDisplayComboBox");
            this.loadDisplayComboBox.FormattingEnabled = true;
            this.loadDisplayComboBox.Name = "loadDisplayComboBox";
            this.loadDisplayComboBox.SelectedIndexChanged += new System.EventHandler(this.loadDisplayComboBox_SelectedIndexChanged);
            // 
            // loadDisplayLabel
            // 
            resources.ApplyResources(this.loadDisplayLabel, "loadDisplayLabel");
            this.loadDisplayLabel.Name = "loadDisplayLabel";
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // displaysGroupBox
            // 
            resources.ApplyResources(this.displaysGroupBox, "displaysGroupBox");
            this.displaysGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.displaysGroupBox.Controls.Add(this.newDisplay);
            this.displaysGroupBox.Controls.Add(this.loadDisplayLabel);
            this.displaysGroupBox.Controls.Add(this.refreshDisplayListButton);
            this.displaysGroupBox.Controls.Add(this.loadDisplayComboBox);
            this.displaysGroupBox.Name = "displaysGroupBox";
            this.displaysGroupBox.TabStop = false;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.createDashboardButton);
            this.groupBox1.Controls.Add(this.loadDashboardLabel);
            this.groupBox1.Controls.Add(this.refreshDashboardsListButton);
            this.groupBox1.Controls.Add(this.loadDashboardComboBox);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // createDashboardButton
            // 
            resources.ApplyResources(this.createDashboardButton, "createDashboardButton");
            this.createDashboardButton.Name = "createDashboardButton";
            this.createDashboardButton.UseVisualStyleBackColor = true;
            this.createDashboardButton.Click += new System.EventHandler(this.createDashboardButton_Click);
            // 
            // loadDashboardLabel
            // 
            resources.ApplyResources(this.loadDashboardLabel, "loadDashboardLabel");
            this.loadDashboardLabel.Name = "loadDashboardLabel";
            // 
            // loadDashboardComboBox
            // 
            resources.ApplyResources(this.loadDashboardComboBox, "loadDashboardComboBox");
            this.loadDashboardComboBox.FormattingEnabled = true;
            this.loadDashboardComboBox.Name = "loadDashboardComboBox";
            this.loadDashboardComboBox.SelectedIndexChanged += new System.EventHandler(this.loadDashboardComboBox_SelectedIndexChanged);
            // 
            // utilsGroupBox
            // 
            resources.ApplyResources(this.utilsGroupBox, "utilsGroupBox");
            this.utilsGroupBox.Controls.Add(this.editRibbonFolderButton);
            this.utilsGroupBox.Controls.Add(this.openRibbonsFolderButton);
            this.utilsGroupBox.Controls.Add(this.label6);
            this.utilsGroupBox.Controls.Add(this.editDashboardsConfigFilesFolderButton);
            this.utilsGroupBox.Controls.Add(this.openDashboardsConfigFilesFolderButton);
            this.utilsGroupBox.Controls.Add(this.label5);
            this.utilsGroupBox.Controls.Add(this.editDisplaysConfigFilesFolderButton);
            this.utilsGroupBox.Controls.Add(this.openDisplaysConfigFileFolderButton);
            this.utilsGroupBox.Controls.Add(this.label4);
            this.utilsGroupBox.Controls.Add(this.editDashboardsFolderButton);
            this.utilsGroupBox.Controls.Add(this.openDashboardsFodlerButton);
            this.utilsGroupBox.Controls.Add(this.label3);
            this.utilsGroupBox.Controls.Add(this.editDisplaysFolderButton);
            this.utilsGroupBox.Controls.Add(this.editComponentsFolderButton);
            this.utilsGroupBox.Controls.Add(this.openDisplaysFolderButton);
            this.utilsGroupBox.Controls.Add(this.openComponentsFolderButton);
            this.utilsGroupBox.Controls.Add(this.label2);
            this.utilsGroupBox.Controls.Add(this.label1);
            this.utilsGroupBox.Controls.Add(this.regenerateAllButton);
            this.utilsGroupBox.Name = "utilsGroupBox";
            this.utilsGroupBox.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // regenerateAllButton
            // 
            resources.ApplyResources(this.regenerateAllButton, "regenerateAllButton");
            this.regenerateAllButton.Name = "regenerateAllButton";
            this.regenerateAllButton.UseVisualStyleBackColor = true;
            this.regenerateAllButton.Click += new System.EventHandler(this.regenerateDisplaysAndDashboardsButton_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton2,
            this.toolStripSeparator1,
            this.toolStripDropDownButton4});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilsToolStripMenuItem,
            this.configsToolStripMenuItem});
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            // 
            // utilsToolStripMenuItem
            // 
            this.utilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentsToolStripMenuItem,
            this.displaysToolStripMenuItem1,
            this.dashboardsToolStripMenuItem1,
            this.ribbonsToolStripMenuItem1});
            this.utilsToolStripMenuItem.Name = "utilsToolStripMenuItem";
            resources.ApplyResources(this.utilsToolStripMenuItem, "utilsToolStripMenuItem");
            // 
            // componentsToolStripMenuItem
            // 
            this.componentsToolStripMenuItem.Name = "componentsToolStripMenuItem";
            resources.ApplyResources(this.componentsToolStripMenuItem, "componentsToolStripMenuItem");
            this.componentsToolStripMenuItem.Click += new System.EventHandler(this.componentsToolStripMenuItem_Click);
            // 
            // displaysToolStripMenuItem1
            // 
            this.displaysToolStripMenuItem1.Name = "displaysToolStripMenuItem1";
            resources.ApplyResources(this.displaysToolStripMenuItem1, "displaysToolStripMenuItem1");
            this.displaysToolStripMenuItem1.Click += new System.EventHandler(this.displaysToolStripMenuItem1_Click);
            // 
            // dashboardsToolStripMenuItem1
            // 
            this.dashboardsToolStripMenuItem1.Name = "dashboardsToolStripMenuItem1";
            resources.ApplyResources(this.dashboardsToolStripMenuItem1, "dashboardsToolStripMenuItem1");
            this.dashboardsToolStripMenuItem1.Click += new System.EventHandler(this.dashboardsToolStripMenuItem1_Click);
            // 
            // ribbonsToolStripMenuItem1
            // 
            this.ribbonsToolStripMenuItem1.Name = "ribbonsToolStripMenuItem1";
            resources.ApplyResources(this.ribbonsToolStripMenuItem1, "ribbonsToolStripMenuItem1");
            this.ribbonsToolStripMenuItem1.Click += new System.EventHandler(this.ribbonsToolStripMenuItem1_Click);
            // 
            // configsToolStripMenuItem
            // 
            this.configsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardsToolStripMenuItem,
            this.displaysToolStripMenuItem});
            this.configsToolStripMenuItem.Name = "configsToolStripMenuItem";
            resources.ApplyResources(this.configsToolStripMenuItem, "configsToolStripMenuItem");
            // 
            // dashboardsToolStripMenuItem
            // 
            this.dashboardsToolStripMenuItem.Name = "dashboardsToolStripMenuItem";
            resources.ApplyResources(this.dashboardsToolStripMenuItem, "dashboardsToolStripMenuItem");
            this.dashboardsToolStripMenuItem.Click += new System.EventHandler(this.dashboardsToolStripMenuItem_Click);
            // 
            // displaysToolStripMenuItem
            // 
            this.displaysToolStripMenuItem.Name = "displaysToolStripMenuItem";
            resources.ApplyResources(this.displaysToolStripMenuItem, "displaysToolStripMenuItem");
            this.displaysToolStripMenuItem.Click += new System.EventHandler(this.displaysToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilsToolStripMenuItem1,
            this.configsToolStripMenuItem1});
            resources.ApplyResources(this.toolStripDropDownButton3, "toolStripDropDownButton3");
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            // 
            // utilsToolStripMenuItem1
            // 
            this.utilsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentsToolStripMenuItem1,
            this.displaysToolStripMenuItem3,
            this.dashboardsToolStripMenuItem3,
            this.ribbonsToolStripMenuItem});
            this.utilsToolStripMenuItem1.Name = "utilsToolStripMenuItem1";
            resources.ApplyResources(this.utilsToolStripMenuItem1, "utilsToolStripMenuItem1");
            // 
            // componentsToolStripMenuItem1
            // 
            this.componentsToolStripMenuItem1.Name = "componentsToolStripMenuItem1";
            resources.ApplyResources(this.componentsToolStripMenuItem1, "componentsToolStripMenuItem1");
            this.componentsToolStripMenuItem1.Click += new System.EventHandler(this.componentsToolStripMenuItem1_Click);
            // 
            // displaysToolStripMenuItem3
            // 
            this.displaysToolStripMenuItem3.Name = "displaysToolStripMenuItem3";
            resources.ApplyResources(this.displaysToolStripMenuItem3, "displaysToolStripMenuItem3");
            this.displaysToolStripMenuItem3.Click += new System.EventHandler(this.displaysToolStripMenuItem3_Click);
            // 
            // dashboardsToolStripMenuItem3
            // 
            this.dashboardsToolStripMenuItem3.Name = "dashboardsToolStripMenuItem3";
            resources.ApplyResources(this.dashboardsToolStripMenuItem3, "dashboardsToolStripMenuItem3");
            this.dashboardsToolStripMenuItem3.Click += new System.EventHandler(this.dashboardsToolStripMenuItem3_Click);
            // 
            // ribbonsToolStripMenuItem
            // 
            this.ribbonsToolStripMenuItem.Name = "ribbonsToolStripMenuItem";
            resources.ApplyResources(this.ribbonsToolStripMenuItem, "ribbonsToolStripMenuItem");
            this.ribbonsToolStripMenuItem.Click += new System.EventHandler(this.ribbonsToolStripMenuItem_Click);
            // 
            // configsToolStripMenuItem1
            // 
            this.configsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displaysToolStripMenuItem2,
            this.dashboardsToolStripMenuItem2});
            this.configsToolStripMenuItem1.Name = "configsToolStripMenuItem1";
            resources.ApplyResources(this.configsToolStripMenuItem1, "configsToolStripMenuItem1");
            // 
            // displaysToolStripMenuItem2
            // 
            this.displaysToolStripMenuItem2.Name = "displaysToolStripMenuItem2";
            resources.ApplyResources(this.displaysToolStripMenuItem2, "displaysToolStripMenuItem2");
            this.displaysToolStripMenuItem2.Click += new System.EventHandler(this.displaysToolStripMenuItem2_Click);
            // 
            // dashboardsToolStripMenuItem2
            // 
            this.dashboardsToolStripMenuItem2.Name = "dashboardsToolStripMenuItem2";
            resources.ApplyResources(this.dashboardsToolStripMenuItem2, "dashboardsToolStripMenuItem2");
            this.dashboardsToolStripMenuItem2.Click += new System.EventHandler(this.dashboardsToolStripMenuItem2_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripDropDownButton2, "toolStripDropDownButton2");
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentToolStripMenuItem,
            this.displayToolStripMenuItem});
            this.toolStripDropDownButton4.Image = global::IMOMS_Display_Mockup_Framework.Properties.Resources.search;
            resources.ApplyResources(this.toolStripDropDownButton4, "toolStripDropDownButton4");
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::IMOMS_Display_Mockup_Framework.Properties.Resources.TechEdgeLogo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // editRibbonFolderButton
            // 
            resources.ApplyResources(this.editRibbonFolderButton, "editRibbonFolderButton");
            this.editRibbonFolderButton.Name = "editRibbonFolderButton";
            this.editRibbonFolderButton.UseVisualStyleBackColor = true;
            this.editRibbonFolderButton.Click += new System.EventHandler(this.editRibbonsFolderButton_Click);
            // 
            // openRibbonsFolderButton
            // 
            resources.ApplyResources(this.openRibbonsFolderButton, "openRibbonsFolderButton");
            this.openRibbonsFolderButton.Name = "openRibbonsFolderButton";
            this.openRibbonsFolderButton.UseVisualStyleBackColor = true;
            this.openRibbonsFolderButton.Click += new System.EventHandler(this.openRibbonsFolderButton_Click);
            // 
            // editDashboardsConfigFilesFolderButton
            // 
            resources.ApplyResources(this.editDashboardsConfigFilesFolderButton, "editDashboardsConfigFilesFolderButton");
            this.editDashboardsConfigFilesFolderButton.Name = "editDashboardsConfigFilesFolderButton";
            this.editDashboardsConfigFilesFolderButton.UseVisualStyleBackColor = true;
            this.editDashboardsConfigFilesFolderButton.Click += new System.EventHandler(this.editDashboardsConfigFolderButton_Click);
            // 
            // openDashboardsConfigFilesFolderButton
            // 
            resources.ApplyResources(this.openDashboardsConfigFilesFolderButton, "openDashboardsConfigFilesFolderButton");
            this.openDashboardsConfigFilesFolderButton.Name = "openDashboardsConfigFilesFolderButton";
            this.openDashboardsConfigFilesFolderButton.UseVisualStyleBackColor = true;
            this.openDashboardsConfigFilesFolderButton.Click += new System.EventHandler(this.openDashboardConfigFilesFolderButton_Click);
            // 
            // editDisplaysConfigFilesFolderButton
            // 
            resources.ApplyResources(this.editDisplaysConfigFilesFolderButton, "editDisplaysConfigFilesFolderButton");
            this.editDisplaysConfigFilesFolderButton.Name = "editDisplaysConfigFilesFolderButton";
            this.editDisplaysConfigFilesFolderButton.UseVisualStyleBackColor = true;
            this.editDisplaysConfigFilesFolderButton.Click += new System.EventHandler(this.editDisplayConfigFolderButton_Click);
            // 
            // openDisplaysConfigFileFolderButton
            // 
            resources.ApplyResources(this.openDisplaysConfigFileFolderButton, "openDisplaysConfigFileFolderButton");
            this.openDisplaysConfigFileFolderButton.Name = "openDisplaysConfigFileFolderButton";
            this.openDisplaysConfigFileFolderButton.UseVisualStyleBackColor = true;
            this.openDisplaysConfigFileFolderButton.Click += new System.EventHandler(this.openDisplayConfigFilesFolderButton_Click);
            // 
            // editDashboardsFolderButton
            // 
            resources.ApplyResources(this.editDashboardsFolderButton, "editDashboardsFolderButton");
            this.editDashboardsFolderButton.Name = "editDashboardsFolderButton";
            this.editDashboardsFolderButton.UseVisualStyleBackColor = true;
            this.editDashboardsFolderButton.Click += new System.EventHandler(this.editDashboardsFolderButton_Click);
            // 
            // openDashboardsFodlerButton
            // 
            resources.ApplyResources(this.openDashboardsFodlerButton, "openDashboardsFodlerButton");
            this.openDashboardsFodlerButton.Name = "openDashboardsFodlerButton";
            this.openDashboardsFodlerButton.UseVisualStyleBackColor = true;
            this.openDashboardsFodlerButton.Click += new System.EventHandler(this.openDashboardsFolderButton_Click);
            // 
            // editDisplaysFolderButton
            // 
            resources.ApplyResources(this.editDisplaysFolderButton, "editDisplaysFolderButton");
            this.editDisplaysFolderButton.Name = "editDisplaysFolderButton";
            this.editDisplaysFolderButton.UseVisualStyleBackColor = true;
            this.editDisplaysFolderButton.Click += new System.EventHandler(this.editDisplaysFolderButton_Click);
            // 
            // editComponentsFolderButton
            // 
            resources.ApplyResources(this.editComponentsFolderButton, "editComponentsFolderButton");
            this.editComponentsFolderButton.Name = "editComponentsFolderButton";
            this.editComponentsFolderButton.UseVisualStyleBackColor = true;
            this.editComponentsFolderButton.Click += new System.EventHandler(this.editComponentsFolderButton_Click);
            // 
            // openDisplaysFolderButton
            // 
            resources.ApplyResources(this.openDisplaysFolderButton, "openDisplaysFolderButton");
            this.openDisplaysFolderButton.Name = "openDisplaysFolderButton";
            this.openDisplaysFolderButton.UseVisualStyleBackColor = true;
            this.openDisplaysFolderButton.Click += new System.EventHandler(this.openDisplaysFolderButton_Click);
            // 
            // openComponentsFolderButton
            // 
            resources.ApplyResources(this.openComponentsFolderButton, "openComponentsFolderButton");
            this.openComponentsFolderButton.Name = "openComponentsFolderButton";
            this.openComponentsFolderButton.UseVisualStyleBackColor = true;
            this.openComponentsFolderButton.Click += new System.EventHandler(this.openComponentsFolderButton_Click_1);
            // 
            // refreshDashboardsListButton
            // 
            resources.ApplyResources(this.refreshDashboardsListButton, "refreshDashboardsListButton");
            this.refreshDashboardsListButton.Name = "refreshDashboardsListButton";
            this.refreshDashboardsListButton.UseVisualStyleBackColor = true;
            this.refreshDashboardsListButton.Click += new System.EventHandler(this.refreshDashboardListButton_Click);
            // 
            // refreshDisplayListButton
            // 
            resources.ApplyResources(this.refreshDisplayListButton, "refreshDisplayListButton");
            this.refreshDisplayListButton.Name = "refreshDisplayListButton";
            this.refreshDisplayListButton.UseVisualStyleBackColor = true;
            this.refreshDisplayListButton.Click += new System.EventHandler(this.refreshDisplayListButton_Click);
            // 
            // componentToolStripMenuItem
            // 
            this.componentToolStripMenuItem.Name = "componentToolStripMenuItem";
            resources.ApplyResources(this.componentToolStripMenuItem, "componentToolStripMenuItem");
            this.componentToolStripMenuItem.Click += new System.EventHandler(this.componentToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            resources.ApplyResources(this.displayToolStripMenuItem, "displayToolStripMenuItem");
            // 
            // imomsDisplayMockupFramework
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.utilsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.displaysGroupBox);
            this.KeyPreview = true;
            this.Name = "imomsDisplayMockupFramework";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.imomsDisplayMockupFramework_KeyDown);
            this.displaysGroupBox.ResumeLayout(false);
            this.displaysGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.utilsGroupBox.ResumeLayout(false);
            this.utilsGroupBox.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newDisplay;
        private System.Windows.Forms.ComboBox loadDisplayComboBox;
        private System.Windows.Forms.Label loadDisplayLabel;
        private System.Windows.Forms.Button refreshDisplayListButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox displaysGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createDashboardButton;
        private System.Windows.Forms.Label loadDashboardLabel;
        private System.Windows.Forms.Button refreshDashboardsListButton;
        private System.Windows.Forms.ComboBox loadDashboardComboBox;
        private System.Windows.Forms.GroupBox utilsGroupBox;
        private System.Windows.Forms.Button openComponentsFolderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button regenerateAllButton;
        private System.Windows.Forms.Button editDashboardsFolderButton;
        private System.Windows.Forms.Button openDashboardsFodlerButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button editDisplaysFolderButton;
        private System.Windows.Forms.Button editComponentsFolderButton;
        private System.Windows.Forms.Button openDisplaysFolderButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editDashboardsConfigFilesFolderButton;
        private System.Windows.Forms.Button openDashboardsConfigFilesFolderButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editDisplaysConfigFilesFolderButton;
        private System.Windows.Forms.Button openDisplaysConfigFileFolderButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button editRibbonFolderButton;
        private System.Windows.Forms.Button openRibbonsFolderButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem utilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displaysToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dashboardsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ribbonsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem utilsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem componentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem displaysToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem dashboardsToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ribbonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem displaysToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dashboardsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem componentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
    }
}

