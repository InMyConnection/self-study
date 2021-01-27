using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsAppDinnerParty
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }
        private decimal CalculateCostOfBeveragesPerPerson()
        {
            if (HealthyOption)
                return 5;
            return 20;
        }
        private decimal CalculateCostOfDecoration()
        {
            if (FancyDecorations)
                return 50 + 15 * NumberOfPeople;
            return 30 + 7.5M * NumberOfPeople;
        }
        public decimal Cost
        {
            get
            {
                decimal totalCost = (CostOfFoodPerPerson + CalculateCostOfBeveragesPerPerson()) * NumberOfPeople + CalculateCostOfDecoration();
                if (HealthyOption)
                    totalCost *= 0.95M;
                return totalCost;
            }
        }
    }
}
