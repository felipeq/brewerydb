using System.Runtime.Serialization;

namespace DAL.Models
{
    [DataContract(Name = "repo")]
    public class Repository
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}