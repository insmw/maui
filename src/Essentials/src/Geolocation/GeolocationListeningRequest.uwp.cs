#nullable enable

namespace Microsoft.Maui.Patched.Devices.Sensors
{
	public partial class GeolocationListeningRequest
	{
		internal uint PlatformDesiredAccuracy
		{
			get
			{
				return DesiredAccuracy.PlatformGetDesiredAccuracy();
			}
		}
	}
}
