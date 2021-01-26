using System;
using System.Collections.Generic;
using System.Text;

namespace MetabolonRssChallenge
{
    public class FeedSource
    {
        private readonly bool mock;
        //[TODO] Need to parse https://rss.com/blog/popular-rss-feeds/ for the list     
        public FeedSource(bool mock = false)
        {
            this.mock = mock;
        }

        public List<Feed> MockFeeds
        {
            get
            {
                List<Feed> data = new List<Feed>()
                {
                    new Feed{Company="Joe Rogan", URL="http://joeroganexp.joerogan.libsynpro.com/rss"},
                    new Feed{Company="NYTimes 1619", URL="https://feeds.simplecast.com/6HzeyO6b"},
                    new Feed{Company="NPR Code Switch", URL="https://feeds.npr.org/510312/podcast.xml"},
                    new Feed{Company="Crime Junkies", URL="https://feeds.megaphone.fm/ADL9840290619"},
                    new Feed{Company="The Daily by The New York Times", URL="https://feeds.simplecast.com/54nAGcIl"}
                };

                return data;
            }
        }

        public List<Feed> Data()
        {
            if (!mock) return LiveFeeds;
            return MockFeeds;
        }
        private List<Feed> LiveFeeds
        {
            get
            {
                //Need to parse https://rss.com/blog/popular-rss-feeds/ for the list
                throw new NotImplementedException();
            }
        }       
    }
}
