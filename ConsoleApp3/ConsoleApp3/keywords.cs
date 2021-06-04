using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class keywords
    {
        public String keywordName;
        public String keywordMeaning;
        //constractor to assin value to keywords
        public keywords(String keywordName, String keywordMeaning)
        {
            this.keywordName = keywordName;
            this.keywordMeaning = keywordMeaning;
        }


        //this function to check the tooken is equall keyword or not
        public bool isthis(String tooken)
        {
            return tooken == this.keywordName;
        }
    }
}
