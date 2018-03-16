namespace DAL.Models.RootObjects
{
    public class GetBeerRootObject
    {
        public string status { get; set; }
        public Beer data { get; set; }
        public string message { get; set; }
    }
}

