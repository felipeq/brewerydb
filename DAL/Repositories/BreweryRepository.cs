using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using DAL.Models;
using DAL.Models.RootObjects;

namespace DAL.Repositories
{
    // _apiSettings could be injected using DI
    public class BreweryRepository : IBreweryRepository
    {
        readonly ApiSettings _apiSettings;
        readonly HttpClient _client;

        public BreweryRepository()
        {
            _apiSettings = new ApiSettings();
            _client = new HttpClient();
        }
        public IEnumerable<Brewery> GetAllBreweries()
        {
            var path = "/breweries";
            var response = _client.GetStreamAsync(_apiSettings.BuildPath(path));
            var serializer = new DataContractJsonSerializer(typeof(GetBreweriesRootObject));
            var breweries = serializer.ReadObject(response.Result) as GetBreweriesRootObject;
            return breweries?.data;
        }
        public Brewery GetBrewery(string id)
        {
            var path = "/brewery/" + id;
            var response = _client.GetStreamAsync(string.Format(_apiSettings.BuildPath(path), id));
            var serializer = new DataContractJsonSerializer(typeof(GetBreweryRootObject));
            var brewery = (serializer.ReadObject(response.Result) as GetBreweryRootObject)?.data;
            return brewery;
        }
    }
}
