namespace EmptyCustomApp
{
    partial class HashChecker
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
            this.lblRan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRan
            // 
            this.lblRan.AutoSize = true;
            this.lblRan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRan.Location = new System.Drawing.Point(274, 9);
            this.lblRan.Name = "lblRan";
            this.lblRan.Size = new System.Drawing.Size(199, 31);
            this.lblRan.TabIndex = 2;
            this.lblRan.Text = "HASH Checker";
            // 
            // HashChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HashChecker";
            this.Text = "HashChecker";
            this.Load += new System.EventHandler(this.HashChecker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRan;
    }
}