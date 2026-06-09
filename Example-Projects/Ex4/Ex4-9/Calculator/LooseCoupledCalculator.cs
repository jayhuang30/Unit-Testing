namespace CalculatorUtilityServices;

/// <summary>
/// If one uses this loosely-coupled calculator, 
/// then one can easily mock the value used internally, 
/// therefore, it is possible to cover all uses cases (and edge class).
/// </summary>
public class LooseCoupledCalculator
{
    public int GetDiscountedPrice(int price, IDateTimeProvider dateTimeProvider)
    {
        if (dateTimeProvider.DayOfWeek() == DayOfWeek.Tuesday)
        {
            return price / 2;
        }
        else
        {
            return price;
        }
    }
}


