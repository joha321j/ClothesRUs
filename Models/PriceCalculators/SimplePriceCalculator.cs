namespace ClothesRUs.Models.PriceCalculators
{
    public class SimplePriceCalculator: PriceCalculator
    {

        public double CalculatePrice(double basePrice)
        {
            return basePrice;
        }
    }
}