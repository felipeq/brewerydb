namespace DAL
{
    // key should be stored as a secret, i.e. separate settings.json file ignored in .gitignore, 
    // or using cloud secret storing, i.e. Azure
    public class ApiSettings
    {
        const string KEY = "SECRET_HERE";
        const string URL = "http://api.brewerydb.com/v2";

        public string BuildPath(string path, string key = KEY)
        {
            return URL + path + "?key=" + key;
        }
    }
}
