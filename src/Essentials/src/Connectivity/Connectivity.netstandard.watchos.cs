using System.Collections.Generic;
using Microsoft.Maui.Patched.ApplicationModel;

namespace Microsoft.Maui.Patched.Networking
{
	partial class ConnectivityImplementation : IConnectivity
	{
		public NetworkAccess NetworkAccess =>
			throw ExceptionUtils.NotSupportedOrImplementedException;

		public IEnumerable<ConnectionProfile> ConnectionProfiles =>
			throw ExceptionUtils.NotSupportedOrImplementedException;

		void StartListeners() =>
			throw ExceptionUtils.NotSupportedOrImplementedException;

		void StopListeners() =>
			throw ExceptionUtils.NotSupportedOrImplementedException;
	}
}
