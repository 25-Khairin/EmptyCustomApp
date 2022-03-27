namespace EmptyCustomApp
{
    partial class RandomPasswordGenerator
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
            this.ckbSL = new System.Windows.Forms.CheckBox();
            this.ckbBL = new System.Windows.Forms.CheckBox();
            this.ckbNL = new System.Windows.Forms.CheckBox();
            this.tkbValue = new System.Windows.Forms.TrackBar();
            this.lblScrollval = new System.Windows.Forms.Label();
            this.lblScrollMsg = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txbResult = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tkbValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRan
            // 
            this.lblRan.AutoSize = true;
            this.lblRan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRan.Location = new System.Drawing.Point(215, 9);
            this.lblRan.Name = "lblRan";
            this.lblRan.Size = new System.Drawing.Size(356, 31);
            this.lblRan.TabIndex = 1;
            this.lblRan.Text = "Random Password Manager";
            // 
            // ckbSL
            // 
            this.ckbSL.AutoSize = true;
            this.ckbSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSL.Location = new System.Drawing.Point(293, 70);
            this.ckbSL.Name = "ckbSL";
            this.ckbSL.Size = new System.Drawing.Size(158, 21);
            this.ckbSL.TabIndex = 2;
            this.ckbSL.Text = "Include Small Letters";
            this.ckbSL.UseVisualStyleBackColor = true;
            // 
            // ckbBL
            // 
            this.ckbBL.AutoSize = true;
            this.ckbBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBL.Location = new System.Drawing.Point(293, 97);
            this.ckbBL.Name = "ckbBL";
            this.ckbBL.Size = new System.Drawing.Size(144, 21);
            this.ckbBL.TabIndex = 3;
            this.ckbBL.Text = "Include Big Letters";
            this.ckbBL.UseVisualStyleBackColor = true;
            // 
            // ckbNL
            // 
            this.ckbNL.AutoSize = true;
            this.ckbNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNL.Location = new System.Drawing.Point(293, 124);
            this.ckbNL.Name = "ckbNL";
            this.ckbNL.Size = new System.Drawing.Size(136, 21);
            this.ckbNL.TabIndex = 4;
            this.ckbNL.Text = "Include Numerals";
            this.ckbNL.UseVisualStyleBackColor = true;
            // 
            // tkbValue
            // 
            this.tkbValue.Location = new System.Drawing.Point(255, 177);
            this.tkbValue.Maximum = 60;
            this.tkbValue.Minimum = 6;
            this.tkbValue.Name = "tkbValue";
            this.tkbValue.Size = new System.Drawing.Size(215, 45);
            this.tkbValue.TabIndex = 5;
            this.tkbValue.Value = 6;
            this.tkbValue.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblScrollval
            // 
            this.lblScrollval.AutoSize = true;
            this.lblScrollval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScrollval.Location = new System.Drawing.Point(467, 177);
            this.lblScrollval.Name = "lblScrollval";
            this.lblScrollval.Size = new System.Drawing.Size(14, 16);
            this.lblScrollval.TabIndex = 6;
            this.lblScrollval.Text = "0";
            // 
            // lblScrollMsg
            // 
            this.lblScrollMsg.AutoSize = true;
            this.lblScrollMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScrollMsg.Location = new System.Drawing.Point(279, 216);
            this.lblScrollMsg.Name = "lblScrollMsg";
            this.lblScrollMsg.Size = new System.Drawing.Size(191, 17);
            this.lblScrollMsg.TabIndex = 7;
            this.lblScrollMsg.Text = "Password is easily crackable!";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(327, 298);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(87, 26);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(577, 249);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(61, 27);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(293, 150);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Include Special Characters";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txbResult
            // 
            this.txbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResult.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txbResult.Location = new System.Drawing.Point(131, 251);
            this.txbResult.Multiline = false;
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(440, 20);
            this.txbResult.TabIndex = 12;
            this.txbResult.Text = "";
            // 
            // RandomPasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblScrollMsg);
            this.Controls.Add(this.lblScrollval);
            this.Controls.Add(this.tkbValue);
            this.Controls.Add(this.ckbNL);
            this.Controls.Add(this.ckbBL);
            this.Controls.Add(this.ckbSL);
            this.Controls.Add(this.lblRan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RandomPasswordGenerator";
            this.Text = "RandomPasswordGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.tkbValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRan;
        private System.Windows.Forms.CheckBox ckbSL;
        private System.Windows.Forms.CheckBox ckbBL;
        private System.Windows.Forms.CheckBox ckbNL;
        private System.Windows.Forms.TrackBar tkbValue;
        private System.Windows.Forms.Label lblScrollval;
        private System.Windows.Forms.Label lblScrollMsg;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox txbResult;
    }
}