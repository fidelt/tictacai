namespace TicTacAI
{
    partial class PlayBoard
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versusHumanMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versusComputerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button00 = new System.Windows.Forms.Button();
            this.button01 = new System.Windows.Forms.Button();
            this.button02 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.aboutMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(405, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // newMenuItem
            // 
            this.newMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versusHumanMenuItem,
            this.versusComputerMenuItem});
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newMenuItem.Text = "&New";
            // 
            // versusHumanMenuItem
            // 
            this.versusHumanMenuItem.Name = "versusHumanMenuItem";
            this.versusHumanMenuItem.Size = new System.Drawing.Size(164, 22);
            this.versusHumanMenuItem.Text = "Versus &Human";
            this.versusHumanMenuItem.Click += new System.EventHandler(this.VersusMenuItems_Click);
            // 
            // versusComputerMenuItem
            // 
            this.versusComputerMenuItem.Name = "versusComputerMenuItem";
            this.versusComputerMenuItem.Size = new System.Drawing.Size(164, 22);
            this.versusComputerMenuItem.Text = "Versus &Computer";
            this.versusComputerMenuItem.Click += new System.EventHandler(this.VersusMenuItems_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutMenuItem.Text = "&About";
            this.aboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // button00
            // 
            this.button00.Enabled = false;
            this.button00.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button00.Location = new System.Drawing.Point(12, 27);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(123, 109);
            this.button00.TabIndex = 1;
            this.button00.UseVisualStyleBackColor = true;
            this.button00.Click += new System.EventHandler(this.PlayBoardButton_Click);
            // 
            // button01
            // 
            this.button01.Enabled = false;
            this.button01.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button01.Location = new System.Drawing.Point(141, 27);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(123, 109);
            this.button01.TabIndex = 2;
            this.button01.UseVisualStyleBackColor = true;
            this.button01.Click += new System.EventHandler(this.PlayBoardButton_Click);
            // 
            // button02
            // 
            this.button02.Enabled = false;
            this.button02.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button02.Location = new System.Drawing.Point(270, 27);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(123, 109);
            this.button02.TabIndex = 3;
            this.button02.UseVisualStyleBackColor = true;
            this.button02.Click += new System.EventHandler(this.PlayBoardButton_Click);
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(12, 142);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(123, 109);
            this.button10.TabIndex = 4;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.PlayBoardButton_Click);
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(141, 142);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(123, 109);
            this.button11.TabIndex = 5;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.PlayBoardButton_Click);
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(270, 142);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(123, 109);
            this.button12.TabIndex = 6;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.PlayBoardButton_Click);
            // 
            // button20
            // 
            this.button20.Enabled = false;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(12, 257);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(123, 109);
            this.button20.TabIndex = 7;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.PlayBoardButton_Click);
            // 
            // button21
            // 
            this.button21.Enabled = false;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(141, 257);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(123, 109);
            this.button21.TabIndex = 8;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.PlayBoardButton_Click);
            // 
            // button22
            // 
            this.button22.Enabled = false;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(270, 257);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(123, 109);
            this.button22.TabIndex = 9;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.PlayBoardButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 369);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(405, 22);
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "StatusStrip";
            // 
            // StatusStripLabel
            // 
            this.StatusStripLabel.Name = "StatusStripLabel";
            this.StatusStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // PlayBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 391);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button02);
            this.Controls.Add(this.button01);
            this.Controls.Add(this.button00);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "PlayBoard";
            this.Text = "TicTacAI";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button button00;
        private System.Windows.Forms.Button button01;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versusHumanMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripLabel;
        private System.Windows.Forms.ToolStripMenuItem versusComputerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
    }
}

