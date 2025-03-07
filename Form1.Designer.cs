namespace ToDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toDoListBox = new System.Windows.Forms.ListBox();
            this.listEntryBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toDoListBox
            // 
            this.toDoListBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toDoListBox.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDoListBox.FormattingEnabled = true;
            this.toDoListBox.ItemHeight = 35;
            this.toDoListBox.Location = new System.Drawing.Point(40, 275);
            this.toDoListBox.Margin = new System.Windows.Forms.Padding(4);
            this.toDoListBox.Name = "toDoListBox";
            this.toDoListBox.Size = new System.Drawing.Size(815, 249);
            this.toDoListBox.TabIndex = 0;
            this.toDoListBox.SelectedIndexChanged += new System.EventHandler(this.toDoListBox_SelectedIndexChanged);
            // 
            // listEntryBox
            // 
            this.listEntryBox.Location = new System.Drawing.Point(40, 235);
            this.listEntryBox.Name = "listEntryBox";
            this.listEntryBox.Size = new System.Drawing.Size(457, 34);
            this.listEntryBox.TabIndex = 1;
            this.listEntryBox.TextChanged += new System.EventHandler(this.listEntryBox_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(503, 235);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(177, 34);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add Item";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(686, 234);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(177, 34);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Item";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(503, 195);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(177, 34);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load List";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(686, 195);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(177, 34);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save List";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(886, 585);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listEntryBox);
            this.Controls.Add(this.toDoListBox);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "TO-DO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox toDoListBox;
        private System.Windows.Forms.TextBox listEntryBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
    }
}

