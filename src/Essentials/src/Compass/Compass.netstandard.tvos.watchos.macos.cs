using Microsoft.Maui.Patched.ApplicationModel;

namespace Microsoft.Maui.Patched.Devices.Sensors
{
	partial class CompassImplementation : ICompass
	{
		bool PlatformIsSupported => throw ExceptionUtils.NotSupportedOrImplementedException;

		void PlatformStart(SensorSpeed sensorSpeed, bool applyLowPassFilter) =>
			throw ExceptionUtils.NotSupportedOrImplementedException;

		void PlatformStop() =>
			throw ExceptionUtils.NotSupportedOrImplementedException;
	}
}
