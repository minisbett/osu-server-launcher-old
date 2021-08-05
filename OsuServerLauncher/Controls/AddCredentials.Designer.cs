
namespace OsuServerLauncher.Controls
{
  partial class AddCredentials
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
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.btnAddCredentials = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(12, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(169, 35);
      this.label1.TabIndex = 5;
      this.label1.Text = "Add Credentials";
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
      this.btnExit.Location = new System.Drawing.Point(215, 12);
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
      this.label2.Location = new System.Drawing.Point(9, 58);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(67, 17);
      this.label2.TabIndex = 7;
      this.label2.Text = "Username";
      this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // txtUsername
      // 
      this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.txtUsername.ForeColor = System.Drawing.Color.White;
      this.txtUsername.Location = new System.Drawing.Point(82, 56);
      this.txtUsername.MaxLength = 32;
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new System.Drawing.Size(168, 25);
      this.txtUsername.TabIndex = 0;
      this.txtUsername.TextChanged += new System.EventHandler(this.txt_TextChanged);
      this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
      // 
      // txtPassword
      // 
      this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.txtPassword.ForeColor = System.Drawing.Color.White;
      this.txtPassword.Location = new System.Drawing.Point(82, 87);
      this.txtPassword.MaxLength = 64;
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(168, 25);
      this.txtPassword.TabIndex = 1;
      this.txtPassword.UseSystemPasswordChar = true;
      this.txtPassword.TextChanged += new System.EventHandler(this.txt_TextChanged);
      this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label5.Location = new System.Drawing.Point(12, 89);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(64, 17);
      this.label5.TabIndex = 10;
      this.label5.Text = "Password";
      this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      // 
      // btnAddCredentials
      // 
      this.btnAddCredentials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.btnAddCredentials.Enabled = false;
      this.btnAddCredentials.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnAddCredentials.FlatAppearance.BorderSize = 2;
      this.btnAddCredentials.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
      this.btnAddCredentials.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
      this.btnAddCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddCredentials.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.btnAddCredentials.ForeColor = System.Drawing.Color.White;
      this.btnAddCredentials.Location = new System.Drawing.Point(13, 118);
      this.btnAddCredentials.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.btnAddCredentials.Name = "btnAddCredentials";
      this.btnAddCredentials.Size = new System.Drawing.Size(237, 35);
      this.btnAddCredentials.TabIndex = 2;
      this.btnAddCredentials.TabStop = false;
      this.btnAddCredentials.Text = "Add Credentials";
      this.btnAddCredentials.UseVisualStyleBackColor = false;
      this.btnAddCredentials.Click += new System.EventHandler(this.btnAddServer_Click);
      // 
      // AddCredentials
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
      this.ClientSize = new System.Drawing.Size(264, 165);
      this.Controls.Add(this.btnAddCredentials);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtUsername);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.label1);
      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AddCredentials";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDraggable);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnAddCredentials;
  }
}