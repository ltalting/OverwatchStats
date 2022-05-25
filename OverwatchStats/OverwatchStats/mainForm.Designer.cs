namespace OverwatchStats
{
    partial class mainForm
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
            this.lblPlatform = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPlatform = new System.Windows.Forms.ComboBox();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(12, 9);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(72, 20);
            this.lblPlatform.TabIndex = 0;
            this.lblPlatform.Text = "Platform:";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(12, 54);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(64, 20);
            this.lblRegion.TabIndex = 1;
            this.lblRegion.Text = "Region:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID/BattleTag:";
            // 
            // cmbPlatform
            // 
            this.cmbPlatform.FormattingEnabled = true;
            this.cmbPlatform.Items.AddRange(new object[] {
            "PlayStation Network",
            "Xbox LIVE",
            "PC"});
            this.cmbPlatform.Location = new System.Drawing.Point(121, 6);
            this.cmbPlatform.Name = "cmbPlatform";
            this.cmbPlatform.Size = new System.Drawing.Size(211, 28);
            this.cmbPlatform.TabIndex = 3;
            // 
            // cmbRegion
            // 
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Items.AddRange(new object[] {
            "United States",
            "Europe",
            "Asia"});
            this.cmbRegion.Location = new System.Drawing.Point(121, 51);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(211, 28);
            this.cmbRegion.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(121, 96);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(211, 26);
            this.txtID.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(121, 142);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(121, 35);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 189);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cmbRegion);
            this.Controls.Add(this.cmbPlatform);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblPlatform);
            this.Name = "mainForm";
            this.Text = "Overwatch Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPlatform;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnGenerate;
    }
}

