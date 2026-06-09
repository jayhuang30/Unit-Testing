namespace StringCalculatorUtilityServices;

public class StringCalculator
{
    private bool _isFirstTime = true;
    public List<string> HistoryItems { get; private set; }
    public string CurrentItem { get; private set; }
    public StringCalculator(
        List<string>? items = null
    )
    {
        HistoryItems = items ?? new List<string>();
    }
    public int Add(string item)
    {
        // Only update when the first method call.
        if (_isFirstTime)
        {
            CurrentItem = item;
        }
        HistoryItems.Add(item);
        var items = item.Split(",").Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
        _isFirstTime = false;
        return items.Count;
    }
}
