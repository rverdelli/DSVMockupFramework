namespace IMOMS_Display_Mockup_Framework
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.newDisplay = new System.Windows.Forms.Button();
            this.loadDisplayComboBox = new System.Windows.Forms.ComboBox();
            this.loadDisplayLabel = new System.Windows.Forms.Label();
            this.refreshDisplayListButton = new System.Windows.Forms.Button();
            this.regenerateDisplaysButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // refreshDisplayListButton
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // 
            resources.ApplyResources(this.refreshDisplayListButton, "refreshDisplayListButton");
            this.refreshDisplayListButton.Name = "refreshDisplayListButton";
            this.refreshDisplayListButton.UseVisualStyleBackColor = true;
            this.refreshDisplayListButton.Click += new System.EventHandler(this.refreshDisplayListButton_Click);
            // 
            // regenerateDisplaysButton
            // 
            resources.ApplyResources(this.regenerateDisplaysButton, "regenerateDisplaysButton");
            this.regenerateDisplaysButton.Name = "regenerateDisplaysButton";
            this.regenerateDisplaysButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.regenerateDisplaysButton);
            this.Controls.Add(this.refreshDisplayListButton);
            this.Controls.Add(this.loadDisplayLabel);
            this.Controls.Add(this.loadDisplayComboBox);
            this.Controls.Add(this.newDisplay);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button newDisplay;
        private System.Windows.Forms.ComboBox loadDisplayComboBox;
        private System.Windows.Forms.Label loadDisplayLabel;
        private System.Windows.Forms.Button refreshDisplayListButton;
        private System.Windows.Forms.Button regenerateDisplaysButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

