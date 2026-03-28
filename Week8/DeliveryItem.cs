namespace Week8;

public abstract class DeliveryItem
{
    public string TrackingNumber;
    public double Weight;
    public abstract double CalculateCost();
    
    public DeliveryItem(string trackNum, double weight)
    {
        this.TrackingNumber = trackNum;
        this.Weight = weight;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"The track number is: {this.TrackingNumber} \n Weight is {this.Weight}");
    }

   

}