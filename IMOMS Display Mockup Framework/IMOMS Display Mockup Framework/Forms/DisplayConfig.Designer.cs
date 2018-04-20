namespace IMOMS_Display_Mockup_Framework
{
    partial class DisplayConfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.displayUniqueIdentifierTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addComponentsCB = new System.Windows.Forms.ComboBox();
            this.selectedComponentsGridView = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoveUp = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MoveDown = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectedComponentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display unique identifier:";
            // 
            // displayUniqueIdentifierTextBox
            // 
            this.displayUniqueIdentifierTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayUniqueIdentifierTextBox.Location = new System.Drawing.Point(141, 13);
            this.displayUniqueIdentifierTextBox.Name = "displayUniqueIdentifierTextBox";
            this.displayUniqueIdentifierTextBox.Size = new System.Drawing.Size(372, 20);
            this.displayUniqueIdentifierTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add component:";
            // 
            // addComponentsCB
            // 
            this.addComponentsCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addComponentsCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.addComponentsCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.addComponentsCB.FormattingEnabled = true;
            this.addComponentsCB.Location = new System.Drawing.Point(141, 46);
            this.addComponentsCB.Name = "addComponentsCB";
            this.addComponentsCB.Size = new System.Drawing.Size(372, 21);
            this.addComponentsCB.TabIndex = 3;
            this.addComponentsCB.SelectedIndexChanged += new System.EventHandler(this.addComponentsCB_SelectedIndexChanged);
            // 
            // selectedComponentsGridView
            // 
            this.selectedComponentsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedComponentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedComponentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.ComponentID,
            this.MoveUp,
            this.MoveDown,
            this.Remove});
            this.selectedComponentsGridView.Location = new System.Drawing.Point(16, 86);
            this.selectedComponentsGridView.Name = "selectedComponentsGridView";
            this.selectedComponentsGridView.Size = new System.Drawing.Size(497, 284);
            this.selectedComponentsGridView.TabIndex = 4;
            this.selectedComponentsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedComponentsGridView_CellClick);
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "#";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Width = 30;
            // 
            // ComponentID
            // 
            this.ComponentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComponentID.HeaderText = "Component ID";
            this.ComponentID.Name = "ComponentID";
            this.ComponentID.ReadOnly = true;
            // 
            // MoveUp
            // 
            this.MoveUp.HeaderText = "";
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.ReadOnly = true;
            this.MoveUp.Width = 40;
            // 
            // MoveDown
            // 
            this.MoveDown.HeaderText = "";
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.ReadOnly = true;
            this.MoveDown.Width = 40;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Width = 40;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(437, 376);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(356, 376);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // DisplayConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 411);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.selectedComponentsGridView);
            this.Controls.Add(this.addComponentsCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displayUniqueIdentifierTextBox);
            this.Controls.Add(this.label1);
            this.Name = "DisplayConfig";
            this.Text = "DisplayConfig";
            ((System.ComponentModel.ISupportInitialize)(this.selectedComponentsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox displayUniqueIdentifierTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox addComponentsCB;
        private System.Windows.Forms.DataGridView selectedComponentsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentID;
        private System.Windows.Forms.DataGridViewButtonColumn MoveUp;
        private System.Windows.Forms.DataGridViewButtonColumn MoveDown;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
    }
}