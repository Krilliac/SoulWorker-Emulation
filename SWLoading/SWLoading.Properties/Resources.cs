using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace SWLoading.Properties
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
	internal class Resources
	{
		private static ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("SWLoading.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		internal static Bitmap S_5241811538836
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("S_5241811538836", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap sp_image
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("sp_image", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap splash3
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("splash3", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap SW_Splash_China
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("SW_Splash_China", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap SW_Splash_Taiwan
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("SW_Splash_Taiwan", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal Resources()
		{
		}
	}
}
