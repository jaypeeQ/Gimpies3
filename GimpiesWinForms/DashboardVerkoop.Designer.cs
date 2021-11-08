
namespace GimpiesWinForms
{
    partial class DashboardVerkoop
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
            this.button3 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btVoorraadBekijken = new System.Windows.Forms.ToolStripButton();
            this.btSchoenenVerkopen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Image = global::GimpiesWinForms.Properties.Resources.free_exit_logout_icon_2857_thumb3;
            this.button3.Location = new System.Drawing.Point(673, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 43);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.btVoorraadBekijken,
            this.btSchoenenVerkopen,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(177, 465);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Image = global::GimpiesWinForms.Properties.Resources.gimpies;
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(174, 64);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // btVoorraadBekijken
            // 
            this.btVoorraadBekijken.Image = global::GimpiesWinForms.Properties.Resources.Untitled;
            this.btVoorraadBekijken.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btVoorraadBekijken.Name = "btVoorraadBekijken";
            this.btVoorraadBekijken.Size = new System.Drawing.Size(174, 20);
            this.btVoorraadBekijken.Text = "Voorraad Schoenen Bekijken";
            this.btVoorraadBekijken.Click += new System.EventHandler(this.btVoorraadBekijken_Click);
            // 
            // btSchoenenVerkopen
            // 
            this.btSchoenenVerkopen.Image = global::GimpiesWinForms.Properties.Resources.money_icon_png_18;
            this.btSchoenenVerkopen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSchoenenVerkopen.Name = "btSchoenenVerkopen";
            this.btSchoenenVerkopen.Size = new System.Drawing.Size(174, 20);
            this.btSchoenenVerkopen.Text = "Schoenen Verkopen";
            this.btSchoenenVerkopen.Click += new System.EventHandler(this.btSchoenenVerkopen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(174, 6);
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(180, 60);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.RowTemplate.Height = 25;
            this.dgvAdmin.Size = new System.Drawing.Size(531, 393);
            this.dgvAdmin.TabIndex = 10;
            // 
            // DashboardVerkoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 465);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DashboardVerkoop";
            this.Text = "DashboardVerkoop";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btVoorraadBekijken;
        private System.Windows.Forms.ToolStripButton btSchoenenVerkopen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dgvAdmin;
    }
}