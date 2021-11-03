
namespace GimpiesWinForms
{
    partial class DMVerwijderen
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
            this.btBack = new System.Windows.Forms.Button();
            this.dgvPopup = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopup)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::GimpiesWinForms.Properties.Resources._123123;
            this.button1.Location = new System.Drawing.Point(223, 126);
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
            this.label1.Location = new System.Drawing.Point(15, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Shoe Number:";
            // 
            // tbDAVShoeNumber
            // 
            this.tbDAVShoeNumber.Location = new System.Drawing.Point(104, 95);
            this.tbDAVShoeNumber.Name = "tbDAVShoeNumber";
            this.tbDAVShoeNumber.Size = new System.Drawing.Size(63, 23);
            this.tbDAVShoeNumber.TabIndex = 16;
            // 
            // btBack
            // 
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Image = global::GimpiesWinForms.Properties.Resources.undo;
            this.btBack.Location = new System.Drawing.Point(15, 129);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(32, 32);
            this.btBack.TabIndex = 32;
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // dgvPopup
            // 
            this.dgvPopup.AllowUserToAddRows = false;
            this.dgvPopup.AllowUserToDeleteRows = false;
            this.dgvPopup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopup.Location = new System.Drawing.Point(283, 12);
            this.dgvPopup.Name = "dgvPopup";
            this.dgvPopup.ReadOnly = true;
            this.dgvPopup.RowTemplate.Height = 25;
            this.dgvPopup.Size = new System.Drawing.Size(524, 149);
            this.dgvPopup.TabIndex = 33;
            // 
            // DAVerwijderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 185);
            this.Controls.Add(this.dgvPopup);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.tbDAVShoeNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GimpiesLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DAVerwijderen";
            this.Text = "DAVerwijderen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopup)).EndInit();
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
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.DataGridView dgvPopup;
    }
}