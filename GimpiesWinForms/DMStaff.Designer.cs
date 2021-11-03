
namespace GimpiesWinForms
{
    partial class DMStaff
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
            this.dgvMedewerker = new System.Windows.Forms.DataGridView();
            this.btToevoegen = new System.Windows.Forms.Button();
            this.tbTUsername = new System.Windows.Forms.TextBox();
            this.tbTPassword = new System.Windows.Forms.TextBox();
            this.tbTAssignedRole = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbToevoegen = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbVerwijderen = new System.Windows.Forms.CheckBox();
            this.btVerwijderen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbVStaffID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbAanpassen = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAAssignedRole = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbAStaffID = new System.Windows.Forms.TextBox();
            this.tbAUsername = new System.Windows.Forms.TextBox();
            this.btUpdateGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedewerker)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Image = global::GimpiesWinForms.Properties.Resources.undo;
            this.btBack.Location = new System.Drawing.Point(12, 435);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(32, 32);
            this.btBack.TabIndex = 35;
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(84, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 21);
            this.label9.TabIndex = 33;
            this.label9.Text = "Medewerkers Aanpassen";
            // 
            // GimpiesLabel
            // 
            this.GimpiesLabel.AutoSize = true;
            this.GimpiesLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GimpiesLabel.Location = new System.Drawing.Point(94, 12);
            this.GimpiesLabel.Name = "GimpiesLabel";
            this.GimpiesLabel.Size = new System.Drawing.Size(164, 25);
            this.GimpiesLabel.TabIndex = 34;
            this.GimpiesLabel.Text = "GIMPIES ONLINE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GimpiesWinForms.Properties.Resources.gimpies;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // dgvMedewerker
            // 
            this.dgvMedewerker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedewerker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedewerker.Location = new System.Drawing.Point(299, 12);
            this.dgvMedewerker.Name = "dgvMedewerker";
            this.dgvMedewerker.RowTemplate.Height = 25;
            this.dgvMedewerker.Size = new System.Drawing.Size(489, 455);
            this.dgvMedewerker.TabIndex = 36;
            // 
            // btToevoegen
            // 
            this.btToevoegen.Location = new System.Drawing.Point(178, 100);
            this.btToevoegen.Name = "btToevoegen";
            this.btToevoegen.Size = new System.Drawing.Size(100, 23);
            this.btToevoegen.TabIndex = 37;
            this.btToevoegen.Text = "Toevoegen";
            this.btToevoegen.UseVisualStyleBackColor = true;
            this.btToevoegen.Click += new System.EventHandler(this.btToevoegen_Click);
            // 
            // tbTUsername
            // 
            this.tbTUsername.Location = new System.Drawing.Point(178, 13);
            this.tbTUsername.Name = "tbTUsername";
            this.tbTUsername.Size = new System.Drawing.Size(100, 23);
            this.tbTUsername.TabIndex = 38;
            // 
            // tbTPassword
            // 
            this.tbTPassword.Location = new System.Drawing.Point(178, 42);
            this.tbTPassword.Name = "tbTPassword";
            this.tbTPassword.Size = new System.Drawing.Size(100, 23);
            this.tbTPassword.TabIndex = 38;
            // 
            // tbTAssignedRole
            // 
            this.tbTAssignedRole.Location = new System.Drawing.Point(178, 71);
            this.tbTAssignedRole.Name = "tbTAssignedRole";
            this.tbTAssignedRole.Size = new System.Drawing.Size(100, 23);
            this.tbTAssignedRole.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbToevoegen);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbTPassword);
            this.panel1.Controls.Add(this.tbTAssignedRole);
            this.panel1.Controls.Add(this.btToevoegen);
            this.panel1.Controls.Add(this.tbTUsername);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 132);
            this.panel1.TabIndex = 39;
            // 
            // cbToevoegen
            // 
            this.cbToevoegen.AutoSize = true;
            this.cbToevoegen.Location = new System.Drawing.Point(157, 105);
            this.cbToevoegen.Name = "cbToevoegen";
            this.cbToevoegen.Size = new System.Drawing.Size(15, 14);
            this.cbToevoegen.TabIndex = 39;
            this.cbToevoegen.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Role: ";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.cbVerwijderen);
            this.panel2.Controls.Add(this.btVerwijderen);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbVStaffID);
            this.panel2.Location = new System.Drawing.Point(12, 359);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 70);
            this.panel2.TabIndex = 39;
            // 
            // cbVerwijderen
            // 
            this.cbVerwijderen.AutoSize = true;
            this.cbVerwijderen.Location = new System.Drawing.Point(157, 48);
            this.cbVerwijderen.Name = "cbVerwijderen";
            this.cbVerwijderen.Size = new System.Drawing.Size(15, 14);
            this.cbVerwijderen.TabIndex = 39;
            this.cbVerwijderen.UseVisualStyleBackColor = true;
            // 
            // btVerwijderen
            // 
            this.btVerwijderen.Location = new System.Drawing.Point(178, 43);
            this.btVerwijderen.Name = "btVerwijderen";
            this.btVerwijderen.Size = new System.Drawing.Size(100, 23);
            this.btVerwijderen.TabIndex = 37;
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
            this.tbVStaffID.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbAanpassen);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbAPassword);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbAAssignedRole);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.tbAStaffID);
            this.panel3.Controls.Add(this.tbAUsername);
            this.panel3.Location = new System.Drawing.Point(12, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 132);
            this.panel3.TabIndex = 39;
            // 
            // cbAanpassen
            // 
            this.cbAanpassen.AutoSize = true;
            this.cbAanpassen.Location = new System.Drawing.Point(157, 104);
            this.cbAanpassen.Name = "cbAanpassen";
            this.cbAanpassen.Size = new System.Drawing.Size(15, 14);
            this.cbAanpassen.TabIndex = 39;
            this.cbAanpassen.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Role: ";
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
            this.tbAPassword.TabIndex = 38;
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
            // tbAAssignedRole
            // 
            this.tbAAssignedRole.Location = new System.Drawing.Point(178, 71);
            this.tbAAssignedRole.Name = "tbAAssignedRole";
            this.tbAAssignedRole.Size = new System.Drawing.Size(100, 23);
            this.tbAAssignedRole.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Aanpassen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbAStaffID
            // 
            this.tbAStaffID.Location = new System.Drawing.Point(63, 13);
            this.tbAStaffID.Name = "tbAStaffID";
            this.tbAStaffID.Size = new System.Drawing.Size(35, 23);
            this.tbAStaffID.TabIndex = 38;
            // 
            // tbAUsername
            // 
            this.tbAUsername.Location = new System.Drawing.Point(178, 13);
            this.tbAUsername.Name = "tbAUsername";
            this.tbAUsername.Size = new System.Drawing.Size(100, 23);
            this.tbAUsername.TabIndex = 38;
            // 
            // btUpdateGrid
            // 
            this.btUpdateGrid.Location = new System.Drawing.Point(190, 436);
            this.btUpdateGrid.Name = "btUpdateGrid";
            this.btUpdateGrid.Size = new System.Drawing.Size(100, 23);
            this.btUpdateGrid.TabIndex = 40;
            this.btUpdateGrid.Text = "Refresh";
            this.btUpdateGrid.UseVisualStyleBackColor = true;
            this.btUpdateGrid.Click += new System.EventHandler(this.btUpdateGrid_Click);
            // 
            // DMStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.btUpdateGrid);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMedewerker);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GimpiesLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DMStaff";
            this.Text = "DMStaff";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedewerker)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvMedewerker;
        private System.Windows.Forms.Button btToevoegen;
        private System.Windows.Forms.TextBox tbTUsername;
        private System.Windows.Forms.TextBox tbTPassword;
        private System.Windows.Forms.TextBox tbTAssignedRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btVerwijderen;
        private System.Windows.Forms.TextBox tbVStaffID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbAPassword;
        private System.Windows.Forms.TextBox tbAAssignedRole;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbAUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAStaffID;
        private System.Windows.Forms.Button btUpdateGrid;
        private System.Windows.Forms.CheckBox cbToevoegen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbVerwijderen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbAanpassen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}