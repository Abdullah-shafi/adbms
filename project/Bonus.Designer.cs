namespace project
{
    partial class Bonus
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNum = new System.Windows.Forms.Label();
            this.textBoxNComm = new System.Windows.Forms.TextBox();
            this.textBoxUId = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum.Location = new System.Drawing.Point(143, 135);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(152, 25);
            this.labelNum.TabIndex = 23;
            this.labelNum.Text = "Bonus Amount :";
            this.labelNum.Click += new System.EventHandler(this.labelNum_Click);
            // 
            // textBoxNComm
            // 
            this.textBoxNComm.Location = new System.Drawing.Point(316, 135);
            this.textBoxNComm.Multiline = true;
            this.textBoxNComm.Name = "textBoxNComm";
            this.textBoxNComm.Size = new System.Drawing.Size(230, 31);
            this.textBoxNComm.TabIndex = 22;
            // 
            // textBoxUId
            // 
            this.textBoxUId.Location = new System.Drawing.Point(316, 61);
            this.textBoxUId.Multiline = true;
            this.textBoxUId.Name = "textBoxUId";
            this.textBoxUId.Size = new System.Drawing.Size(233, 31);
            this.textBoxUId.TabIndex = 21;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(170, 61);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(125, 25);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Manager ID :";
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelAdd.Location = new System.Drawing.Point(310, 1);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(134, 34);
            this.labelAdd.TabIndex = 19;
            this.labelAdd.Text = "Add Bonus";
            this.labelAdd.Click += new System.EventHandler(this.labelAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonUpdate.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(316, 212);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(230, 34);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Add";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Bonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.textBoxNComm);
            this.Controls.Add(this.textBoxUId);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.buttonUpdate);
            this.Name = "Bonus";
            this.Size = new System.Drawing.Size(719, 247);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.TextBox textBoxNComm;
        private System.Windows.Forms.TextBox textBoxUId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
