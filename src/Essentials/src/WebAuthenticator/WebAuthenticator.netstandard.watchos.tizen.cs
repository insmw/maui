using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Patched.ApplicationModel;

namespace Microsoft.Maui.Patched.Authentication
{
	partial class WebAuthenticatorImplementation : IWebAuthenticator
	{
		public Task<WebAuthenticatorResult> AuthenticateAsync(WebAuthenticatorOptions webAuthenticatorOptions)
			=> throw ExceptionUtils.NotSupportedOrImplementedException;
	}
}
