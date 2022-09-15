// Decompiled with JetBrains decompiler
// Type: BDOLauncher2.Utils.Login
// Assembly: BDOLauncher2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 21AF9DC0-29C5-457D-8F4A-EB2F126317C9
// Assembly location: D:\Games\BDOCorsair\BDOLauncher2.exe

using BDOLauncher2.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Sockets;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace BDOLauncher2.Utils
{
  public static class Login
  {
    public static string IP = "";

    public static void CheckLogin(Label login)
    {
      Login.GetIP();
      try
      {
        string ip = Login.IP;
        int lsPort = Settings.Default.lsPort;
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        if (socket.BeginConnect(ip, lsPort, (AsyncCallback) null, (object) null).AsyncWaitHandle.WaitOne(100, true))
        {
          login.Text = "Online";
          login.ForeColor = Color.FromArgb(0, (int) byte.MaxValue, 0);
          socket.Close();
        }
        else
        {
          login.Text = "Offline";
          login.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, 0);
          socket.Close();
        }
      }
      catch
      {
      }
    }

    public static void CheckWorld(Label world)
    {
      Login.GetIP();
      try
      {
        string ip = Login.IP;
        int gsPort = Settings.Default.gsPort;
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        if (socket.BeginConnect(ip, gsPort, (AsyncCallback) null, (object) null).AsyncWaitHandle.WaitOne(100, true))
        {
          world.Text = "Online";
          world.ForeColor = Color.FromArgb(0, (int) byte.MaxValue, 0);
          socket.Close();
        }
        else
        {
          world.Text = "Offline";
          world.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, 0);
          socket.Close();
        }
      }
      catch
      {
      }
    }

    public static void CheckWeb(Label web)
    {
      Login.GetIP();
      try
      {
        string ip = Login.IP;
        int wsPort = Settings.Default.wsPort;
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        if (socket.BeginConnect(ip, wsPort, (AsyncCallback) null, (object) null).AsyncWaitHandle.WaitOne(100, true))
        {
          web.Text = "Online";
          web.ForeColor = Color.FromArgb(0, (int) byte.MaxValue, 0);
          socket.Close();
        }
        else
        {
          web.Text = "Offline";
          web.ForeColor = Color.FromArgb((int) byte.MaxValue, 0, 0);
          socket.Close();
        }
      }
      catch
      {
      }
    }

    public static void Start(TextBox login, TextBox password)
    {
      Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location + "\\bin64");
      Process.Start(new ProcessStartInfo()
      {
        WorkingDirectory = "bin64",
        Verb = "runas",
        FileName = "BlackDesert64.exe",
        Arguments = " " + login.Text + "," + password.Text,
        CreateNoWindow = true
      });
      Thread.Sleep(1500);
      Process process = (Process) null;
      while (process == null)
        process = ((IEnumerable<Process>) Process.GetProcessesByName("BlackDesert64")).FirstOrDefault<Process>();
    }

    public static void GetIP()
    {
      if (!string.IsNullOrEmpty(Login.IP))
        return;
      Login.IP = new IniFile("service.ini").Read("AUTHENTIC_DOMAIN", "GT");
    }

    public static void playSimpleSound() => new SoundPlayer("c:\\Windows\\Media\\chimes.wav").Play();
  }
}
