namespace project
{
    partial class addcar
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
            this.labelVill = new System.Windows.Forms.Label();
            this.detailstextbox = new System.Windows.Forms.TextBox();
            this.pricetextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.labelAdd = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.availabletextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelVill
            // 
            this.labelVill.AutoSize = true;
            this.labelVill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVill.Location = new System.Drawing.Point(79, 231);
            this.labelVill.Name = "labelVill";
            this.labelVill.Size = new System.Drawing.Size(82, 25);
            this.labelVill.TabIndex = 19;
            this.labelVill.Text = "Details :";
            // 
            // detailstextbox
            // 
            this.detailstextbox.Location = new System.Drawing.Point(238, 216);
            this.detailstextbox.Multiline = true;
            this.detailstextbox.Name = "detailstextbox";
            this.detailstextbox.Size = new System.Drawing.Size(185, 56);
            this.detailstextbox.TabIndex = 18;
            // 
            // pricetextbox
            // 
            this.pricetextbox.Location = new System.Drawing.Point(238, 168);
            this.pricetextbox.Multiline = true;
            this.pricetextbox.Name = "pricetextbox";
            this.pricetextbox.Size = new System.Drawing.Size(185, 31);
            this.pricetextbox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Price :";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum.Location = new System.Drawing.Point(86, 110);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(75, 25);
            this.labelNum.TabIndex = 15;
            this.labelNum.Text = "Name :";
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(238, 104);
            this.nametextbox.Multiline = true;
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(185, 31);
            this.nametextbox.TabIndex = 14;
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelAdd.Location = new System.Drawing.Point(279, 36);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(104, 34);
            this.labelAdd.TabIndex = 11;
            this.labelAdd.Text = "Add Car";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(238, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Available :";
            // 
            // availabletextbox
            // 
            this.availabletextbox.Location = new System.Drawing.Point(238, 303);
            this.availabletextbox.Multiline = true;
            this.availabletextbox.Name = "availabletextbox";
            this.availabletextbox.Size = new System.Drawing.Size(185, 31);
            this.availabletextbox.TabIndex = 23;
            // 
            // addcar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.availabletextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelVill);
            this.Controls.Add(this.detailstextbox);
            this.Controls.Add(this.pricetextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.button2);
            this.Name = "addcar";
            this.Size = new System.Drawing.Size(682, 383);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVill;
        private System.Windows.Forms.TextBox detailstextbox;
        private System.Windows.Forms.TextBox pricetextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox availabletextbox;
    }
}
