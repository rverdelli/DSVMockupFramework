namespace IMOMS_Display_Mockup_Framework
{
    partial class DashboardConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardConfig));
            this.label1 = new System.Windows.Forms.Label();
            this.dashboardUniqueIdentifierTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addDisplaysCB = new System.Windows.Forms.ComboBox();
            this.selectedDisplaysGridView = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoveUp = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MoveDown = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ribbonFileTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.selectedDisplaysGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard unique identifier:";
            // 
            // dashboardUniqueIdentifierTextBox
            // 
            this.dashboardUniqueIdentifierTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardUniqueIdentifierTextBox.Location = new System.Drawing.Point(211, 16);
            this.dashboardUniqueIdentifierTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dashboardUniqueIdentifierTextBox.Name = "dashboardUniqueIdentifierTextBox";
            this.dashboardUniqueIdentifierTextBox.Size = new System.Drawing.Size(472, 22);
            this.dashboardUniqueIdentifierTextBox.TabIndex = 1;
            this.dashboardUniqueIdentifierTextBox.TextChanged += new System.EventHandler(this.dashboardUniqueIdentifierTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add display:";
            // 
            // addDisplaysCB
            // 
            this.addDisplaysCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addDisplaysCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.addDisplaysCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.addDisplaysCB.FormattingEnabled = true;
            this.addDisplaysCB.Location = new System.Drawing.Point(211, 80);
            this.addDisplaysCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addDisplaysCB.Name = "addDisplaysCB";
            this.addDisplaysCB.Size = new System.Drawing.Size(472, 24);
            this.addDisplaysCB.TabIndex = 3;
            this.addDisplaysCB.SelectedIndexChanged += new System.EventHandler(this.addDisplaysCB_SelectedIndexChanged);
            // 
            // selectedDisplaysGridView
            // 
            this.selectedDisplaysGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedDisplaysGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedDisplaysGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.DisplayID,
            this.MoveUp,
            this.MoveDown,
            this.Remove});
            this.selectedDisplaysGridView.Location = new System.Drawing.Point(21, 113);
            this.selectedDisplaysGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectedDisplaysGridView.Name = "selectedDisplaysGridView";
            this.selectedDisplaysGridView.Size = new System.Drawing.Size(663, 354);
            this.selectedDisplaysGridView.TabIndex = 4;
            this.selectedDisplaysGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedDisplaysGridView_CellClick);
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "#";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Width = 30;
            // 
            // DisplayID
            // 
            this.DisplayID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DisplayID.HeaderText = "Component ID";
            this.DisplayID.Name = "DisplayID";
            this.DisplayID.ReadOnly = true;
            // 
            // MoveUp
            // 
            this.MoveUp.HeaderText = "";
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.ReadOnly = true;
            this.MoveUp.Width = 55;
            // 
            // MoveDown
            // 
            this.MoveDown.HeaderText = "";
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.ReadOnly = true;
            this.MoveDown.Width = 55;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Width = 55;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(583, 475);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(475, 475);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 28);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ribbon file (auto-selected):";
            // 
            // ribbonFileTextBox
            // 
            this.ribbonFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbonFileTextBox.Location = new System.Drawing.Point(209, 48);
            this.ribbonFileTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonFileTextBox.Name = "ribbonFileTextBox";
            this.ribbonFileTextBox.ReadOnly = true;
            this.ribbonFileTextBox.Size = new System.Drawing.Size(472, 22);
            this.ribbonFileTextBox.TabIndex = 8;
            this.ribbonFileTextBox.Text = "<Not found>";
            // 
            // DashboardConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 518);
            this.Controls.Add(this.ribbonFileTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.selectedDisplaysGridView);
            this.Controls.Add(this.addDisplaysCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dashboardUniqueIdentifierTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DashboardConfig";
            this.Text = "DisplayConfig";
            ((System.ComponentModel.ISupportInitialize)(this.selectedDisplaysGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dashboardUniqueIdentifierTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox addDisplaysCB;
        private System.Windows.Forms.DataGridView selectedDisplaysGridView;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayID;
        private System.Windows.Forms.DataGridViewButtonColumn MoveUp;
        private System.Windows.Forms.DataGridViewButtonColumn MoveDown;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ribbonFileTextBox;
    }
}