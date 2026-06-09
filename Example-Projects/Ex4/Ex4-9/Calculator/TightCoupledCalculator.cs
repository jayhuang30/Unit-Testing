namespace CalculatorUtilityServices;

/// <summary>
/// If one uses this tight-coupled calculator, 
/// then one can't mock the value used internally, 
/// consequently, it is impossible to cover all uses cases (and edge class).
/// </summary>
/// <remark>
/// See <see cref="global::CalculatorUtilityServices.LooseCoupledCalculator"/> for the explanation of better design.
/// </remark>
public class TightCoupledCalculator
{
    public int GetDiscountedPrice(int price)
    {
        if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
        {
            return price / 2;
        }
        else
        {
            return price;
        }
    }
}
