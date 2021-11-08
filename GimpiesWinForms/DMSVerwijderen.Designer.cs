
namespace GimpiesWinForms
{
    partial class DMSVerwijderen
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
            this.btBack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.GimpiesLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbVerwijderen = new System.Windows.Forms.CheckBox();
            this.btVerwijderen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbVStaffID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Image = global::GimpiesWinForms.Properties.Resources.undo;
            this.btBack.Location = new System.Drawing.Point(280, 12);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(32, 32);
            this.btBack.TabIndex = 4;
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(116, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 21);
            this.label9.TabIndex = 41;
            this.label9.Text = "Medewerkers";
            // 
            // GimpiesLabel
            // 
            this.GimpiesLabel.AutoSize = true;
            this.GimpiesLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GimpiesLabel.Location = new System.Drawing.Point(94, 12);
            this.GimpiesLabel.Name = "GimpiesLabel";
            this.GimpiesLabel.Size = new System.Drawing.Size(164, 25);
            this.GimpiesLabel.TabIndex = 42;
            this.GimpiesLabel.Text = "GIMPIES ONLINE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GimpiesWinForms.Properties.Resources.gimpies;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbVerwijderen);
            this.panel2.Controls.Add(this.btVerwijderen);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbVStaffID);
            this.panel2.Location = new System.Drawing.Point(12, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 70);
            this.panel2.TabIndex = 44;
            // 
            // cbVerwijderen
            // 
            this.cbVerwijderen.AutoSize = true;
            this.cbVerwijderen.Location = new System.Drawing.Point(157, 48);
            this.cbVerwijderen.Name = "cbVerwijderen";
            this.cbVerwijderen.Size = new System.Drawing.Size(15, 14);
            this.cbVerwijderen.TabIndex = 2;
            this.cbVerwijderen.UseVisualStyleBackColor = true;
            // 
            // btVerwijderen
            // 
            this.btVerwijderen.Location = new System.Drawing.Point(178, 43);
            this.btVerwijderen.Name = "btVerwijderen";
            this.btVerwijderen.Size = new System.Drawing.Size(100, 23);
            this.btVerwijderen.TabIndex = 3;
            this.btVerwijderen.Text = "Verwijderen";
            this.btVerwijderen.UseVisualStyleBackColor = true;
            this.btVerwijderen.Click += new System.EventHandler(this.btVerwijderen_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "Staff ID:";
            // 
            // tbVStaffID
            // 
            this.tbVStaffID.Location = new System.Drawing.Point(178, 14);
            this.tbVStaffID.Name = "tbVStaffID";
            this.tbVStaffID.Size = new System.Drawing.Size(100, 23);
            this.tbVStaffID.TabIndex = 1;
            this.tbVStaffID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbVStaffID_KeyDown);
            // 
            // DMSVerwijderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 164);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GimpiesLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DMSVerwijderen";
            this.Text = "DMSVerwijderen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label GimpiesLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbVerwijderen;
        private System.Windows.Forms.Button btVerwijderen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbVStaffID;
    }
}