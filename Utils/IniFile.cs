// Decompiled with JetBrains decompiler
// Type: BDOLauncher2.Utils.IniFile
// Assembly: BDOLauncher2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 21AF9DC0-29C5-457D-8F4A-EB2F126317C9
// Assembly location: D:\Games\BDOCorsair\BDOLauncher2.exe

using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace BDOLauncher2.Utils
{
  public class IniFile
  {
    private readonly string Path;
    private readonly string EXE = Assembly.GetExecutingAssembly().GetName().Name;

    [DllImport("kernel32", CharSet = CharSet.Unicode)]
    private static extern long WritePrivateProfileString(
      string Section,
      string Key,
      string Value,
      string FilePath);

    [DllImport("kernel32", CharSet = CharSet.Unicode)]
    private static extern int GetPrivateProfileString(
      string Section,
      string Key,
      string Default,
      StringBuilder RetVal,
      int Size,
      string FilePath);

    public IniFile(string IniPath = null) => this.Path = new FileInfo(IniPath ?? this.EXE + "service.ini").FullName;

    public string Read(string Key, string Section = null)
    {
      StringBuilder RetVal = new StringBuilder((int) byte.MaxValue);
      IniFile.GetPrivateProfileString(Section ?? this.EXE, Key, "", RetVal, (int) byte.MaxValue, this.Path);
      return RetVal.ToString();
    }

    public void Write(string Key, string Value, string Section = null) => IniFile.WritePrivateProfileString(Section ?? this.EXE, Key, Value, this.Path);

    public void DeleteKey(string Key, string Section = null) => this.Write(Key, (string) null, Section ?? this.EXE);

    public void DeleteSection(string Section = null) => this.Write((string) null, (string) null, Section ?? this.EXE);

    public bool KeyExists(string Key, string Section = null) => this.Read(Key, Section).Length > 0;
  }
}
