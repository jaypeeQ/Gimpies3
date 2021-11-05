
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedewerker)).BeginInit();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Image = global::GimpiesWinForms.Properties.Resources.undo;
            this.btBack.Location = new System.Drawing.Point(467, 12);
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
            this.label9.TabIndex = 33;
            this.label9.Text = "Medewerkers";
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
            this.dgvMedewerker.Location = new System.Drawing.Point(118, 89);
            this.dgvMedewerker.Name = "dgvMedewerker";
            this.dgvMedewerker.ReadOnly = true;
            this.dgvMedewerker.RowTemplate.Height = 25;
            this.dgvMedewerker.Size = new System.Drawing.Size(381, 378);
            this.dgvMedewerker.TabIndex = 36;
            this.dgvMedewerker.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Aanpassen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Toevoegen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btToevoegen_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Verwijderen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DMStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 473);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvMedewerker);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GimpiesLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DMStaff";
            this.Text = "DMStaff";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedewerker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label GimpiesLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvMedewerker;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}