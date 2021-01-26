using NUnit.Framework;
using System.Collections.Generic;
using MetabolonRssChallenge;

namespace NUnitTestProject
{
    public class Tests
    {
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
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestRssFeedEngine()
        {
            RssFeedEngine rssFeedEngine = new RssFeedEngine(MockFeeds, false);

            IList<RssFeedData>  result =  rssFeedEngine.GetFeedData();
      
           if(result.Count == 10) Assert.Pass();
            Assert.Fail($"result.Count <> 10 ({result.Count})");

        }
    }
}