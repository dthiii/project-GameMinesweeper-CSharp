namespace project_GameMinesweeper_CSharp
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlInfor = new System.Windows.Forms.Panel();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbFlag = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtFlag = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInfor.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Location = new System.Drawing.Point(0, 75);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(308, 259);
            this.pnlBody.TabIndex = 13;
            // 
            // pnlInfor
            // 
            this.pnlInfor.Controls.Add(this.lbScore);
            this.pnlInfor.Controls.Add(this.lbFlag);
            this.pnlInfor.Controls.Add(this.txtScore);
            this.pnlInfor.Controls.Add(this.txtFlag);
            this.pnlInfor.Location = new System.Drawing.Point(0, 28);
            this.pnlInfor.Name = "pnlInfor";
            this.pnlInfor.Padding = new System.Windows.Forms.Padding(4);
            this.pnlInfor.Size = new System.Drawing.Size(308, 46);
            this.pnlInfor.TabIndex = 14;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(155, 20);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(72, 22);
            this.lbScore.TabIndex = 7;
            this.lbScore.Text = "Score:";
            // 
            // lbFlag
            // 
            this.lbFlag.AutoSize = true;
            this.lbFlag.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlag.Location = new System.Drawing.Point(11, 20);
            this.lbFlag.Name = "lbFlag";
            this.lbFlag.Size = new System.Drawing.Size(59, 22);
            this.lbFlag.TabIndex = 6;
            this.lbFlag.Text = "Flag:";
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.Red;
            this.txtScore.Location = new System.Drawing.Point(233, 7);
            this.txtScore.Multiline = true;
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(64, 34);
            this.txtScore.TabIndex = 11;
            this.txtScore.TabStop = false;
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFlag
            // 
            this.txtFlag.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlag.ForeColor = System.Drawing.Color.Red;
            this.txtFlag.Location = new System.Drawing.Point(72, 7);
            this.txtFlag.Multiline = true;
            this.txtFlag.Name = "txtFlag";
            this.txtFlag.Size = new System.Drawing.Size(60, 34);
            this.txtFlag.TabIndex = 9;
            this.txtFlag.TabStop = false;
            this.txtFlag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(309, 28);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "menuStrip1";
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.levelToolStripMenuItem.Text = "Level";
            this.levelToolStripMenuItem.Click += new System.EventHandler(this.levelToolStripMenuItem_Click);
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.easyToolStripMenuItem.Text = "Easy";
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.mediumToolStripMenuItem.Text = "Medium";
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.hardToolStripMenuItem.Text = "Hard";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 346);
            this.Controls.Add(this.pnlInfor);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Minesweeper";
            this.pnlInfor.ResumeLayout(false);
            this.pnlInfor.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlInfor;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtFlag;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbFlag;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

