using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsAppFarmer
{
    class Farmer
    {
        private int feedMultiplier;

        private int numberOfCows;

        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }
        public int NumberOfCows
        {
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
        public int BagsOfFeed { get; private set; }
        public int FeedMultiplier { get { return feedMultiplier; } }
    }
}
