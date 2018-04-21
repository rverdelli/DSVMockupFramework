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
            this.refreshDisplayListButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.displaysGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createDashboardButton = new System.Windows.Forms.Button();
            this.loadDashboardLabel = new System.Windows.Forms.Label();
            this.refreshDashboardsListButton = new System.Windows.Forms.Button();
            this.loadDashboardComboBox = new System.Windows.Forms.ComboBox();
            this.utilsGroupBox = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.componentsFolderEditPathButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openComponentsFolderButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regenerateAllButton = new System.Windows.Forms.Button();
            this.displaysConfigFilesFolderEdit = new System.Windows.Forms.Button();
            this.displaysConfigFileFolderOpen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dashboardsConfigFilesFolderEdit = new System.Windows.Forms.Button();
            this.dashboardsConfigFilesFolderOpen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.displaysGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.utilsGroupBox.SuspendLayout();
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
            // refreshDisplayListButton
            // 
            resources.ApplyResources(this.refreshDisplayListButton, "refreshDisplayListButton");
            this.refreshDisplayListButton.Name = "refreshDisplayListButton";
            this.refreshDisplayListButton.UseVisualStyleBackColor = true;
            this.refreshDisplayListButton.Click += new System.EventHandler(this.refreshDisplayListButton_Click);
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
            // refreshDashboardsListButton
            // 
            resources.ApplyResources(this.refreshDashboardsListButton, "refreshDashboardsListButton");
            this.refreshDashboardsListButton.Name = "refreshDashboardsListButton";
            this.refreshDashboardsListButton.UseVisualStyleBackColor = true;
            this.refreshDashboardsListButton.Click += new System.EventHandler(this.refreshDashboardListButton_Click);
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
            this.utilsGroupBox.Controls.Add(this.dashboardsConfigFilesFolderEdit);
            this.utilsGroupBox.Controls.Add(this.dashboardsConfigFilesFolderOpen);
            this.utilsGroupBox.Controls.Add(this.label5);
            this.utilsGroupBox.Controls.Add(this.displaysConfigFilesFolderEdit);
            this.utilsGroupBox.Controls.Add(this.displaysConfigFileFolderOpen);
            this.utilsGroupBox.Controls.Add(this.label4);
            this.utilsGroupBox.Controls.Add(this.button4);
            this.utilsGroupBox.Controls.Add(this.button5);
            this.utilsGroupBox.Controls.Add(this.label3);
            this.utilsGroupBox.Controls.Add(this.button2);
            this.utilsGroupBox.Controls.Add(this.componentsFolderEditPathButton);
            this.utilsGroupBox.Controls.Add(this.button3);
            this.utilsGroupBox.Controls.Add(this.openComponentsFolderButton);
            this.utilsGroupBox.Controls.Add(this.label2);
            this.utilsGroupBox.Controls.Add(this.label1);
            this.utilsGroupBox.Controls.Add(this.regenerateAllButton);
            this.utilsGroupBox.Name = "utilsGroupBox";
            this.utilsGroupBox.TabStop = false;
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.openDashboardsFolderButton_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // componentsFolderEditPathButton
            // 
            resources.ApplyResources(this.componentsFolderEditPathButton, "componentsFolderEditPathButton");
            this.componentsFolderEditPathButton.Name = "componentsFolderEditPathButton";
            this.componentsFolderEditPathButton.UseVisualStyleBackColor = true;
            this.componentsFolderEditPathButton.Click += new System.EventHandler(this.componentsFolderEditPathButton_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.ClientSizeChanged += new System.EventHandler(this.openDisplaysFolderButton_Click);
            // 
            // openComponentsFolderButton
            // 
            resources.ApplyResources(this.openComponentsFolderButton, "openComponentsFolderButton");
            this.openComponentsFolderButton.Name = "openComponentsFolderButton";
            this.openComponentsFolderButton.UseVisualStyleBackColor = true;
            this.openComponentsFolderButton.Click += new System.EventHandler(this.openComponentsFolderButton_Click_1);
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
            // displaysConfigFilesFolderEdit
            // 
            resources.ApplyResources(this.displaysConfigFilesFolderEdit, "displaysConfigFilesFolderEdit");
            this.displaysConfigFilesFolderEdit.Name = "displaysConfigFilesFolderEdit";
            this.displaysConfigFilesFolderEdit.UseVisualStyleBackColor = true;
            this.displaysConfigFilesFolderEdit.Click += new System.EventHandler(this.displayConfigFolderEditPathButton_Click);
            // 
            // displaysConfigFileFolderOpen
            // 
            resources.ApplyResources(this.displaysConfigFileFolderOpen, "displaysConfigFileFolderOpen");
            this.displaysConfigFileFolderOpen.Name = "displaysConfigFileFolderOpen";
            this.displaysConfigFileFolderOpen.UseVisualStyleBackColor = true;
            this.displaysConfigFileFolderOpen.Click += new System.EventHandler(this.openDisplayConfigFilesFolderButton_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // dashboardsConfigFilesFolderEdit
            // 
            resources.ApplyResources(this.dashboardsConfigFilesFolderEdit, "dashboardsConfigFilesFolderEdit");
            this.dashboardsConfigFilesFolderEdit.Name = "dashboardsConfigFilesFolderEdit";
            this.dashboardsConfigFilesFolderEdit.UseVisualStyleBackColor = true;
            this.dashboardsConfigFilesFolderEdit.Click += new System.EventHandler(this.dashboardsConfigFolderEditPathButton_Click);
            // 
            // dashboardsConfigFilesFolderOpen
            // 
            resources.ApplyResources(this.dashboardsConfigFilesFolderOpen, "dashboardsConfigFilesFolderOpen");
            this.dashboardsConfigFilesFolderOpen.Name = "dashboardsConfigFilesFolderOpen";
            this.dashboardsConfigFilesFolderOpen.UseVisualStyleBackColor = true;
            this.dashboardsConfigFilesFolderOpen.Click += new System.EventHandler(this.openDashboardConfigFilesFolderButton_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // imomsDisplayMockupFramework
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.utilsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.displaysGroupBox);
            this.Name = "imomsDisplayMockupFramework";
            this.displaysGroupBox.ResumeLayout(false);
            this.displaysGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.utilsGroupBox.ResumeLayout(false);
            this.utilsGroupBox.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button componentsFolderEditPathButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dashboardsConfigFilesFolderEdit;
        private System.Windows.Forms.Button dashboardsConfigFilesFolderOpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button displaysConfigFilesFolderEdit;
        private System.Windows.Forms.Button displaysConfigFileFolderOpen;
        private System.Windows.Forms.Label label4;
    }
}

