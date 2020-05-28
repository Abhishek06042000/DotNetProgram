namespace Practical9FormsApp
{
    partial class Form1
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
            this.sizeIncrease = new System.Windows.Forms.Button();
            this.sizeDecrease = new System.Windows.Forms.Button();
            this.labelFont = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sizeIncrease
            // 
            this.sizeIncrease.Location = new System.Drawing.Point(73, 133);
            this.sizeIncrease.Name = "sizeIncrease";
            this.sizeIncrease.Size = new System.Drawing.Size(69, 38);
            this.sizeIncrease.TabIndex = 1;
            this.sizeIncrease.Text = "Font Increase";
            this.sizeIncrease.UseVisualStyleBackColor = true;
            this.sizeIncrease.Click += new System.EventHandler(this.sizeIncrease_Click);
            // 
            // sizeDecrease
            // 
            this.sizeDecrease.Location = new System.Drawing.Point(232, 133);
            this.sizeDecrease.Name = "sizeDecrease";
            this.sizeDecrease.Size = new System.Drawing.Size(69, 38);
            this.sizeDecrease.TabIndex = 2;
            this.sizeDecrease.Text = "Font Decrease";
            this.sizeDecrease.UseVisualStyleBackColor = true;
            this.sizeDecrease.Click += new System.EventHandler(this.sizeDecrease_Click);
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(163, 75);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(65, 13);
            this.labelFont.TabIndex = 3;
            this.labelFont.Text = "Hello World!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 316);
            this.Controls.Add(this.labelFont);
            this.Controls.Add(this.sizeDecrease);
            this.Controls.Add(this.sizeIncrease);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sizeIncrease;
        private System.Windows.Forms.Button sizeDecrease;
        private System.Windows.Forms.Label labelFont;
    }
}

