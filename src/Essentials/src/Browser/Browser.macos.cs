#nullable enable
using System;
using System.Threading.Tasks;
using AppKit;
using Foundation;

namespace Microsoft.Maui.Patched.ApplicationModel
{
	partial class BrowserImplementation : IBrowser
	{
		static Task<bool> OpenAsync(Uri uri, BrowserLaunchOptions options) =>
			Task.FromResult(NSWorkspace.SharedWorkspace.OpenUrl(new NSUrl(uri.AbsoluteUri)));
	}
}
