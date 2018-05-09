using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersApp
{
    class Farmer
    {
        public int BagsOfFeed { get; set; }
        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } }
        private int numberOfCows;
        public int NumberOfCows
        {
            // (add the get and set accessors from the
            // previous page)
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }

        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }
    }
}
