using System;
using System.Collections.Generic;
using System.Text;

namespace MetabolonRssChallenge
{
    public class RssFeedData : Feed, IRssFeedData
    {
        public Item Channel { get; set; }
        public ICollection<Item> Items { get; set; }
    }
    public class Item
    {
        public string Title { get; set; }
        public string PubDate { get; set; }

        public DateTime DatePublished { get
            {
                return DateTime.Parse(PubDate);
            } }
    }
}
