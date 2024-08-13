﻿
namespace TicTacToe
{
    partial class frmMain
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.lblCounterDraw = new System.Windows.Forms.Label();
            this.XWinCount = new System.Windows.Forms.Label();
            this.OWinCount = new System.Windows.Forms.Label();
            this.DrawCount = new System.Windows.Forms.Label();
            this.tbxP1 = new System.Windows.Forms.TextBox();
            this.tbxP2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(484, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetScoreToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(99, 32);
            this.fileToolStripMenuItem.Text = "Settings";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(214, 36);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetScoreToolStripMenuItem
            // 
            this.resetScoreToolStripMenuItem.Name = "resetScoreToolStripMenuItem";
            this.resetScoreToolStripMenuItem.Size = new System.Drawing.Size(214, 36);
            this.resetScoreToolStripMenuItem.Text = "Reset Score";
            this.resetScoreToolStripMenuItem.Click += new System.EventHandler(this.resetScoreToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(214, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(69, 32);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(169, 36);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(16, 51);
            this.A1.Margin = new System.Windows.Forms.Padding(4);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(133, 125);
            this.A1.TabIndex = 3;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.btnClick);
            this.A1.MouseEnter += new System.EventHandler(this.btnEnter);
            this.A1.MouseLeave += new System.EventHandler(this.btnLeave);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(172, 51);
            this.A2.Margin = new System.Windows.Forms.Padding(4);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(133, 125);
            this.A2.TabIndex = 4;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.btnClick);
            this.A2.MouseEnter += new System.EventHandler(this.btnEnter);
            this.A2.MouseLeave += new System.EventHandler(this.btnLeave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(329, 51);
            this.A3.Margin = new System.Windows.Forms.Padding(4);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(133, 125);
            this.A3.TabIndex = 5;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.btnClick);
            this.A3.MouseEnter += new System.EventHandler(this.btnEnter);
            this.A3.MouseLeave += new System.EventHandler(this.btnLeave);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(16, 209);
            this.B1.Margin = new System.Windows.Forms.Padding(4);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(133, 125);
            this.B1.TabIndex = 6;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.btnClick);
            this.B1.MouseEnter += new System.EventHandler(this.btnEnter);
            this.B1.MouseLeave += new System.EventHandler(this.btnLeave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(172, 209);
            this.B2.Margin = new System.Windows.Forms.Padding(4);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(133, 125);
            this.B2.TabIndex = 7;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.btnClick);
            this.B2.MouseEnter += new System.EventHandler(this.btnEnter);
            this.B2.MouseLeave += new System.EventHandler(this.btnLeave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(329, 209);
            this.B3.Margin = new System.Windows.Forms.Padding(4);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(133, 125);
            this.B3.TabIndex = 8;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.btnClick);
            this.B3.MouseEnter += new System.EventHandler(this.btnEnter);
            this.B3.MouseLeave += new System.EventHandler(this.btnLeave);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(16, 366);
            this.C1.Margin = new System.Windows.Forms.Padding(4);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(133, 125);
            this.C1.TabIndex = 9;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.btnClick);
            this.C1.MouseEnter += new System.EventHandler(this.btnEnter);
            this.C1.MouseLeave += new System.EventHandler(this.btnLeave);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(172, 366);
            this.C2.Margin = new System.Windows.Forms.Padding(4);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(133, 125);
            this.C2.TabIndex = 10;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.btnClick);
            this.C2.MouseEnter += new System.EventHandler(this.btnEnter);
            this.C2.MouseLeave += new System.EventHandler(this.btnLeave);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(329, 366);
            this.C3.Margin = new System.Windows.Forms.Padding(4);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(133, 125);
            this.C3.TabIndex = 11;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.btnClick);
            this.C3.MouseEnter += new System.EventHandler(this.btnEnter);
            this.C3.MouseLeave += new System.EventHandler(this.btnLeave);
            // 
            // lblCounterDraw
            // 
            this.lblCounterDraw.AutoSize = true;
            this.lblCounterDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounterDraw.Location = new System.Drawing.Point(205, 506);
            this.lblCounterDraw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounterDraw.Name = "lblCounterDraw";
            this.lblCounterDraw.Size = new System.Drawing.Size(69, 26);
            this.lblCounterDraw.TabIndex = 13;
            this.lblCounterDraw.Text = "Draw:";
            // 
            // XWinCount
            // 
            this.XWinCount.AutoSize = true;
            this.XWinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XWinCount.Location = new System.Drawing.Point(68, 540);
            this.XWinCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.XWinCount.Name = "XWinCount";
            this.XWinCount.Size = new System.Drawing.Size(24, 26);
            this.XWinCount.TabIndex = 15;
            this.XWinCount.Text = "0";
            // 
            // OWinCount
            // 
            this.OWinCount.AutoSize = true;
            this.OWinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OWinCount.Location = new System.Drawing.Point(383, 540);
            this.OWinCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OWinCount.Name = "OWinCount";
            this.OWinCount.Size = new System.Drawing.Size(24, 26);
            this.OWinCount.TabIndex = 16;
            this.OWinCount.Text = "0";
            // 
            // DrawCount
            // 
            this.DrawCount.AutoSize = true;
            this.DrawCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawCount.Location = new System.Drawing.Point(225, 540);
            this.DrawCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrawCount.Name = "DrawCount";
            this.DrawCount.Size = new System.Drawing.Size(24, 26);
            this.DrawCount.TabIndex = 17;
            this.DrawCount.Text = "0";
            // 
            // tbxP1
            // 
            this.tbxP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxP1.Location = new System.Drawing.Point(16, 505);
            this.tbxP1.Margin = new System.Windows.Forms.Padding(4);
            this.tbxP1.Name = "tbxP1";
            this.tbxP1.Size = new System.Drawing.Size(132, 32);
            this.tbxP1.TabIndex = 18;
            this.tbxP1.Text = "Player 1";
            this.tbxP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxP1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxP2
            // 
            this.tbxP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxP2.Location = new System.Drawing.Point(329, 505);
            this.tbxP2.Margin = new System.Windows.Forms.Padding(4);
            this.tbxP2.Name = "tbxP2";
            this.tbxP2.Size = new System.Drawing.Size(132, 32);
            this.tbxP2.TabIndex = 19;
            this.tbxP2.Text = "Player 2";
            this.tbxP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxP2.TextChanged += new System.EventHandler(this.tbxP2_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 576);
            this.Controls.Add(this.tbxP2);
            this.Controls.Add(this.tbxP1);
            this.Controls.Add(this.DrawCount);
            this.Controls.Add(this.OWinCount);
            this.Controls.Add(this.XWinCount);
            this.Controls.Add(this.lblCounterDraw);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Tic Tac Toe Game";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label lblCounterDraw;
        private System.Windows.Forms.Label XWinCount;
        private System.Windows.Forms.Label OWinCount;
        private System.Windows.Forms.Label DrawCount;
        private System.Windows.Forms.ToolStripMenuItem resetScoreToolStripMenuItem;
        private System.Windows.Forms.TextBox tbxP1;
        private System.Windows.Forms.TextBox tbxP2;
    }
}

