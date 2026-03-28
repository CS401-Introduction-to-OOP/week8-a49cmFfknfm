namespace Week8;

public class Parcel : DeliveryItem
{
    public string Dimensions;

    public Parcel(string trackNum, double weight, string dimensions) : base(trackNum, weight)
    {
        this.Dimensions = dimensions;
    }
    
    public override double CalculateCost()
    {
        return 50 + (this.Weight * 25);
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine(Dimensions);
    }
    
}