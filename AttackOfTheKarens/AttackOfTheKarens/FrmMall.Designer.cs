﻿namespace AttackOfTheKarens {
  partial class FrmMall {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panMall = new System.Windows.Forms.Panel();
            this.tmpSpeed = new System.Windows.Forms.Button();
            this.tmrKarenSpawner = new System.Windows.Forms.Timer(this.components);
            this.tmrUpgrade = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateKarens = new System.Windows.Forms.Timer(this.components);
            this.tmrMoveOwner = new System.Windows.Forms.Timer(this.components);
            this.tmrMoveManager = new System.Windows.Forms.Timer(this.components);
            this.lblMoneySaved = new System.Windows.Forms.Label();
            this.lblMoneySavedLabel = new System.Windows.Forms.Label();
            this.tmrUpdateGame = new System.Windows.Forms.Timer(this.components);
            this.Crack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panMall
            // 
            this.panMall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panMall.BackColor = System.Drawing.Color.Transparent;
            this.panMall.BackgroundImage = global::AttackOfTheKarens.Properties.Resources.mall_bg;
            this.panMall.Location = new System.Drawing.Point(12, 12);
            this.panMall.Name = "panMall";
            this.panMall.Size = new System.Drawing.Size(561, 539);
            this.panMall.TabIndex = 0;
            // 
            // tmpSpeed
            // 
            this.tmpSpeed.AutoSize = true;
            this.tmpSpeed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tmpSpeed.BackColor = System.Drawing.Color.GreenYellow;
            this.tmpSpeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tmpSpeed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tmpSpeed.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tmpSpeed.Location = new System.Drawing.Point(625, 12);
            this.tmpSpeed.Name = "tmpSpeed";
            this.tmpSpeed.Size = new System.Drawing.Size(82, 25);
            this.tmpSpeed.TabIndex = 3;
            this.tmpSpeed.Text = "Speed Boost";
            this.tmpSpeed.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tmpSpeed.UseVisualStyleBackColor = false;
            this.tmpSpeed.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmrKarenSpawner
            // 
            this.tmrKarenSpawner.Tick += new System.EventHandler(this.tmrKarenSpawner_Tick);
            // 
            // tmrUpgrade
            // 
            this.tmrUpgrade.Enabled = true;
            this.tmrUpgrade.Interval = 200;
            this.tmrUpgrade.Tick += new System.EventHandler(this.tmrUpgrade_Tick);
            // 
            // tmrUpdateKarens
            // 
            this.tmrUpdateKarens.Enabled = true;
            this.tmrUpdateKarens.Interval = 40;
            this.tmrUpdateKarens.Tick += new System.EventHandler(this.tmrUpdateKarens_Tick);
            // 
            // tmrMoveOwner
            // 
            this.tmrMoveOwner.Enabled = true;
            this.tmrMoveOwner.Interval = 200;
            this.tmrMoveOwner.Tick += new System.EventHandler(this.tmrMoveOwner_Tick);
            // 
            // tmrMoveManager
            // 
            this.tmrMoveManager.Enabled = true;
            this.tmrMoveManager.Interval = 300;
            this.tmrMoveManager.Tick += new System.EventHandler(this.tmrMoveManager_Tick);
            // 
            // lblMoneySaved
            // 
            this.lblMoneySaved.AutoSize = true;
            this.lblMoneySaved.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMoneySaved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMoneySaved.Location = new System.Drawing.Point(1075, -1);
            this.lblMoneySaved.Name = "lblMoneySaved";
            this.lblMoneySaved.Size = new System.Drawing.Size(98, 32);
            this.lblMoneySaved.TabIndex = 1;
            this.lblMoneySaved.Text = "$ 00.00";
            this.lblMoneySaved.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMoneySavedLabel
            // 
            this.lblMoneySavedLabel.AutoSize = true;
            this.lblMoneySavedLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMoneySavedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMoneySavedLabel.Location = new System.Drawing.Point(917, 6);
            this.lblMoneySavedLabel.Name = "lblMoneySavedLabel";
            this.lblMoneySavedLabel.Size = new System.Drawing.Size(137, 25);
            this.lblMoneySavedLabel.TabIndex = 2;
            this.lblMoneySavedLabel.Text = "Money Saved:";
            this.lblMoneySavedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrUpdateGame
            // 
            this.tmrUpdateGame.Enabled = true;
            this.tmrUpdateGame.Tick += new System.EventHandler(this.tmrUpdateGame_Tick);
            // 
            // Crack
            // 
            this.Crack.BackColor = System.Drawing.Color.GreenYellow;
            this.Crack.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Crack.Location = new System.Drawing.Point(713, 14);
            this.Crack.Name = "Crack";
            this.Crack.Size = new System.Drawing.Size(158, 23);
            this.Crack.TabIndex = 4;
            this.Crack.Text = "Give your managers crack";
            this.Crack.UseVisualStyleBackColor = false;
            this.Crack.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmMall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 698);
            this.Controls.Add(this.Crack);
            this.Controls.Add(this.tmpSpeed);
            this.Controls.Add(this.lblMoneySavedLabel);
            this.Controls.Add(this.lblMoneySaved);
            this.Controls.Add(this.panMall);
            this.Name = "FrmMall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attack of the Karens!!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMall_FormClosed);
            this.Load += new System.EventHandler(this.FrmMall_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMall_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panMall;
    private System.Windows.Forms.Timer tmrKarenSpawner;
    private System.Windows.Forms.Timer tmrUpgrade;

    private System.Windows.Forms.Timer tmrUpdateKarens;
    private System.Windows.Forms.Timer tmrMoveOwner;
    private System.Windows.Forms.Timer tmrMoveManager;
    private System.Windows.Forms.Label lblMoneySaved;
    private System.Windows.Forms.Label lblMoneySavedLabel;
    private System.Windows.Forms.Timer tmrUpdateGame;
    private System.Windows.Forms.Button tmpSpeed;
        private System.Windows.Forms.Button Crack;
    }
}
