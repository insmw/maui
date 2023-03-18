using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Maui.Patched.ApplicationModel;

namespace Microsoft.Maui.Patched.Devices.Sensors
{
	class GeocodingImplementation : IGeocoding
	{
		public Task<IEnumerable<Placemark>> GetPlacemarksAsync(double latitude, double longitude) =>
			throw ExceptionUtils.NotSupportedOrImplementedException;

		public Task<IEnumerable<Location>> GetLocationsAsync(string address) =>
			throw ExceptionUtils.NotSupportedOrImplementedException;
	}
}
