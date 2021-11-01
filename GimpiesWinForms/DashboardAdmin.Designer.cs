
namespace GimpiesWinForms
{
    partial class DashboardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdmin));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btVoorraadBekijken = new System.Windows.Forms.ToolStripButton();
            this.btSchoenenVerkopen = new System.Windows.Forms.ToolStripDropDownButton();
            this.btSchoenenToevoegen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(161, 461);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Image = global::GimpiesWinForms.Properties.Resources.gimpies;
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(158, 64);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // btVoorraadBekijken
            // 
            this.btVoorraadBekijken.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btVoorraadBekijken.Image = ((System.Drawing.Image)(resources.GetObject("btVoorraadBekijken.Image")));
            this.btVoorraadBekijken.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btVoorraadBekijken.Name = "btVoorraadBekijken";
            this.btVoorraadBekijken.Size = new System.Drawing.Size(158, 19);
            this.btVoorraadBekijken.Text = "Voorraad Schoenen Bekijken";
            this.btVoorraadBekijken.Click += new System.EventHandler(this.btVoorraadBekijken_Click);
            // 
            // btSchoenenVerkopen
            // 
            this.btSchoenenVerkopen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btSchoenenVerkopen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSchoenenToevoegen,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.btSchoenenVerkopen.Image = ((System.Drawing.Image)(resources.GetObject("btSchoenenVerkopen.Image")));
            this.btSchoenenVerkopen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSchoenenVerkopen.Name = "btSchoenenVerkopen";
            this.btSchoenenVerkopen.Size = new System.Drawing.Size(158, 19);
            this.btSchoenenVerkopen.Text = "Schoenen Beheer";
            // 
            // btSchoenenToevoegen
            // 
            this.btSchoenenToevoegen.AutoSize = false;
            this.btSchoenenToevoegen.Name = "btSchoenenToevoegen";
            this.btSchoenenToevoegen.Size = new System.Drawing.Size(186, 22);
            this.btSchoenenToevoegen.Text = "Schoenen Toevoegen";
            this.btSchoenenToevoegen.Click += new System.EventHandler(this.btSchoenenToevoegen_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItem2.Text = "Schoenen Aanpassen";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItem3.Text = "Schoenen Verwijderen";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // button3
            // 
            this.button3.Image = global::GimpiesWinForms.Properties.Resources.free_exit_logout_icon_2857_thumb3;
            this.button3.Location = new System.Drawing.Point(672, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 43);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(164, 56);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowTemplate.Height = 25;
            this.dgvUsers.Size = new System.Drawing.Size(546, 393);
            this.dgvUsers.TabIndex = 9;
            // 
            // DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 461);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DashboardAdmin";
            this.Text = "DashboardAdmin";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btVoorraadBekijken;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripDropDownButton btSchoenenVerkopen;
        private System.Windows.Forms.ToolStripMenuItem btSchoenenToevoegen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.DataGridView dgvUsers;
    }
}