namespace project
{
    partial class Manager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteManagerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whoBookedCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whoBoughtCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.dataGridViewmanager = new System.Windows.Forms.DataGridView();
            this.disableUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmanager)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1375, 63);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.managerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allManagerToolStripMenuItem,
            this.deleteManagerToolStripMenuItem,
            this.deleteManagerToolStripMenuItem1});
            this.managerToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(90, 59);
            this.managerToolStripMenuItem.Text = "Car";
            this.managerToolStripMenuItem.Click += new System.EventHandler(this.managerToolStripMenuItem_Click);
            // 
            // allManagerToolStripMenuItem
            // 
            this.allManagerToolStripMenuItem.Name = "allManagerToolStripMenuItem";
            this.allManagerToolStripMenuItem.Size = new System.Drawing.Size(274, 60);
            this.allManagerToolStripMenuItem.Text = "All Car";
            this.allManagerToolStripMenuItem.Click += new System.EventHandler(this.allManagerToolStripMenuItem_Click);
            // 
            // deleteManagerToolStripMenuItem
            // 
            this.deleteManagerToolStripMenuItem.Name = "deleteManagerToolStripMenuItem";
            this.deleteManagerToolStripMenuItem.Size = new System.Drawing.Size(274, 60);
            this.deleteManagerToolStripMenuItem.Text = "Add Car";
            this.deleteManagerToolStripMenuItem.Click += new System.EventHandler(this.deleteManagerToolStripMenuItem_Click);
            // 
            // deleteManagerToolStripMenuItem1
            // 
            this.deleteManagerToolStripMenuItem1.Name = "deleteManagerToolStripMenuItem1";
            this.deleteManagerToolStripMenuItem1.Size = new System.Drawing.Size(274, 60);
            this.deleteManagerToolStripMenuItem1.Text = "Delete Car";
            this.deleteManagerToolStripMenuItem1.Click += new System.EventHandler(this.deleteManagerToolStripMenuItem1_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.employeeToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(164, 59);
            this.employeeToolStripMenuItem.Text = "Sale Car";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.MistyRose;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.whoBookedCarToolStripMenuItem,
            this.whoBoughtCarToolStripMenuItem,
            this.disableUserToolStripMenuItem,
            this.enableUserToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Sitka Banner", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.OrangeRed;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 59);
            this.toolStripMenuItem1.Text = "User";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(371, 60);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // whoBookedCarToolStripMenuItem
            // 
            this.whoBookedCarToolStripMenuItem.Name = "whoBookedCarToolStripMenuItem";
            this.whoBookedCarToolStripMenuItem.Size = new System.Drawing.Size(371, 60);
            this.whoBookedCarToolStripMenuItem.Text = "Who Booked Car";
            this.whoBookedCarToolStripMenuItem.Click += new System.EventHandler(this.whoBookedCarToolStripMenuItem_Click);
            // 
            // whoBoughtCarToolStripMenuItem
            // 
            this.whoBoughtCarToolStripMenuItem.Name = "whoBoughtCarToolStripMenuItem";
            this.whoBoughtCarToolStripMenuItem.Size = new System.Drawing.Size(371, 60);
            this.whoBoughtCarToolStripMenuItem.Text = "Who Bought Car";
            this.whoBoughtCarToolStripMenuItem.Click += new System.EventHandler(this.whoBoughtCarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.MistyRose;
            this.toolStripMenuItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Sitka Banner", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.OrangeRed;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(110, 59);
            this.toolStripMenuItem2.Text = "Back";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAdd.Location = new System.Drawing.Point(681, 64);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(682, 394);
            this.panelAdd.TabIndex = 3;
            this.panelAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdd_Paint);
            // 
            // panelDelete
            // 
            this.panelDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDelete.Location = new System.Drawing.Point(681, 455);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(682, 188);
            this.panelDelete.TabIndex = 4;
            // 
            // dataGridViewmanager
            // 
            this.dataGridViewmanager.AllowUserToDeleteRows = false;
            this.dataGridViewmanager.AllowUserToResizeColumns = false;
            this.dataGridViewmanager.AllowUserToResizeRows = false;
            this.dataGridViewmanager.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewmanager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewmanager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmanager.Cursor = System.Windows.Forms.Cursors.No;
            this.dataGridViewmanager.Location = new System.Drawing.Point(12, 64);
            this.dataGridViewmanager.Name = "dataGridViewmanager";
            this.dataGridViewmanager.RowTemplate.Height = 24;
            this.dataGridViewmanager.Size = new System.Drawing.Size(663, 579);
            this.dataGridViewmanager.TabIndex = 5;
            // 
            // disableUserToolStripMenuItem
            // 
            this.disableUserToolStripMenuItem.Name = "disableUserToolStripMenuItem";
            this.disableUserToolStripMenuItem.Size = new System.Drawing.Size(371, 60);
            this.disableUserToolStripMenuItem.Text = "Disable User";
            this.disableUserToolStripMenuItem.Click += new System.EventHandler(this.disableUserToolStripMenuItem_Click);
            // 
            // enableUserToolStripMenuItem
            // 
            this.enableUserToolStripMenuItem.Name = "enableUserToolStripMenuItem";
            this.enableUserToolStripMenuItem.Size = new System.Drawing.Size(371, 60);
            this.enableUserToolStripMenuItem.Text = "Enable User";
            this.enableUserToolStripMenuItem.Click += new System.EventHandler(this.enableUserToolStripMenuItem_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 655);
            this.Controls.Add(this.dataGridViewmanager);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmanager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteManagerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.DataGridView dataGridViewmanager;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whoBookedCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whoBoughtCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableUserToolStripMenuItem;

    }
}