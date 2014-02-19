namespace TimeConvert
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.unixTimestamp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.regularDateTime = new System.Windows.Forms.TextBox();
            this.nowButton = new System.Windows.Forms.Button();
            this.humanDateString = new System.Windows.Forms.Label();
            this.timeZoneLabel = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unixTimestamp
            // 
            this.unixTimestamp.Location = new System.Drawing.Point(12, 45);
            this.unixTimestamp.Name = "unixTimestamp";
            this.unixTimestamp.Size = new System.Drawing.Size(387, 20);
            this.unixTimestamp.TabIndex = 0;
            this.unixTimestamp.Leave += new System.EventHandler(this.unixTimestamp_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UNIX timestamp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date time (yyyy-MM-dd HH:mm:ss)";
            // 
            // regularDateTime
            // 
            this.regularDateTime.Location = new System.Drawing.Point(12, 84);
            this.regularDateTime.Name = "regularDateTime";
            this.regularDateTime.Size = new System.Drawing.Size(387, 20);
            this.regularDateTime.TabIndex = 3;
            this.regularDateTime.Leave += new System.EventHandler(this.regularDateTime_Leave);
            // 
            // nowButton
            // 
            this.nowButton.Location = new System.Drawing.Point(12, 145);
            this.nowButton.Name = "nowButton";
            this.nowButton.Size = new System.Drawing.Size(75, 23);
            this.nowButton.TabIndex = 4;
            this.nowButton.Text = "Now";
            this.nowButton.UseVisualStyleBackColor = true;
            this.nowButton.Click += new System.EventHandler(this.nowButton_Click);
            // 
            // humanDateString
            // 
            this.humanDateString.AutoSize = true;
            this.humanDateString.Location = new System.Drawing.Point(12, 118);
            this.humanDateString.Name = "humanDateString";
            this.humanDateString.Size = new System.Drawing.Size(0, 13);
            this.humanDateString.TabIndex = 5;
            // 
            // timeZoneLabel
            // 
            this.timeZoneLabel.AutoSize = true;
            this.timeZoneLabel.Location = new System.Drawing.Point(9, 7);
            this.timeZoneLabel.Name = "timeZoneLabel";
            this.timeZoneLabel.Size = new System.Drawing.Size(0, 13);
            this.timeZoneLabel.TabIndex = 7;
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(324, 145);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 23);
            this.aboutButton.TabIndex = 8;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 182);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.timeZoneLabel);
            this.Controls.Add(this.humanDateString);
            this.Controls.Add(this.nowButton);
            this.Controls.Add(this.regularDateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unixTimestamp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Time Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unixTimestamp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox regularDateTime;
        private System.Windows.Forms.Button nowButton;
        private System.Windows.Forms.Label humanDateString;
        private System.Windows.Forms.Label timeZoneLabel;
        private System.Windows.Forms.Button aboutButton;
    }
}

