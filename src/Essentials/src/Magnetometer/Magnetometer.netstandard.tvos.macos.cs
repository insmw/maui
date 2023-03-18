using Microsoft.Maui.Patched.ApplicationModel;

namespace Microsoft.Maui.Patched.Devices.Sensors
{
	partial class MagnetometerImplementation
	{
		bool PlatformIsSupported =>
			throw ExceptionUtils.NotSupportedOrImplementedException;

		void PlatformStart(SensorSpeed sensorSpeed) =>
			throw ExceptionUtils.NotSupportedOrImplementedException;

		void PlatformStop() =>
			throw ExceptionUtils.NotSupportedOrImplementedException;
	}
}
