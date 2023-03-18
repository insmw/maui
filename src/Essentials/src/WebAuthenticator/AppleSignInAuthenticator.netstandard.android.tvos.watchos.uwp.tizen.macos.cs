using System.Threading.Tasks;
using Microsoft.Maui.Patched.ApplicationModel;

namespace Microsoft.Maui.Patched.Authentication
{
	partial class AppleSignInAuthenticatorImplementation : IAppleSignInAuthenticator
	{
		public Task<WebAuthenticatorResult> AuthenticateAsync(AppleSignInAuthenticator.Options options) =>
			throw ExceptionUtils.NotSupportedOrImplementedException;
	}
}
