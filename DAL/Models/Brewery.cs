namespace DAL.Models
{
    public class Brewery
    {
        public string id { get; set; }
        public string name { get; set; }
        public string nameShortDisplay { get; set; }
        public string description { get; set; }
        public string website { get; set; }
        public string established { get; set; }
        public string isOrganic { get; set; }
        public Images images { get; set; }
        public string status { get; set; }
        public string statusDisplay { get; set; }
        public string createDate { get; set; }
        public string updateDate { get; set; }
        public string isMassOwned { get; set; }
        public string brandClassification { get; set; }
        public string mailingListUrl { get; set; }
    }
}