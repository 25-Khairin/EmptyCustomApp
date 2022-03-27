namespace EmptyCustomApp
{
    partial class AppOpener
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
            this.lblAppOpener = new System.Windows.Forms.Label();
            this.btnApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAppOpener
            // 
            this.lblAppOpener.AutoSize = true;
            this.lblAppOpener.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppOpener.Location = new System.Drawing.Point(320, 10);
            this.lblAppOpener.Name = "lblAppOpener";
            this.lblAppOpener.Size = new System.Drawing.Size(152, 31);
            this.lblAppOpener.TabIndex = 0;
            this.lblAppOpener.Text = "AppOpener";
            // 
            // btnApp
            // 
            this.btnApp.Location = new System.Drawing.Point(38, 93);
            this.btnApp.Name = "btnApp";
            this.btnApp.Size = new System.Drawing.Size(75, 23);
            this.btnApp.TabIndex = 1;
            this.btnApp.Text = "button1";
            this.btnApp.UseVisualStyleBackColor = true;
            this.btnApp.Click += new System.EventHandler(this.btnApp_Click);
            // 
            // AppOpener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApp);
            this.Controls.Add(this.lblAppOpener);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppOpener";
            this.Text = "AppOpener";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppOpener;
        private System.Windows.Forms.Button btnApp;
    }
}