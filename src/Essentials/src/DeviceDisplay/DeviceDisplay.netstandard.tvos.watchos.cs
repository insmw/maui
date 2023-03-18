#nullable enable

namespace Microsoft.Maui.Patched.Devices
{
	partial class DeviceDisplayImplementation
	{
		protected override bool GetKeepScreenOn() => false;

		protected override void SetKeepScreenOn(bool keepScreenOn) { }

		protected override DisplayInfo GetMainDisplayInfo() => default;

		protected override void StartScreenMetricsListeners() { }

		protected override void StopScreenMetricsListeners() { }
	}
}
