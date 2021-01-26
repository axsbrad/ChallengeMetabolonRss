using System;
using System.Collections.Generic;

namespace MetabolonRssChallenge
{
    //  Task *: Given a Dictionary keyed by Company and valued by RSS feed url, write a function that determines which companies had no activity for a given number of days.
    //  * Evaluation *: Your submission is evaluated as the limit of your ability to follow directions and deliver production code.
    //  * Resources *: https://rss.com/popular-rss-feeds/ provides many example companies and their RSS feeds
    //  *How to submit *: Provide a link to a github repo
    //  * Hints *:
    //• Some companies might have more than one feed.
    //  • Our code has unit tests.
    //  • Our code is made in incremental commits and with meaningful comments.
    //  • Reply with questions if necessary, or document assumptions used to make progress.
    class Program
    {
        static void Main(string[] args)
        {
            bool mock = true; // I know this isn't how to mock but it enabled functional testing without Unit test added to project
            int days = 5; //TODO[Bring from args]
        
            //Get List of feeds to verify
            FeedSource feedSource = new FeedSource(mock);
            RssFeedEngine rssFeedEngine = new RssFeedEngine(feedSource.Data(),mock);   
            RssFunctions rssFunctions = new RssFunctions(rssFeedEngine.GetFeedData());
            Dictionary<string,string> results = rssFunctions.CompaniesNoActivityforDays(days);
   
           foreach(var dict in results)
            {
                Console.WriteLine($"key: {dict.Key}: Value={dict.Value}");
            }
        }
    }
}
