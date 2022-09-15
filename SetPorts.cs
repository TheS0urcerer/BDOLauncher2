// Decompiled with JetBrains decompiler
// Type: BDOLauncher2.SetPorts
// Assembly: BDOLauncher2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 21AF9DC0-29C5-457D-8F4A-EB2F126317C9
// Assembly location: D:\Games\BDOCorsair\BDOLauncher2.exe

using BDOLauncher2.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BDOLauncher2
{
  public class SetPorts : Form
  {
    private IContainer components;
    private Label label1;
    private Label label2;
    private Label label3;
    private NumericUpDown numLogin;
    private NumericUpDown numGame;
    private NumericUpDown numWeb;
    private Button okBtn;
    private Button cancelBtn;

    public SetPorts()
    {
      this.InitializeComponent();
      this.numGame.Value = (Decimal) Settings.Default.gsPort;
      this.numLogin.Value = (Decimal) Settings.Default.lsPort;
      this.numWeb.Value = (Decimal) Settings.Default.wsPort;
    }

    private void okBtn_Click(object sender, EventArgs e)
    {
      Settings.Default.gsPort = (int) this.numGame.Value;
      Settings.Default.lsPort = (int) this.numLogin.Value;
      Settings.Default.wsPort = (int) this.numWeb.Value;
      Settings.Default.Save();
      int num = (int) MessageBox.Show("Ports Saved");
      this.Dispose();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.numLogin = new NumericUpDown();
      this.numGame = new NumericUpDown();
      this.numWeb = new NumericUpDown();
      this.okBtn = new Button();
      this.cancelBtn = new Button();
      this.numLogin.BeginInit();
      this.numGame.BeginInit();
      this.numWeb.BeginInit();
      this.SuspendLayout();
      this.label1.Location = new Point(12, 14);
      this.label1.Name = "label1";
      this.label1.Size = new Size(137, 23);
      this.label1.TabIndex = 0;
      this.label1.Text = "Login Port :";
      this.label1.TextAlign = ContentAlignment.MiddleRight;
      this.label2.Location = new Point(12, 60);
      this.label2.Name = "label2";
      this.label2.Size = new Size(137, 23);
      this.label2.TabIndex = 1;
      this.label2.Text = "Web Shop Port :";
      this.label2.TextAlign = ContentAlignment.MiddleRight;
      this.label3.Location = new Point(12, 37);
      this.label3.Name = "label3";
      this.label3.Size = new Size(137, 23);
      this.label3.TabIndex = 2;
      this.label3.Text = "Game Server Port :";
      this.label3.TextAlign = ContentAlignment.MiddleRight;
      this.numLogin.Location = new Point(156, 14);
      this.numLogin.Maximum = new Decimal(new int[4]
      {
        (int) ushort.MaxValue,
        0,
        0,
        0
      });
      this.numLogin.Name = "numLogin";
      this.numLogin.Size = new Size(75, 22);
      this.numLogin.TabIndex = 3;
      this.numLogin.Value = new Decimal(new int[4]
      {
        8888,
        0,
        0,
        0
      });
      this.numGame.Location = new Point(156, 37);
      this.numGame.Maximum = new Decimal(new int[4]
      {
        (int) ushort.MaxValue,
        0,
        0,
        0
      });
      this.numGame.Name = "numGame";
      this.numGame.Size = new Size(75, 22);
      this.numGame.TabIndex = 4;
      this.numGame.Value = new Decimal(new int[4]
      {
        8889,
        0,
        0,
        0
      });
      this.numWeb.Location = new Point(156, 60);
      this.numWeb.Maximum = new Decimal(new int[4]
      {
        (int) ushort.MaxValue,
        0,
        0,
        0
      });
      this.numWeb.Name = "numWeb";
      this.numWeb.Size = new Size(75, 22);
      this.numWeb.TabIndex = 5;
      this.numWeb.Value = new Decimal(new int[4]
      {
        8089,
        0,
        0,
        0
      });
      this.okBtn.FlatAppearance.BorderColor = Color.Lime;
      this.okBtn.FlatAppearance.BorderSize = 2;
      this.okBtn.FlatAppearance.MouseDownBackColor = Color.Gray;
      this.okBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.okBtn.FlatStyle = FlatStyle.Flat;
      this.okBtn.Location = new Point(156, 107);
      this.okBtn.Name = "okBtn";
      this.okBtn.Size = new Size(75, 31);
      this.okBtn.TabIndex = 6;
      this.okBtn.Text = "OK";
      this.okBtn.UseVisualStyleBackColor = true;
      this.okBtn.Click += new EventHandler(this.okBtn_Click);
      this.cancelBtn.DialogResult = DialogResult.Cancel;
      this.cancelBtn.FlatAppearance.BorderColor = Color.Red;
      this.cancelBtn.FlatAppearance.BorderSize = 2;
      this.cancelBtn.FlatAppearance.MouseDownBackColor = Color.Gray;
      this.cancelBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb((int) byte.MaxValue, 192, 192);
      this.cancelBtn.FlatStyle = FlatStyle.Flat;
      this.cancelBtn.Location = new Point(70, 107);
      this.cancelBtn.Name = "cancelBtn";
      this.cancelBtn.Size = new Size(75, 31);
      this.cancelBtn.TabIndex = 7;
      this.cancelBtn.Text = "Cancel";
      this.cancelBtn.UseVisualStyleBackColor = true;
      this.AcceptButton = (IButtonControl) this.okBtn;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.cancelBtn;
      this.ClientSize = new Size(243, 150);
      this.Controls.Add((Control) this.cancelBtn);
      this.Controls.Add((Control) this.okBtn);
      this.Controls.Add((Control) this.numWeb);
      this.Controls.Add((Control) this.numGame);
      this.Controls.Add((Control) this.numLogin);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (SetPorts);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Set Ports";
      this.numLogin.EndInit();
      this.numGame.EndInit();
      this.numWeb.EndInit();
      this.ResumeLayout(false);
    }
  }
}
