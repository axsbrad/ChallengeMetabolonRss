using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetabolonRssChallenge
{
    public class RssFunctions : IRssFunctions
    {
        private readonly IList<RssFeedData> feedData;

        public RssFunctions(IList<RssFeedData> feedData)
        {
            this.feedData = feedData;
        }
        public Dictionary<string, string> CompaniesNoActivityforDays(int days)
        {
            //Channel Date Published is the last time an item was added. (Items would be more difficult)
            return  ((Dictionary<string, string>)(from fd in feedData
                                                .Where(o => o.Channel.DatePublished > DateTime.Now.AddDays(-days)
                                               ).ToList()
                   select new Dictionary<string, string>() {{ fd.Company, fd.URL }}).Distinct().FirstOrDefault());
     
        }
    }
}
