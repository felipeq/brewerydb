using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models.RootObjects
{
    public class GetBreweriesRootObject
    {
        public int currentPage { get; set; }
        public int numberOfPages { get; set; }
        public int totalResults { get; set; }
        public List<Brewery> data { get; set; }
        public string status { get; set; }
    }
}
