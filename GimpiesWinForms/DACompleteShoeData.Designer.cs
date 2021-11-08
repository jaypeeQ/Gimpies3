
namespace GimpiesWinForms
{
    partial class DACompleteShoeData
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
            this.dgvShoeData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoeData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShoeData
            // 
            this.dgvShoeData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShoeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShoeData.Location = new System.Drawing.Point(12, 12);
            this.dgvShoeData.Name = "dgvShoeData";
            this.dgvShoeData.ReadOnly = true;
            this.dgvShoeData.RowTemplate.Height = 25;
            this.dgvShoeData.Size = new System.Drawing.Size(776, 426);
            this.dgvShoeData.TabIndex = 0;
            // 
            // DACompleteShoeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvShoeData);
            this.Name = "DACompleteShoeData";
            this.Text = "DACompleteShoeData";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoeData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShoeData;
    }
}