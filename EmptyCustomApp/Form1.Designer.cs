﻿namespace EmptyCustomApp
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.btnidm = new System.Windows.Forms.Button();
            this.btnAppOpener = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.btnRanPass = new System.Windows.Forms.Button();
            this.btnHashChecker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnidm
            // 
            this.btnidm.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnidm, "btnidm");
            this.btnidm.Name = "btnidm";
            this.btnidm.UseVisualStyleBackColor = false;
            this.btnidm.Click += new System.EventHandler(this.btnidm_Click);
            // 
            // btnAppOpener
            // 
            this.btnAppOpener.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnAppOpener, "btnAppOpener");
            this.btnAppOpener.Name = "btnAppOpener";
            this.btnAppOpener.UseVisualStyleBackColor = false;
            this.btnAppOpener.Click += new System.EventHandler(this.btnAppOpener_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.mainpanel, "mainpanel");
            this.mainpanel.Name = "mainpanel";
            // 
            // btnRanPass
            // 
            this.btnRanPass.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnRanPass, "btnRanPass");
            this.btnRanPass.Name = "btnRanPass";
            this.btnRanPass.UseVisualStyleBackColor = false;
            this.btnRanPass.Click += new System.EventHandler(this.btnRanPass_Click);
            // 
            // btnHashChecker
            // 
            this.btnHashChecker.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnHashChecker, "btnHashChecker");
            this.btnHashChecker.Name = "btnHashChecker";
            this.btnHashChecker.UseVisualStyleBackColor = false;
            this.btnHashChecker.Click += new System.EventHandler(this.btnHashChecker_Click);
            // 
            // MainPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.btnHashChecker);
            this.Controls.Add(this.btnRanPass);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.btnAppOpener);
            this.Controls.Add(this.btnidm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnidm;
        private System.Windows.Forms.Button btnAppOpener;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button btnRanPass;
        private System.Windows.Forms.Button btnHashChecker;
    }
}

