using System;
using Microsoft.Maui.Patched.ApplicationModel;

namespace Microsoft.Maui.Patched.Devices.Sensors
{
	partial class BarometerImplementation : IBarometer
	{
		void PlatformStart(SensorSpeed sensorSpeed)
			=> throw ExceptionUtils.NotSupportedOrImplementedException;

		void PlatformStop()
			=> throw ExceptionUtils.NotSupportedOrImplementedException;

		public bool IsSupported
			=> throw ExceptionUtils.NotSupportedOrImplementedException;
	}
}
