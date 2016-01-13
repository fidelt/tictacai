namespace TicTacAI
{
    partial class About
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
            this.author_lbl = new System.Windows.Forms.Label();
            this.abt_author = new System.Windows.Forms.Label();
            this.license_lbl = new System.Windows.Forms.Label();
            this.abt_license = new System.Windows.Forms.Label();
            this.version_lbl = new System.Windows.Forms.Label();
            this.abt_version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // author_lbl
            // 
            this.author_lbl.AutoSize = true;
            this.author_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_lbl.Location = new System.Drawing.Point(32, 68);
            this.author_lbl.Name = "author_lbl";
            this.author_lbl.Size = new System.Drawing.Size(46, 16);
            this.author_lbl.TabIndex = 0;
            this.author_lbl.Text = "Author";
            // 
            // abt_author
            // 
            this.abt_author.AutoSize = true;
            this.abt_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abt_author.Location = new System.Drawing.Point(104, 68);
            this.abt_author.Name = "abt_author";
            this.abt_author.Size = new System.Drawing.Size(71, 16);
            this.abt_author.TabIndex = 1;
            this.abt_author.Text = "abt_author";
            // 
            // license_lbl
            // 
            this.license_lbl.AutoSize = true;
            this.license_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.license_lbl.Location = new System.Drawing.Point(32, 93);
            this.license_lbl.Name = "license_lbl";
            this.license_lbl.Size = new System.Drawing.Size(55, 16);
            this.license_lbl.TabIndex = 3;
            this.license_lbl.Text = "License";
            // 
            // abt_license
            // 
            this.abt_license.AutoSize = true;
            this.abt_license.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abt_license.Location = new System.Drawing.Point(104, 93);
            this.abt_license.Name = "abt_license";
            this.abt_license.Size = new System.Drawing.Size(77, 16);
            this.abt_license.TabIndex = 2;
            this.abt_license.Text = "abt_license";
            // 
            // version_lbl
            // 
            this.version_lbl.AutoSize = true;
            this.version_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version_lbl.Location = new System.Drawing.Point(32, 118);
            this.version_lbl.Name = "version_lbl";
            this.version_lbl.Size = new System.Drawing.Size(54, 16);
            this.version_lbl.TabIndex = 5;
            this.version_lbl.Text = "Version";
            // 
            // abt_version
            // 
            this.abt_version.AutoSize = true;
            this.abt_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abt_version.Location = new System.Drawing.Point(104, 118);
            this.abt_version.Name = "abt_version";
            this.abt_version.Size = new System.Drawing.Size(78, 16);
            this.abt_version.TabIndex = 4;
            this.abt_version.Text = "abt_version";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.version_lbl);
            this.Controls.Add(this.abt_version);
            this.Controls.Add(this.license_lbl);
            this.Controls.Add(this.abt_license);
            this.Controls.Add(this.abt_author);
            this.Controls.Add(this.author_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label author_lbl;
        private System.Windows.Forms.Label abt_author;
        private System.Windows.Forms.Label license_lbl;
        private System.Windows.Forms.Label abt_license;
        private System.Windows.Forms.Label version_lbl;
        private System.Windows.Forms.Label abt_version;
    }
}