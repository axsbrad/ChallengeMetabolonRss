using System;
using System.Collections.Generic;
using System.Text;

namespace MetabolonRssChallenge
{
    public interface IRssFunctions
    {
        //companies had no activity for a given number of days.
        Dictionary<string, string> CompaniesNoActivityforDays(int days);

    }
}
