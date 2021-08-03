
namespace OsuServerLauncher.Controls
{
  partial class ServerItem
  {
    /// <summary> 
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Komponenten-Designer generierter Code

    /// <summary> 
    /// Erforderliche Methode für die Designerunterstützung. 
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerItem));
      this.lblName = new System.Windows.Forms.Label();
      this.pictureIcon = new System.Windows.Forms.PictureBox();
      this.pictureLock = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureLock)).BeginInit();
      this.SuspendLayout();
      // 
      // lblName
      // 
      this.lblName.ForeColor = System.Drawing.Color.White;
      this.lblName.Location = new System.Drawing.Point(3, 75);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(93, 23);
      this.lblName.TabIndex = 0;
      this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pictureIcon
      // 
      this.pictureIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.pictureIcon.Location = new System.Drawing.Point(16, 7);
      this.pictureIcon.Name = "pictureIcon";
      this.pictureIcon.Size = new System.Drawing.Size(64, 64);
      this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureIcon.TabIndex = 1;
      this.pictureIcon.TabStop = false;
      // 
      // pictureLock
      // 
      this.pictureLock.BackColor = System.Drawing.Color.Transparent;
      this.pictureLock.Image = ((System.Drawing.Image)(resources.GetObject("pictureLock.Image")));
      this.pictureLock.Location = new System.Drawing.Point(40, 34);
      this.pictureLock.Name = "pictureLock";
      this.pictureLock.Size = new System.Drawing.Size(24, 32);
      this.pictureLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureLock.TabIndex = 2;
      this.pictureLock.TabStop = false;
      // 
      // ServerItem
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
      this.Controls.Add(this.pictureLock);
      this.Controls.Add(this.pictureIcon);
      this.Controls.Add(this.lblName);
      this.Name = "ServerItem";
      this.Size = new System.Drawing.Size(96, 96);
      ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureLock)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.PictureBox pictureIcon;
    private System.Windows.Forms.PictureBox pictureLock;
  }
}
