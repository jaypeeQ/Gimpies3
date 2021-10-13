
namespace GimpiesWinForms
{
    partial class VerkoopPopup
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
            this.labelShoeNumber = new System.Windows.Forms.Label();
            this.LabelVerkoopChange = new System.Windows.Forms.Label();
            this.tbVerkoperShoeNum = new System.Windows.Forms.TextBox();
            this.tbVerkoperAantalChange = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbVerkoopDisplay = new System.Windows.Forms.TextBox();
            this.btVerkoopGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelShoeNumber
            // 
            this.labelShoeNumber.AutoSize = true;
            this.labelShoeNumber.Location = new System.Drawing.Point(12, 21);
            this.labelShoeNumber.Name = "labelShoeNumber";
            this.labelShoeNumber.Size = new System.Drawing.Size(83, 15);
            this.labelShoeNumber.TabIndex = 0;
            this.labelShoeNumber.Text = "Shoe Number:";
            // 
            // LabelVerkoopChange
            // 
            this.LabelVerkoopChange.AutoSize = true;
            this.LabelVerkoopChange.Location = new System.Drawing.Point(12, 89);
            this.LabelVerkoopChange.Name = "LabelVerkoopChange";
            this.LabelVerkoopChange.Size = new System.Drawing.Size(96, 15);
            this.LabelVerkoopChange.TabIndex = 0;
            this.LabelVerkoopChange.Text = "Aantal Verkopen:";
            // 
            // tbVerkoperShoeNum
            // 
            this.tbVerkoperShoeNum.Location = new System.Drawing.Point(136, 21);
            this.tbVerkoperShoeNum.Name = "tbVerkoperShoeNum";
            this.tbVerkoperShoeNum.Size = new System.Drawing.Size(31, 23);
            this.tbVerkoperShoeNum.TabIndex = 0;
            // 
            // tbVerkoperAantalChange
            // 
            this.tbVerkoperAantalChange.Location = new System.Drawing.Point(136, 86);
            this.tbVerkoperAantalChange.Name = "tbVerkoperAantalChange";
            this.tbVerkoperAantalChange.Size = new System.Drawing.Size(31, 23);
            this.tbVerkoperAantalChange.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Verkoop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbVerkoopDisplay
            // 
            this.tbVerkoopDisplay.Location = new System.Drawing.Point(198, 21);
            this.tbVerkoopDisplay.Multiline = true;
            this.tbVerkoopDisplay.Name = "tbVerkoopDisplay";
            this.tbVerkoopDisplay.ReadOnly = true;
            this.tbVerkoopDisplay.Size = new System.Drawing.Size(120, 143);
            this.tbVerkoopDisplay.TabIndex = 3;
            this.tbVerkoopDisplay.TabStop = false;
            // 
            // btVerkoopGenerate
            // 
            this.btVerkoopGenerate.Location = new System.Drawing.Point(57, 56);
            this.btVerkoopGenerate.Name = "btVerkoopGenerate";
            this.btVerkoopGenerate.Size = new System.Drawing.Size(75, 23);
            this.btVerkoopGenerate.TabIndex = 1;
            this.btVerkoopGenerate.Text = "Generate";
            this.btVerkoopGenerate.UseVisualStyleBackColor = true;
            this.btVerkoopGenerate.Click += new System.EventHandler(this.btVerkoopGenerate_Click);
            // 
            // VerkoopPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 207);
            this.Controls.Add(this.btVerkoopGenerate);
            this.Controls.Add(this.tbVerkoopDisplay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbVerkoperAantalChange);
            this.Controls.Add(this.tbVerkoperShoeNum);
            this.Controls.Add(this.LabelVerkoopChange);
            this.Controls.Add(this.labelShoeNumber);
            this.Name = "VerkoopPopup";
            this.Text = "VerkoopPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelShoeNumber;
        private System.Windows.Forms.Label LabelVerkoopChange;
        private System.Windows.Forms.TextBox tbVerkoperShoeNum;
        private System.Windows.Forms.TextBox tbVerkoperAantalChange;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvVerkoopPopup;
        private System.Windows.Forms.TextBox tbVerkoopDisplay;
        private System.Windows.Forms.Button btVerkoopGenerate;
    }
}