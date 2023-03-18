using System;
using Microsoft.Maui.Patched.ApplicationModel;

namespace Microsoft.Maui.Patched.Devices
{
	partial class VibrationImplementation : IVibration
	{
		public bool IsSupported
			=> throw ExceptionUtils.NotSupportedOrImplementedException;

		void PlatformVibrate()
			=> throw ExceptionUtils.NotSupportedOrImplementedException;

		void PlatformVibrate(TimeSpan duration)
			=> throw ExceptionUtils.NotSupportedOrImplementedException;

		void PlatformCancel()
			=> throw ExceptionUtils.NotSupportedOrImplementedException;
	}
}
