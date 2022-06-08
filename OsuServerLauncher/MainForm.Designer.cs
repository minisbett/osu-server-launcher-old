
namespace OsuServerLauncher
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.btnExit = new System.Windows.Forms.Button();
      this.pnlLauncher = new System.Windows.Forms.Panel();
      this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnSettings = new System.Windows.Forms.Button();
      this.btnAddRemoveCredentials = new System.Windows.Forms.Button();
      this.btnAddServer = new System.Windows.Forms.Button();
      this.btnRemoveServer = new System.Windows.Forms.Button();
      this.pnlAbout = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.lblVersion = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.pctrDiscord = new System.Windows.Forms.PictureBox();
      this.label3 = new System.Windows.Forms.Label();
      this.pctrGithub = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnAbout = new System.Windows.Forms.Button();
      this.pnlLauncher.SuspendLayout();
      this.panel1.SuspendLayout();
      this.pnlAbout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pctrDiscord)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pctrGithub)).BeginInit();
      this.SuspendLayout();
      // 
      // btnExit
      // 
      this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnExit.FlatAppearance.BorderSize = 2;
      this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
      this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnExit.ForeColor = System.Drawing.Color.White;
      this.btnExit.Location = new System.Drawing.Point(494, 12);
      this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(35, 35);
      this.btnExit.TabIndex = 0;
      this.btnExit.Text = "X";
      this.btnExit.UseVisualStyleBackColor = false;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // pnlLauncher
      // 
      this.pnlLauncher.Controls.Add(this.flowLayoutPanel);
      this.pnlLauncher.Controls.Add(this.panel1);
      this.pnlLauncher.Location = new System.Drawing.Point(12, 53);
      this.pnlLauncher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.pnlLauncher.Name = "pnlLauncher";
      this.pnlLauncher.Size = new System.Drawing.Size(517, 253);
      this.pnlLauncher.TabIndex = 1;
      this.pnlLauncher.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // flowLayoutPanel
      // 
      this.flowLayoutPanel.AutoScroll = true;
      this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel.Location = new System.Drawing.Point(40, 0);
      this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.flowLayoutPanel.Name = "flowLayoutPanel";
      this.flowLayoutPanel.Size = new System.Drawing.Size(477, 253);
      this.flowLayoutPanel.TabIndex = 9;
      this.flowLayoutPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
      this.panel1.Controls.Add(this.btnAbout);
      this.panel1.Controls.Add(this.btnSettings);
      this.panel1.Controls.Add(this.btnAddRemoveCredentials);
      this.panel1.Controls.Add(this.btnAddServer);
      this.panel1.Controls.Add(this.btnRemoveServer);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(40, 253);
      this.panel1.TabIndex = 10;
      // 
      // btnSettings
      // 
      this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.btnSettings.Enabled = false;
      this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnSettings.FlatAppearance.BorderSize = 2;
      this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
      this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnSettings.ForeColor = System.Drawing.Color.White;
      this.btnSettings.Location = new System.Drawing.Point(4, 218);
      this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.btnSettings.Name = "btnSettings";
      this.btnSettings.Size = new System.Drawing.Size(32, 32);
      this.btnSettings.TabIndex = 9;
      this.btnSettings.Text = "⚙";
      this.btnSettings.UseVisualStyleBackColor = false;
      // 
      // btnAddRemoveCredentials
      // 
      this.btnAddRemoveCredentials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.btnAddRemoveCredentials.Enabled = false;
      this.btnAddRemoveCredentials.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnAddRemoveCredentials.FlatAppearance.BorderSize = 2;
      this.btnAddRemoveCredentials.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnAddRemoveCredentials.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
      this.btnAddRemoveCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddRemoveCredentials.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnAddRemoveCredentials.ForeColor = System.Drawing.Color.White;
      this.btnAddRemoveCredentials.Location = new System.Drawing.Point(4, 81);
      this.btnAddRemoveCredentials.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.btnAddRemoveCredentials.Name = "btnAddRemoveCredentials";
      this.btnAddRemoveCredentials.Size = new System.Drawing.Size(32, 32);
      this.btnAddRemoveCredentials.TabIndex = 8;
      this.btnAddRemoveCredentials.Text = "🔒";
      this.btnAddRemoveCredentials.UseVisualStyleBackColor = false;
      this.btnAddRemoveCredentials.Click += new System.EventHandler(this.btnAddRemoveCredentials_Click);
      // 
      // btnAddServer
      // 
      this.btnAddServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.btnAddServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnAddServer.FlatAppearance.BorderSize = 2;
      this.btnAddServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnAddServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
      this.btnAddServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddServer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnAddServer.ForeColor = System.Drawing.Color.White;
      this.btnAddServer.Location = new System.Drawing.Point(4, 5);
      this.btnAddServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.btnAddServer.Name = "btnAddServer";
      this.btnAddServer.Size = new System.Drawing.Size(32, 32);
      this.btnAddServer.TabIndex = 6;
      this.btnAddServer.Text = "+";
      this.btnAddServer.UseVisualStyleBackColor = false;
      this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
      // 
      // btnRemoveServer
      // 
      this.btnRemoveServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.btnRemoveServer.Enabled = false;
      this.btnRemoveServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnRemoveServer.FlatAppearance.BorderSize = 2;
      this.btnRemoveServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnRemoveServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
      this.btnRemoveServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRemoveServer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnRemoveServer.ForeColor = System.Drawing.Color.White;
      this.btnRemoveServer.Location = new System.Drawing.Point(4, 43);
      this.btnRemoveServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.btnRemoveServer.Name = "btnRemoveServer";
      this.btnRemoveServer.Size = new System.Drawing.Size(32, 32);
      this.btnRemoveServer.TabIndex = 7;
      this.btnRemoveServer.Text = "-";
      this.btnRemoveServer.UseVisualStyleBackColor = false;
      this.btnRemoveServer.Click += new System.EventHandler(this.btnRemoveServer_Click);
      // 
      // pnlAbout
      // 
      this.pnlAbout.Controls.Add(this.label2);
      this.pnlAbout.Controls.Add(this.lblVersion);
      this.pnlAbout.Controls.Add(this.label7);
      this.pnlAbout.Controls.Add(this.label4);
      this.pnlAbout.Controls.Add(this.pctrDiscord);
      this.pnlAbout.Controls.Add(this.label3);
      this.pnlAbout.Controls.Add(this.pctrGithub);
      this.pnlAbout.Location = new System.Drawing.Point(12, 53);
      this.pnlAbout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.pnlAbout.Name = "pnlAbout";
      this.pnlAbout.Size = new System.Drawing.Size(517, 253);
      this.pnlAbout.TabIndex = 2;
      this.pnlAbout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(4, 5);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(509, 46);
      this.label2.TabIndex = 5;
      this.label2.Text = "osu! Server Launcher   ";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // lblVersion
      // 
      this.lblVersion.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblVersion.ForeColor = System.Drawing.Color.White;
      this.lblVersion.Location = new System.Drawing.Point(0, 47);
      this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblVersion.Name = "lblVersion";
      this.lblVersion.Size = new System.Drawing.Size(515, 31);
      this.lblVersion.TabIndex = 8;
      this.lblVersion.Text = "Version 1.0";
      this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.lblVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.ForeColor = System.Drawing.Color.DimGray;
      this.label7.Location = new System.Drawing.Point(3, 148);
      this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(81, 15);
      this.label7.TabIndex = 7;
      this.label7.Text = "feat. big tesco";
      this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.ForeColor = System.Drawing.Color.Gray;
      this.label4.Location = new System.Drawing.Point(3, 166);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(177, 15);
      this.label4.TabIndex = 3;
      this.label4.Text = "Copyright (c) Niklas Fehde, 2021";
      this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // pctrDiscord
      // 
      this.pctrDiscord.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.pctrDiscord.Image = ((System.Drawing.Image)(resources.GetObject("pctrDiscord.Image")));
      this.pctrDiscord.Location = new System.Drawing.Point(356, 137);
      this.pctrDiscord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.pctrDiscord.Name = "pctrDiscord";
      this.pctrDiscord.Size = new System.Drawing.Size(64, 64);
      this.pctrDiscord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pctrDiscord.TabIndex = 2;
      this.pctrDiscord.TabStop = false;
      this.pctrDiscord.Click += new System.EventHandler(this.pctrDiscord_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(3, 184);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(348, 15);
      this.label3.TabIndex = 1;
      this.label3.Text = "osu! Server Launcher is not affiliated in any way with ppy. Pty Ltd";
      this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // pctrGithub
      // 
      this.pctrGithub.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.pctrGithub.Image = ((System.Drawing.Image)(resources.GetObject("pctrGithub.Image")));
      this.pctrGithub.Location = new System.Drawing.Point(425, 137);
      this.pctrGithub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.pctrGithub.Name = "pctrGithub";
      this.pctrGithub.Size = new System.Drawing.Size(64, 64);
      this.pctrGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pctrGithub.TabIndex = 0;
      this.pctrGithub.TabStop = false;
      this.pctrGithub.Click += new System.EventHandler(this.pctrGithub_Click);
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(13, 10);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(492, 35);
      this.label1.TabIndex = 4;
      this.label1.Text = "osu! Server Launcher   ";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // btnAbout
      // 
      this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.btnAbout.Enabled = false;
      this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnAbout.FlatAppearance.BorderSize = 2;
      this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
      this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnAbout.ForeColor = System.Drawing.Color.White;
      this.btnAbout.Location = new System.Drawing.Point(4, 184);
      this.btnAbout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.btnAbout.Name = "btnAbout";
      this.btnAbout.Size = new System.Drawing.Size(32, 32);
      this.btnAbout.TabIndex = 10;
      this.btnAbout.Text = "⚙";
      this.btnAbout.UseVisualStyleBackColor = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
      this.ClientSize = new System.Drawing.Size(542, 317);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pnlLauncher);
      this.Controls.Add(this.pnlAbout);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "osu! Server Launcher";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      this.pnlLauncher.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.pnlAbout.ResumeLayout(false);
      this.pnlAbout.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pctrDiscord)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pctrGithub)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Panel pnlLauncher;
    private System.Windows.Forms.Panel pnlAbout;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pctrGithub;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.PictureBox pctrDiscord;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnAddServer;
    private System.Windows.Forms.Button btnRemoveServer;
    private System.Windows.Forms.Button btnAddRemoveCredentials;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblVersion;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnSettings;
    private System.Windows.Forms.Button btnAbout;
  }
}