using System.Threading.Tasks;
using Microsoft.Maui.Patched.ApplicationModel;

namespace Microsoft.Maui.Patched.Devices
{
	class FlashlightImplementation : IFlashlight
	{
		public Task TurnOnAsync() =>
			throw ExceptionUtils.NotSupportedOrImplementedException;

		public Task TurnOffAsync() =>
			throw ExceptionUtils.NotSupportedOrImplementedException;
	}
}
