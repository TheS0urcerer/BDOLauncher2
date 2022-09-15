// Decompiled with JetBrains decompiler
// Type: BDOLauncher2.Properties.Settings
// Assembly: BDOLauncher2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 21AF9DC0-29C5-457D-8F4A-EB2F126317C9
// Assembly location: D:\Games\BDOCorsair\BDOLauncher2.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BDOLauncher2.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.0.3.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default => Settings.defaultInstance;

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    public bool remember
    {
      get => (bool) this[nameof (remember)];
      set => this[nameof (remember)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string userName
    {
      get => (string) this[nameof (userName)];
      set => this[nameof (userName)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string password
    {
      get => (string) this[nameof (password)];
      set => this[nameof (password)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("8889")]
    public int gsPort
    {
      get => (int) this[nameof (gsPort)];
      set => this[nameof (gsPort)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("8888")]
    public int lsPort
    {
      get => (int) this[nameof (lsPort)];
      set => this[nameof (lsPort)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("8089")]
    public int wsPort
    {
      get => (int) this[nameof (wsPort)];
      set => this[nameof (wsPort)] = (object) value;
    }
  }
}
