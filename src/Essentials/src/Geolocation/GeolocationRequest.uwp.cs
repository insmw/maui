#nullable enable

namespace Microsoft.Maui.Patched.Devices.Sensors
{
	public partial class GeolocationRequest
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
