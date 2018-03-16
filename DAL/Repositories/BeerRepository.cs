using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using DAL.Models;
using DAL.Models.RootObjects;

namespace DAL.Repositories
{
    // _apiSettings could be injected using DI
    public class BeerRepository : IBeerRepository
    {
        readonly ApiSettings _apiSettings;
        readonly HttpClient _client;

        public BeerRepository()
        {
            _apiSettings = new ApiSettings();
            _client = new HttpClient();
        }
        public IEnumerable<Beer> GetAllBeers()
        {
            var path = "/beers";
            var response = _client.GetStreamAsync(_apiSettings.BuildPath(path));
            var serializer = new DataContractJsonSerializer(typeof(GetBeersRootObject));
            var beers = serializer.ReadObject(response.Result) as GetBeersRootObject;
            return beers?.data;
        }
        public Beer GetBeer(string id)
        {
            var path = "/beer/" + id;
            var response = _client.GetStreamAsync(_apiSettings.BuildPath(path));
            var serializer = new DataContractJsonSerializer(typeof(GetBeerRootObject));
            var beer = (serializer.ReadObject(response.Result) as GetBeerRootObject)?.data;
            return beer;
        }
    }
}
