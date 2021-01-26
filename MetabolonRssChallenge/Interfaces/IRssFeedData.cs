using System.Collections.Generic;

namespace MetabolonRssChallenge
{
    interface IRssFeedData
    {  
        Item Channel { get; set; }
        ICollection<Item> Items { get; set; }
    }
}