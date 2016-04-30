namespace DiceGame
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.die1 = new System.Windows.Forms.TextBox();
            this.die2 = new System.Windows.Forms.TextBox();
            this.rollEm = new System.Windows.Forms.Button();
            this.specialMessage = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // die1
            // 
            this.die1.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.die1.Location = new System.Drawing.Point(61, 57);
            this.die1.Multiline = true;
            this.die1.Name = "die1";
            this.die1.Size = new System.Drawing.Size(60, 60);
            this.die1.TabIndex = 1;
            // 
            // die2
            // 
            this.die2.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.die2.Location = new System.Drawing.Point(158, 58);
            this.die2.Multiline = true;
            this.die2.Name = "die2";
            this.die2.Size = new System.Drawing.Size(60, 60);
            this.die2.TabIndex = 2;
            // 
            // rollEm
            // 
            this.rollEm.Location = new System.Drawing.Point(77, 190);
            this.rollEm.Margin = new System.Windows.Forms.Padding(2);
            this.rollEm.Name = "rollEm";
            this.rollEm.Size = new System.Drawing.Size(114, 48);
            this.rollEm.TabIndex = 3;
            this.rollEm.Text = "Roll \'Em";
            this.rollEm.UseVisualStyleBackColor = true;
            this.rollEm.Click += new System.EventHandler(this.rollEm_Click);
            // 
            // specialMessage
            // 
            this.specialMessage.AutoSize = true;
            this.specialMessage.Font = new System.Drawing.Font("Sitka Text", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialMessage.ForeColor = System.Drawing.Color.Red;
            this.specialMessage.Location = new System.Drawing.Point(55, 137);
            this.specialMessage.Name = "specialMessage";
            this.specialMessage.Size = new System.Drawing.Size(0, 35);
            this.specialMessage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.specialMessage);
            this.Controls.Add(this.rollEm);
            this.Controls.Add(this.die2);
            this.Controls.Add(this.die1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Roll Dice";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.TextBox die1;
        private System.Windows.Forms.TextBox die2;
        private System.Windows.Forms.Button rollEm;
        private System.Windows.Forms.Label specialMessage;
    }
}

