using System;
using System.Threading.Tasks;
using CoffeeRadar.Core.Services.ResponseModels;
using CoffeeRadar.Core.Models;

namespace CoffeeRadar.Core.Services
{
	public interface IFoursquareService
	{
		Task<VenuesResponse> GetVenues(string query, GeoCoords coords);
	}
}

