namespace project
{
    partial class AddManager
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhn = new System.Windows.Forms.TextBox();
            this.labelNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.labelVill = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Red;
            this.buttonAdd.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(296, 210);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 34);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelAdd.Location = new System.Drawing.Point(208, 0);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(163, 34);
            this.labelAdd.TabIndex = 1;
            this.labelAdd.Text = "Add Manager";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(38, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(75, 25);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(141, 41);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(233, 31);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxPhn
            // 
            this.textBoxPhn.Location = new System.Drawing.Point(141, 109);
            this.textBoxPhn.Multiline = true;
            this.textBoxPhn.Name = "textBoxPhn";
            this.textBoxPhn.Size = new System.Drawing.Size(230, 31);
            this.textBoxPhn.TabIndex = 4;
            this.textBoxPhn.TextChanged += new System.EventHandler(this.textBoxPhn_TextChanged);
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum.Location = new System.Drawing.Point(19, 109);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(114, 25);
            this.labelNum.TabIndex = 5;
            this.labelNum.Text = "M.Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password :";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(141, 157);
            this.textBoxPass.Multiline = true;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(230, 31);
            this.textBoxPass.TabIndex = 7;
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(402, 77);
            this.textBoxAdd.Multiline = true;
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(301, 109);
            this.textBoxAdd.TabIndex = 8;
            // 
            // labelVill
            // 
            this.labelVill.AutoSize = true;
            this.labelVill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVill.Location = new System.Drawing.Point(514, 37);
            this.labelVill.Name = "labelVill";
            this.labelVill.Size = new System.Drawing.Size(96, 25);
            this.labelVill.TabIndex = 9;
            this.labelVill.Text = "Address :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AddManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelVill);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.textBoxPhn);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.buttonAdd);
            this.Name = "AddManager";
            this.Size = new System.Drawing.Size(719, 247);
            this.Load += new System.EventHandler(this.AddManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhn;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Label labelVill;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}
