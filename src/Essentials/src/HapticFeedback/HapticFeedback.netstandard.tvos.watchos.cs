using System;
using System.Threading.Tasks;
using Microsoft.Maui.Patched.ApplicationModel;

namespace Microsoft.Maui.Patched.Devices
{
	partial class HapticFeedbackImplementation : IHapticFeedback
	{
		public bool IsSupported
			=> throw ExceptionUtils.NotSupportedOrImplementedException;

		public void Perform(HapticFeedbackType type)
			=> throw ExceptionUtils.NotSupportedOrImplementedException;
	}
}
