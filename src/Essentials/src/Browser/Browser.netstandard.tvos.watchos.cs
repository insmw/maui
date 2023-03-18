#nullable enable
using System;
using System.Threading.Tasks;

namespace Microsoft.Maui.Patched.ApplicationModel
{
	partial class BrowserImplementation : IBrowser
	{
		public Task<bool> OpenAsync(Uri uri, BrowserLaunchOptions options) =>
			throw ExceptionUtils.NotSupportedOrImplementedException;
	}
}
