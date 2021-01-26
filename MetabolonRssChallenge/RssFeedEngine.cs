using System;
using System.Collections.Generic;
using System.Text;

namespace MetabolonRssChallenge
{
    public class RssFeedEngine
    {
        private readonly IList<Feed> feeds;
        private readonly bool mock;

        public RssFeedEngine(IList<Feed> feeds, bool mock = false)
        {
            this.feeds = feeds;
            this.mock = mock;
        }

        public IList<RssFeedData> GetFeedData()
        {
            List<RssFeedData> feedData = new List<RssFeedData>();
            foreach (Feed feed in feeds)
            {
                feedData.AddRange(GetRssData(feed));
            }

            return feedData;
        }

        private IList<RssFeedData> GetRssData(Feed feed)
        {
            List<RssFeedData> list = new List<RssFeedData>();
            // I am 99% sure this isn't the right way to mock but...
            if (mock)
            {

                list.Add(new RssFeedData()
                {
                    Company = feed.Company,
                    URL = feed.URL,
                    Channel = new Item { Title = "Channel Title1", PubDate = "Fri, 27 Nov 2020 18:00:00 +0000" },
                    Items = new List<Item> { new Item { Title = "#1571 - Emily Harrington", PubDate = "Fri, 27 Nov 2020 18:00:00 +0000" },
                                             new Item { Title = "#1572 - Khabib Johnson", PubDate = "Fri, 27 Oct 2020 18:00:00 +0000" }}
                });
                list.Add(new RssFeedData()
                {
                    Company = feed.Company,
                    URL = feed.URL,
                    Channel = new Item { Title = "Channel Title2", PubDate = "Mon, 25 Jan 2021 18:00:00 +0000" },
                    Items = new List<Item> { new Item { Title = "#1654 - Mary Smith", PubDate = "Mon, 25 Jan 2021 18:00:00 +0000" },
                                             new Item { Title = "#1655 - Emily Dickenson", PubDate = "Fri, 27 Oct 2020 18:00:00 +0000" }}
                });
            }
            else
            {
                // Parse XML (XSLT) for Channels at min.  Ideally all items to enable more functionality later.
            }

            return list;
        }


    }
}
