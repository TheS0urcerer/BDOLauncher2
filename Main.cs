// Decompiled with JetBrains decompiler
// Type: BDOLauncher2.Main
// Assembly: BDOLauncher2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 21AF9DC0-29C5-457D-8F4A-EB2F126317C9
// Assembly location: D:\Games\BDOCorsair\BDOLauncher2.exe

using BDOLauncher2.Properties;
using BDOLauncher2.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BDOLauncher2
{
  public class Main : Form
  {
    private IContainer components;
    private Panel panel1;
    private Button visible;
    private Button btnPlay;
    private CheckBox chkSave;
    private TextBox txtPass;
    private TextBox txtName;
    private Label label2;
    private Label label1;
    private GroupBox groupBox1;
    private Label lblWorld;
    private Label lblLogin;
    private Label label4;
    private Label label3;
    private Label lblWeb;
    private Label label6;
    private Button portsBtn;

    public Main() => this.InitializeComponent();

    private void visible_MouseEnter(object sender, EventArgs e)
    {
      this.visible.BackgroundImage = (Image) Resources.invisible;
      this.txtPass.UseSystemPasswordChar = false;
    }

    private void visible_MouseLeave(object sender, EventArgs e)
    {
      this.visible.BackgroundImage = (Image) Resources.visible;
      this.txtPass.UseSystemPasswordChar = true;
    }

    private void btnPlay_Click(object sender, EventArgs e)
    {
      if (this.txtName.Text.Length == 0 || this.txtPass.Text.Length == 0)
        return;
      if (this.chkSave.Checked)
      {
        Settings.Default.userName = this.txtName.Text;
        Settings.Default.password = this.txtPass.Text;
        Settings.Default.remember = this.chkSave.Checked;
        Settings.Default.Save();
      }
      Login.playSimpleSound();
      Login.Start(this.txtName, this.txtPass);
      this.Close();
    }

    private void Main_Load(object sender, EventArgs e)
    {
      this.chkSave.Checked = Settings.Default.remember;
      if (this.chkSave.Checked)
      {
        this.txtName.Text = Settings.Default.userName;
        this.txtPass.Text = Settings.Default.password;
      }
      Login.CheckLogin(this.lblLogin);
      Login.CheckWorld(this.lblWorld);
    }

    private void portsBtn_Click(object sender, EventArgs e)
    {
      int num = (int) new SetPorts().ShowDialog();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Main));
      this.panel1 = new Panel();
      this.groupBox1 = new GroupBox();
      this.lblWeb = new Label();
      this.label6 = new Label();
      this.lblWorld = new Label();
      this.lblLogin = new Label();
      this.label4 = new Label();
      this.label3 = new Label();
      this.visible = new Button();
      this.btnPlay = new Button();
      this.chkSave = new CheckBox();
      this.txtPass = new TextBox();
      this.txtName = new TextBox();
      this.label2 = new Label();
      this.label1 = new Label();
      this.portsBtn = new Button();
      this.panel1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.panel1.BackColor = Color.LightSteelBlue;
      this.panel1.BorderStyle = BorderStyle.Fixed3D;
      this.panel1.Controls.Add((Control) this.groupBox1);
      this.panel1.Controls.Add((Control) this.visible);
      this.panel1.Controls.Add((Control) this.btnPlay);
      this.panel1.Controls.Add((Control) this.chkSave);
      this.panel1.Controls.Add((Control) this.txtPass);
      this.panel1.Controls.Add((Control) this.txtName);
      this.panel1.Controls.Add((Control) this.label2);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Location = new Point(6, 296);
      this.panel1.Margin = new Padding(4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(484, 194);
      this.panel1.TabIndex = 0;
      this.groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.groupBox1.Controls.Add((Control) this.lblWeb);
      this.groupBox1.Controls.Add((Control) this.label6);
      this.groupBox1.Controls.Add((Control) this.lblWorld);
      this.groupBox1.Controls.Add((Control) this.lblLogin);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Location = new Point(8, 132);
      this.groupBox1.Margin = new Padding(4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new Padding(4);
      this.groupBox1.Size = new Size(469, 54);
      this.groupBox1.TabIndex = 7;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Server Status";
      this.lblWeb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lblWeb.AutoSize = true;
      this.lblWeb.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblWeb.ForeColor = Color.FromArgb(0, 0, 192);
      this.lblWeb.Location = new Point(375, 24);
      this.lblWeb.Margin = new Padding(4, 0, 4, 0);
      this.lblWeb.Name = "lblWeb";
      this.lblWeb.Size = new Size(56, 17);
      this.lblWeb.TabIndex = 5;
      this.lblWeb.Text = "Offline";
      this.lblWeb.TextAlign = ContentAlignment.MiddleRight;
      this.label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.label6.AutoSize = true;
      this.label6.Location = new Point(324, 24);
      this.label6.Margin = new Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new Size(39, 16);
      this.label6.TabIndex = 4;
      this.label6.Text = "Web:";
      this.label6.TextAlign = ContentAlignment.MiddleRight;
      this.lblWorld.Anchor = AnchorStyles.Top;
      this.lblWorld.AutoSize = true;
      this.lblWorld.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblWorld.ForeColor = Color.FromArgb(0, 0, 192);
      this.lblWorld.Location = new Point(221, 24);
      this.lblWorld.Margin = new Padding(4, 0, 4, 0);
      this.lblWorld.Name = "lblWorld";
      this.lblWorld.Size = new Size(56, 17);
      this.lblWorld.TabIndex = 3;
      this.lblWorld.Text = "Offline";
      this.lblWorld.TextAlign = ContentAlignment.MiddleRight;
      this.lblLogin.AutoSize = true;
      this.lblLogin.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblLogin.ForeColor = Color.FromArgb(0, 0, 192);
      this.lblLogin.Location = new Point(69, 24);
      this.lblLogin.Margin = new Padding(4, 0, 4, 0);
      this.lblLogin.Name = "lblLogin";
      this.lblLogin.Size = new Size(56, 17);
      this.lblLogin.TabIndex = 2;
      this.lblLogin.Text = "Offline";
      this.lblLogin.TextAlign = ContentAlignment.MiddleRight;
      this.label4.Anchor = AnchorStyles.Top;
      this.label4.AutoSize = true;
      this.label4.Location = new Point(170, 24);
      this.label4.Margin = new Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new Size(46, 16);
      this.label4.TabIndex = 1;
      this.label4.Text = "World:";
      this.label4.TextAlign = ContentAlignment.MiddleRight;
      this.label3.AutoSize = true;
      this.label3.Location = new Point(16, 24);
      this.label3.Margin = new Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new Size(43, 16);
      this.label3.TabIndex = 0;
      this.label3.Text = "Login:";
      this.label3.TextAlign = ContentAlignment.MiddleRight;
      this.visible.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.visible.BackColor = Color.LightSteelBlue;
      this.visible.BackgroundImage = (Image) Resources.visible;
      this.visible.BackgroundImageLayout = ImageLayout.Stretch;
      this.visible.FlatAppearance.BorderColor = Color.LightSteelBlue;
      this.visible.FlatAppearance.BorderSize = 0;
      this.visible.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
      this.visible.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
      this.visible.FlatStyle = FlatStyle.Flat;
      this.visible.Location = new Point(246, 76);
      this.visible.Margin = new Padding(4);
      this.visible.Name = "visible";
      this.visible.Size = new Size(40, 28);
      this.visible.TabIndex = 6;
      this.visible.UseVisualStyleBackColor = false;
      this.visible.MouseEnter += new EventHandler(this.visible_MouseEnter);
      this.visible.MouseLeave += new EventHandler(this.visible_MouseLeave);
      this.btnPlay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnPlay.BackgroundImage = (Image) Resources.play;
      this.btnPlay.BackgroundImageLayout = ImageLayout.Zoom;
      this.btnPlay.FlatAppearance.BorderColor = Color.LightSteelBlue;
      this.btnPlay.FlatAppearance.BorderSize = 0;
      this.btnPlay.FlatAppearance.MouseDownBackColor = Color.Gray;
      this.btnPlay.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
      this.btnPlay.FlatStyle = FlatStyle.Flat;
      this.btnPlay.Location = new Point(294, 29);
      this.btnPlay.Margin = new Padding(4);
      this.btnPlay.Name = "btnPlay";
      this.btnPlay.Size = new Size(178, 75);
      this.btnPlay.TabIndex = 5;
      this.btnPlay.UseVisualStyleBackColor = true;
      this.btnPlay.Click += new EventHandler(this.btnPlay_Click);
      this.chkSave.AutoSize = true;
      this.chkSave.ForeColor = Color.Navy;
      this.chkSave.Location = new Point(44, 110);
      this.chkSave.Margin = new Padding(4);
      this.chkSave.Name = "chkSave";
      this.chkSave.Size = new Size(97, 20);
      this.chkSave.TabIndex = 4;
      this.chkSave.Text = "Remember";
      this.chkSave.UseVisualStyleBackColor = true;
      this.txtPass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.txtPass.Location = new Point(8, 76);
      this.txtPass.Margin = new Padding(4);
      this.txtPass.Name = "txtPass";
      this.txtPass.Size = new Size(232, 22);
      this.txtPass.TabIndex = 3;
      this.txtPass.UseSystemPasswordChar = true;
      this.txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.txtName.Location = new Point(8, 29);
      this.txtName.Margin = new Padding(4);
      this.txtName.Name = "txtName";
      this.txtName.Size = new Size(278, 22);
      this.txtName.TabIndex = 2;
      this.label2.AutoSize = true;
      this.label2.ForeColor = Color.Navy;
      this.label2.Location = new Point(15, 58);
      this.label2.Margin = new Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(67, 16);
      this.label2.TabIndex = 1;
      this.label2.Text = "Password";
      this.label1.AutoSize = true;
      this.label1.ForeColor = Color.Navy;
      this.label1.Location = new Point(15, 10);
      this.label1.Margin = new Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(73, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "UserName";
      this.portsBtn.BackColor = Color.Transparent;
      this.portsBtn.FlatAppearance.BorderColor = Color.CornflowerBlue;
      this.portsBtn.FlatAppearance.BorderSize = 0;
      this.portsBtn.FlatAppearance.MouseDownBackColor = Color.Gray;
      this.portsBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
      this.portsBtn.FlatStyle = FlatStyle.Flat;
      this.portsBtn.Location = new Point(8, 14);
      this.portsBtn.Name = "portsBtn";
      this.portsBtn.Size = new Size(110, 52);
      this.portsBtn.TabIndex = 1;
      this.portsBtn.UseVisualStyleBackColor = false;
      this.portsBtn.Click += new EventHandler(this.portsBtn_Click);
      this.AcceptButton = (IButtonControl) this.btnPlay;
      this.AutoScaleDimensions = new SizeF(120f, 120f);
      this.AutoScaleMode = AutoScaleMode.Dpi;
      this.BackgroundImage = (Image) Resources.BDOCover;
      this.BackgroundImageLayout = ImageLayout.Zoom;
      this.ClientSize = new Size(495, 664);
      this.Controls.Add((Control) this.portsBtn);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Main);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Black Desert Private Launcher";
      this.Load += new EventHandler(this.Main_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
