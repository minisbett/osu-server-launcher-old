
namespace OsuServerLauncher.Controls
{
  partial class AddServer
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
      this.label1 = new System.Windows.Forms.Label();
      this.btnExit = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.txtDomain = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.btnAddServer = new System.Windows.Forms.Button();
      this.pictureBox = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(12, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(119, 35);
      this.label1.TabIndex = 5;
      this.label1.Text = "Add Server";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
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
      this.btnExit.Location = new System.Drawing.Point(331, 12);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(35, 35);
      this.btnExit.TabIndex = 6;
      this.btnExit.TabStop = false;
      this.btnExit.Text = "X";
      this.btnExit.UseVisualStyleBackColor = false;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(23, 58);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(84, 17);
      this.label2.TabIndex = 7;
      this.label2.Text = "Server Name";
      this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // txtName
      // 
      this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.txtName.ForeColor = System.Drawing.Color.White;
      this.txtName.Location = new System.Drawing.Point(112, 56);
      this.txtName.MaxLength = 32;
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(139, 25);
      this.txtName.TabIndex = 0;
      this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
      // 
      // txtDomain
      // 
      this.txtDomain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.txtDomain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtDomain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.txtDomain.ForeColor = System.Drawing.Color.White;
      this.txtDomain.Location = new System.Drawing.Point(112, 87);
      this.txtDomain.MaxLength = 64;
      this.txtDomain.Name = "txtDomain";
      this.txtDomain.Size = new System.Drawing.Size(139, 25);
      this.txtDomain.TabIndex = 1;
      this.txtDomain.TextChanged += new System.EventHandler(this.txtDomain_TextChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label5.Location = new System.Drawing.Point(12, 89);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(94, 17);
      this.label5.TabIndex = 10;
      this.label5.Text = "Server Domain";
      this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label3.Location = new System.Drawing.Point(259, 89);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(107, 17);
      this.label3.TabIndex = 13;
      this.label3.Text = "e.g. \"ez-pp.farm\"";
      this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label4.Location = new System.Drawing.Point(266, 58);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(100, 17);
      this.label4.TabIndex = 12;
      this.label4.Text = "e.g. \"EZPPFarm\"";
      this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // btnAddServer
      // 
      this.btnAddServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.btnAddServer.Enabled = false;
      this.btnAddServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnAddServer.FlatAppearance.BorderSize = 2;
      this.btnAddServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnAddServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
      this.btnAddServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddServer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnAddServer.ForeColor = System.Drawing.Color.White;
      this.btnAddServer.Location = new System.Drawing.Point(13, 118);
      this.btnAddServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.btnAddServer.Name = "btnAddServer";
      this.btnAddServer.Size = new System.Drawing.Size(352, 35);
      this.btnAddServer.TabIndex = 2;
      this.btnAddServer.TabStop = false;
      this.btnAddServer.Text = "Add Server";
      this.btnAddServer.UseVisualStyleBackColor = false;
      this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
      // 
      // pictureBox
      // 
      this.pictureBox.Location = new System.Drawing.Point(137, 14);
      this.pictureBox.Name = "pictureBox";
      this.pictureBox.Size = new System.Drawing.Size(32, 32);
      this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox.TabIndex = 15;
      this.pictureBox.TabStop = false;
      this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // AddServer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
      this.ClientSize = new System.Drawing.Size(378, 164);
      this.Controls.Add(this.pictureBox);
      this.Controls.Add(this.btnAddServer);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtDomain);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.label1);
      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AddServer";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtDomain;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnAddServer;
    private System.Windows.Forms.PictureBox pictureBox;
  }
}