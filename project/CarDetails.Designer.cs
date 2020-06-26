namespace project
{
    partial class CarDetails
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
            this.buttonBook = new System.Windows.Forms.Button();
            this.availabletextbox = new System.Windows.Forms.TextBox();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.labelNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pricetextbox = new System.Windows.Forms.TextBox();
            this.detailstextbox = new System.Windows.Forms.TextBox();
            this.labelVill = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBook
            // 
            this.buttonBook.BackColor = System.Drawing.Color.Red;
            this.buttonBook.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBook.Location = new System.Drawing.Point(354, 445);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(105, 34);
            this.buttonBook.TabIndex = 24;
            this.buttonBook.Text = "Booked";
            this.buttonBook.UseVisualStyleBackColor = false;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // availabletextbox
            // 
            this.availabletextbox.Location = new System.Drawing.Point(315, 396);
            this.availabletextbox.Multiline = true;
            this.availabletextbox.Name = "availabletextbox";
            this.availabletextbox.Size = new System.Drawing.Size(185, 31);
            this.availabletextbox.TabIndex = 37;
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(315, 264);
            this.nametextbox.Multiline = true;
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(185, 31);
            this.nametextbox.TabIndex = 28;
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum.Location = new System.Drawing.Point(223, 264);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(75, 25);
            this.labelNum.TabIndex = 29;
            this.labelNum.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Price :";
            // 
            // pricetextbox
            // 
            this.pricetextbox.Location = new System.Drawing.Point(113, 329);
            this.pricetextbox.Multiline = true;
            this.pricetextbox.Name = "pricetextbox";
            this.pricetextbox.Size = new System.Drawing.Size(185, 31);
            this.pricetextbox.TabIndex = 31;
            // 
            // detailstextbox
            // 
            this.detailstextbox.Location = new System.Drawing.Point(498, 316);
            this.detailstextbox.Multiline = true;
            this.detailstextbox.Name = "detailstextbox";
            this.detailstextbox.Size = new System.Drawing.Size(185, 56);
            this.detailstextbox.TabIndex = 32;
            // 
            // labelVill
            // 
            this.labelVill.AutoSize = true;
            this.labelVill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVill.Location = new System.Drawing.Point(400, 335);
            this.labelVill.Name = "labelVill";
            this.labelVill.Size = new System.Drawing.Size(82, 25);
            this.labelVill.TabIndex = 33;
            this.labelVill.Text = "Details :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(166, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Available :";
            // 
            // CarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.availabletextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelVill);
            this.Controls.Add(this.detailstextbox);
            this.Controls.Add(this.pricetextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.buttonBook);
            this.Name = "CarDetails";
            this.Size = new System.Drawing.Size(707, 479);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.TextBox availabletextbox;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pricetextbox;
        private System.Windows.Forms.TextBox detailstextbox;
        private System.Windows.Forms.Label labelVill;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}
