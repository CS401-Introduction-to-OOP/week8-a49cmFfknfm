namespace Week8;

public class Letter : DeliveryItem
{
    public Letter(string trackNum, double weight) : base(trackNum, weight)
    {
        
    }

    public override double CalculateCost()
    {
        return 15 * (this.Weight * 10);
    }
}