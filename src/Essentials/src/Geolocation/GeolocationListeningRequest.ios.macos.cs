#nullable enable

namespace Microsoft.Maui.Patched.Devices.Sensors
{
	public partial class GeolocationListeningRequest
	{
		internal double PlatformDesiredAccuracy
		{
			get
			{
				return DesiredAccuracy.PlatformDesiredAccuracy();
			}
		}
	}
}
