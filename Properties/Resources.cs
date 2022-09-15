// Decompiled with JetBrains decompiler
// Type: BDOLauncher2.Properties.Resources
// Assembly: BDOLauncher2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 21AF9DC0-29C5-457D-8F4A-EB2F126317C9
// Assembly location: D:\Games\BDOCorsair\BDOLauncher2.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace BDOLauncher2.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (BDOLauncher2.Properties.Resources.resourceMan == null)
          BDOLauncher2.Properties.Resources.resourceMan = new ResourceManager("BDOLauncher2.Properties.Resources", typeof (BDOLauncher2.Properties.Resources).Assembly);
        return BDOLauncher2.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => BDOLauncher2.Properties.Resources.resourceCulture;
      set => BDOLauncher2.Properties.Resources.resourceCulture = value;
    }

    internal static Bitmap BDOCover => (Bitmap) BDOLauncher2.Properties.Resources.ResourceManager.GetObject(nameof (BDOCover), BDOLauncher2.Properties.Resources.resourceCulture);

    internal static Icon bdoPrivate => (Icon) BDOLauncher2.Properties.Resources.ResourceManager.GetObject(nameof (bdoPrivate), BDOLauncher2.Properties.Resources.resourceCulture);

    internal static Bitmap invisible => (Bitmap) BDOLauncher2.Properties.Resources.ResourceManager.GetObject(nameof (invisible), BDOLauncher2.Properties.Resources.resourceCulture);

    internal static Bitmap play => (Bitmap) BDOLauncher2.Properties.Resources.ResourceManager.GetObject(nameof (play), BDOLauncher2.Properties.Resources.resourceCulture);

    internal static Bitmap visible => (Bitmap) BDOLauncher2.Properties.Resources.ResourceManager.GetObject(nameof (visible), BDOLauncher2.Properties.Resources.resourceCulture);
  }
}
