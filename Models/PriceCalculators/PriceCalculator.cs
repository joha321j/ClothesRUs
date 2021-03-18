namespace ClothesRUs.Models.PriceCalculators
{
    public interface PriceCalculator
    {
        double CalculatePrice(double basePrice);
    }
}