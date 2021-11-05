
namespace GimpiesWinForms
{
    partial class DMSAanpassen
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbAanpassen = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbAStaffID = new System.Windows.Forms.TextBox();
            this.tbAUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Image = global::GimpiesWinForms.Properties.Resources.undo;
            this.btBack.Location = new System.Drawing.Point(280, 12);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(32, 32);
            this.btBack.TabIndex = 7;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.cbAanpassen);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbAPassword);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.tbAStaffID);
            this.panel3.Controls.Add(this.tbAUsername);
            this.panel3.Location = new System.Drawing.Point(12, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 132);
            this.panel3.TabIndex = 44;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // cbAanpassen
            // 
            this.cbAanpassen.AutoSize = true;
            this.cbAanpassen.Location = new System.Drawing.Point(157, 104);
            this.cbAanpassen.Name = "cbAanpassen";
            this.cbAanpassen.Size = new System.Drawing.Size(15, 14);
            this.cbAanpassen.TabIndex = 5;
            this.cbAanpassen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Staff ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Password:";
            // 
            // tbAPassword
            // 
            this.tbAPassword.Location = new System.Drawing.Point(178, 42);
            this.tbAPassword.Name = "tbAPassword";
            this.tbAPassword.Size = new System.Drawing.Size(100, 23);
            this.tbAPassword.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Username:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aanpassen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbAStaffID
            // 
            this.tbAStaffID.Location = new System.Drawing.Point(63, 13);
            this.tbAStaffID.Name = "tbAStaffID";
            this.tbAStaffID.Size = new System.Drawing.Size(35, 23);
            this.tbAStaffID.TabIndex = 1;
            // 
            // tbAUsername
            // 
            this.tbAUsername.Location = new System.Drawing.Point(178, 13);
            this.tbAUsername.Name = "tbAUsername";
            this.tbAUsername.Size = new System.Drawing.Size(100, 23);
            this.tbAUsername.TabIndex = 2;
            // 
            // DMSAanpassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 227);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GimpiesLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DMSAanpassen";
            this.Text = "DMSAanpassen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label GimpiesLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbAanpassen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbAStaffID;
        private System.Windows.Forms.TextBox tbAUsername;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}