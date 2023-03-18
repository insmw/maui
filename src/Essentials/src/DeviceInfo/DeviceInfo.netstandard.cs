using System;
using Microsoft.Maui.Patched.ApplicationModel;

namespace Microsoft.Maui.Patched.Devices
{
	class DeviceInfoImplementation : IDeviceInfo
	{
		public string Model => throw ExceptionUtils.NotSupportedOrImplementedException;

		public string Manufacturer => throw ExceptionUtils.NotSupportedOrImplementedException;

		public string Name => throw ExceptionUtils.NotSupportedOrImplementedException;

		public string VersionString => throw ExceptionUtils.NotSupportedOrImplementedException;

		public Version Version => throw ExceptionUtils.NotSupportedOrImplementedException;

		public DevicePlatform Platform => DevicePlatform.Unknown;

		public DeviceIdiom Idiom => DeviceIdiom.Unknown;

		public DeviceType DeviceType => DeviceType.Unknown;
	}
}
