
namespace GimpiesWinForms
{
    partial class DAVerwijderen
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
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.GimpiesLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDAVShoeNumber = new System.Windows.Forms.TextBox();
            this.DAVGenerate = new System.Windows.Forms.Button();
            this.tbDAVShoeCheck = new System.Windows.Forms.TextBox();
            this.btBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::GimpiesWinForms.Properties.Resources._123123;
            this.button1.Location = new System.Drawing.Point(244, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 35);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(104, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Schoenen Verwijderen";
            // 
            // GimpiesLabel
            // 
            this.GimpiesLabel.AutoSize = true;
            this.GimpiesLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GimpiesLabel.Location = new System.Drawing.Point(84, 12);
            this.GimpiesLabel.Name = "GimpiesLabel";
            this.GimpiesLabel.Size = new System.Drawing.Size(164, 25);
            this.GimpiesLabel.TabIndex = 13;
            this.GimpiesLabel.Text = "GIMPIES ONLINE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GimpiesWinForms.Properties.Resources.gimpies;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Shoe Number:";
            // 
            // tbDAVShoeNumber
            // 
            this.tbDAVShoeNumber.Location = new System.Drawing.Point(102, 91);
            this.tbDAVShoeNumber.Name = "tbDAVShoeNumber";
            this.tbDAVShoeNumber.Size = new System.Drawing.Size(100, 23);
            this.tbDAVShoeNumber.TabIndex = 16;
            // 
            // DAVGenerate
            // 
            this.DAVGenerate.Location = new System.Drawing.Point(220, 90);
            this.DAVGenerate.Name = "DAVGenerate";
            this.DAVGenerate.Size = new System.Drawing.Size(62, 23);
            this.DAVGenerate.TabIndex = 17;
            this.DAVGenerate.Text = "Generate";
            this.DAVGenerate.UseVisualStyleBackColor = true;
            this.DAVGenerate.Click += new System.EventHandler(this.DAVGenerate_Click);
            // 
            // tbDAVShoeCheck
            // 
            this.tbDAVShoeCheck.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbDAVShoeCheck.Location = new System.Drawing.Point(102, 121);
            this.tbDAVShoeCheck.Multiline = true;
            this.tbDAVShoeCheck.Name = "tbDAVShoeCheck";
            this.tbDAVShoeCheck.ReadOnly = true;
            this.tbDAVShoeCheck.Size = new System.Drawing.Size(100, 128);
            this.tbDAVShoeCheck.TabIndex = 18;
            // 
            // btBack
            // 
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Image = global::GimpiesWinForms.Properties.Resources.undo;
            this.btBack.Location = new System.Drawing.Point(12, 269);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(32, 32);
            this.btBack.TabIndex = 32;
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // DAVerwijderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 313);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.tbDAVShoeCheck);
            this.Controls.Add(this.DAVGenerate);
            this.Controls.Add(this.tbDAVShoeNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GimpiesLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DAVerwijderen";
            this.Text = "DAVerwijderen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label GimpiesLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDAVShoeNumber;
        private System.Windows.Forms.Button DAVGenerate;
        private System.Windows.Forms.TextBox tbDAVShoeCheck;
        private System.Windows.Forms.Button btBack;
    }
}