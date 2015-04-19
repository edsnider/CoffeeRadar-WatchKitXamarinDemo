using System.Threading.Tasks;
using CoffeeRadar.Core.Models;

namespace CoffeeRadar.Core.Services
{
	public interface ILocationService
	{
		Task<GeoCoords> GetGeoCoordinatesAsync();
	}
}

