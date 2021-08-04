
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
      this.btnAddRemoveCredentials = new System.Windows.Forms.Button();
      this.btnRemoveServer = new System.Windows.Forms.Button();
      this.btnAddServer = new System.Windows.Forms.Button();
      this.btnLauncher = new System.Windows.Forms.Button();
      this.btnAbout = new System.Windows.Forms.Button();
      this.pnlAbout = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.lblVersion = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.pctrDiscord = new System.Windows.Forms.PictureBox();
      this.label3 = new System.Windows.Forms.Label();
      this.pctrGithub = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.pnlLauncher.SuspendLayout();
      this.pnlAbout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
      this.pnlLauncher.Controls.Add(this.btnAddRemoveCredentials);
      this.pnlLauncher.Controls.Add(this.btnRemoveServer);
      this.pnlLauncher.Controls.Add(this.btnAddServer);
      this.pnlLauncher.Location = new System.Drawing.Point(12, 53);
      this.pnlLauncher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.pnlLauncher.Name = "pnlLauncher";
      this.pnlLauncher.Size = new System.Drawing.Size(517, 296);
      this.pnlLauncher.TabIndex = 1;
      this.pnlLauncher.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // flowLayoutPanel
      // 
      this.flowLayoutPanel.AutoScroll = true;
      this.flowLayoutPanel.Location = new System.Drawing.Point(4, 3);
      this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.flowLayoutPanel.Name = "flowLayoutPanel";
      this.flowLayoutPanel.Size = new System.Drawing.Size(510, 252);
      this.flowLayoutPanel.TabIndex = 9;
      this.flowLayoutPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
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
      this.btnAddRemoveCredentials.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnAddRemoveCredentials.ForeColor = System.Drawing.Color.White;
      this.btnAddRemoveCredentials.Location = new System.Drawing.Point(334, 258);
      this.btnAddRemoveCredentials.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.btnAddRemoveCredentials.Name = "btnAddRemoveCredentials";
      this.btnAddRemoveCredentials.Size = new System.Drawing.Size(183, 35);
      this.btnAddRemoveCredentials.TabIndex = 8;
      this.btnAddRemoveCredentials.Text = "Add Credentials";
      this.btnAddRemoveCredentials.UseVisualStyleBackColor = false;
      this.btnAddRemoveCredentials.Click += new System.EventHandler(this.btnAddRemoveCredentials_Click);
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
      this.btnRemoveServer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnRemoveServer.ForeColor = System.Drawing.Color.White;
      this.btnRemoveServer.Location = new System.Drawing.Point(156, 258);
      this.btnRemoveServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.btnRemoveServer.Name = "btnRemoveServer";
      this.btnRemoveServer.Size = new System.Drawing.Size(170, 35);
      this.btnRemoveServer.TabIndex = 7;
      this.btnRemoveServer.Text = "Remove Server";
      this.btnRemoveServer.UseVisualStyleBackColor = false;
      this.btnRemoveServer.Click += new System.EventHandler(this.btnRemoveServer_Click);
      // 
      // btnAddServer
      // 
      this.btnAddServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.btnAddServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnAddServer.FlatAppearance.BorderSize = 2;
      this.btnAddServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnAddServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
      this.btnAddServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddServer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnAddServer.ForeColor = System.Drawing.Color.White;
      this.btnAddServer.Location = new System.Drawing.Point(4, 258);
      this.btnAddServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.btnAddServer.Name = "btnAddServer";
      this.btnAddServer.Size = new System.Drawing.Size(144, 35);
      this.btnAddServer.TabIndex = 6;
      this.btnAddServer.Text = "Add Server";
      this.btnAddServer.UseVisualStyleBackColor = false;
      this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
      // 
      // btnLauncher
      // 
      this.btnLauncher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
      this.btnLauncher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnLauncher.FlatAppearance.BorderSize = 0;
      this.btnLauncher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
      this.btnLauncher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
      this.btnLauncher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLauncher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnLauncher.ForeColor = System.Drawing.Color.White;
      this.btnLauncher.Location = new System.Drawing.Point(12, 12);
      this.btnLauncher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.btnLauncher.Name = "btnLauncher";
      this.btnLauncher.Size = new System.Drawing.Size(115, 35);
      this.btnLauncher.TabIndex = 2;
      this.btnLauncher.Text = "Launcher";
      this.btnLauncher.UseVisualStyleBackColor = false;
      this.btnLauncher.Click += new System.EventHandler(this.btnLauncher_Click);
      // 
      // btnAbout
      // 
      this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnAbout.FlatAppearance.BorderSize = 2;
      this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
      this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnAbout.ForeColor = System.Drawing.Color.White;
      this.btnAbout.Location = new System.Drawing.Point(404, 12);
      this.btnAbout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.btnAbout.Name = "btnAbout";
      this.btnAbout.Size = new System.Drawing.Size(82, 35);
      this.btnAbout.TabIndex = 3;
      this.btnAbout.Text = "About";
      this.btnAbout.UseVisualStyleBackColor = false;
      this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
      // 
      // pnlAbout
      // 
      this.pnlAbout.Controls.Add(this.label2);
      this.pnlAbout.Controls.Add(this.lblVersion);
      this.pnlAbout.Controls.Add(this.label6);
      this.pnlAbout.Controls.Add(this.label7);
      this.pnlAbout.Controls.Add(this.pictureBox1);
      this.pnlAbout.Controls.Add(this.label5);
      this.pnlAbout.Controls.Add(this.label4);
      this.pnlAbout.Controls.Add(this.pctrDiscord);
      this.pnlAbout.Controls.Add(this.label3);
      this.pnlAbout.Controls.Add(this.pctrGithub);
      this.pnlAbout.Location = new System.Drawing.Point(12, 53);
      this.pnlAbout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.pnlAbout.Name = "pnlAbout";
      this.pnlAbout.Size = new System.Drawing.Size(493, 296);
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
      this.label2.Size = new System.Drawing.Size(485, 46);
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
      this.lblVersion.Size = new System.Drawing.Size(492, 31);
      this.lblVersion.TabIndex = 8;
      this.lblVersion.Text = "Version 1.0";
      this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.lblVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label6.ForeColor = System.Drawing.Color.White;
      this.label6.Location = new System.Drawing.Point(4, 67);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(486, 119);
      this.label6.TabIndex = 6;
      this.label6.Text = resources.GetString("label6.Text");
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.ForeColor = System.Drawing.Color.DimGray;
      this.label7.Location = new System.Drawing.Point(4, 240);
      this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(81, 15);
      this.label7.TabIndex = 7;
      this.label7.Text = "feat. big tesco";
      this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(4, 10);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(486, 72);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 5;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
      this.label5.ForeColor = System.Drawing.Color.White;
      this.label5.Location = new System.Drawing.Point(4, 190);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(486, 20);
      this.label5.TabIndex = 4;
      this.label5.Text = "Join our Discord Server if you found a bug or you have a suggestion!";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.ForeColor = System.Drawing.Color.Gray;
      this.label4.Location = new System.Drawing.Point(4, 258);
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
      this.pctrDiscord.Location = new System.Drawing.Point(357, 229);
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
      this.label3.Location = new System.Drawing.Point(4, 276);
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
      this.pctrGithub.Location = new System.Drawing.Point(426, 229);
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
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
      this.ClientSize = new System.Drawing.Size(542, 361);
      this.Controls.Add(this.btnAbout);
      this.Controls.Add(this.btnLauncher);
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
      this.pnlAbout.ResumeLayout(false);
      this.pnlAbout.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pctrDiscord)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pctrGithub)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Panel pnlLauncher;
    private System.Windows.Forms.Button btnLauncher;
    private System.Windows.Forms.Button btnAbout;
    private System.Windows.Forms.Panel pnlAbout;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pctrGithub;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.PictureBox pctrDiscord;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnAddServer;
    private System.Windows.Forms.Button btnRemoveServer;
    private System.Windows.Forms.Button btnAddRemoveCredentials;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblVersion;
  }
}