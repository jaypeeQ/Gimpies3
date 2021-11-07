
namespace GimpiesWinForms
{
    partial class DMSToevoegen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbToevoegen = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTPassword = new System.Windows.Forms.TextBox();
            this.btToevoegen = new System.Windows.Forms.Button();
            this.tbTUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Image = global::GimpiesWinForms.Properties.Resources.undo;
            this.btBack.Location = new System.Drawing.Point(280, 12);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(32, 32);
            this.btBack.TabIndex = 5;
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
            this.label9.TabIndex = 37;
            this.label9.Text = "Medewerkers";
            // 
            // GimpiesLabel
            // 
            this.GimpiesLabel.AutoSize = true;
            this.GimpiesLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GimpiesLabel.Location = new System.Drawing.Point(94, 12);
            this.GimpiesLabel.Name = "GimpiesLabel";
            this.GimpiesLabel.Size = new System.Drawing.Size(164, 25);
            this.GimpiesLabel.TabIndex = 38;
            this.GimpiesLabel.Text = "GIMPIES ONLINE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GimpiesWinForms.Properties.Resources.gimpies;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.cbToevoegen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbTPassword);
            this.panel1.Controls.Add(this.btToevoegen);
            this.panel1.Controls.Add(this.tbTUsername);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 132);
            this.panel1.TabIndex = 40;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // cbToevoegen
            // 
            this.cbToevoegen.AutoSize = true;
            this.cbToevoegen.Location = new System.Drawing.Point(157, 105);
            this.cbToevoegen.Name = "cbToevoegen";
            this.cbToevoegen.Size = new System.Drawing.Size(15, 14);
            this.cbToevoegen.TabIndex = 3;
            this.cbToevoegen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Username:";
            // 
            // tbTPassword
            // 
            this.tbTPassword.Location = new System.Drawing.Point(178, 42);
            this.tbTPassword.Name = "tbTPassword";
            this.tbTPassword.Size = new System.Drawing.Size(100, 23);
            this.tbTPassword.TabIndex = 1;
            // 
            // btToevoegen
            // 
            this.btToevoegen.Location = new System.Drawing.Point(178, 100);
            this.btToevoegen.Name = "btToevoegen";
            this.btToevoegen.Size = new System.Drawing.Size(100, 23);
            this.btToevoegen.TabIndex = 4;
            this.btToevoegen.Text = "Toevoegen";
            this.btToevoegen.UseVisualStyleBackColor = true;
            this.btToevoegen.Click += new System.EventHandler(this.btToevoegen_Click);
            // 
            // tbTUsername
            // 
            this.tbTUsername.Location = new System.Drawing.Point(178, 13);
            this.tbTUsername.Name = "tbTUsername";
            this.tbTUsername.Size = new System.Drawing.Size(100, 23);
            this.tbTUsername.TabIndex = 0;
            // 
            // DMSToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 228);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GimpiesLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DMSToevoegen";
            this.Text = "DMSToevoegen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label GimpiesLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox cbToevoegen;
        public System.Windows.Forms.TextBox tbTPassword;
        public System.Windows.Forms.Button btToevoegen;
        public System.Windows.Forms.TextBox tbTUsername;
    }
}