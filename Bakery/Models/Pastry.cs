namespace Bakery.Models

{
public class Pastry
  {
    public int PastryAmount { get; set; }

    public static int Price { get; set; } = 2; 
    // needs to be static to apply to the class as a whole

    public Pastry(int pastryAmount)
    {
      Price = 2;
      PastryAmount = pastryAmount;
    } 

    public int GetPastryPrice()
    {
      Pastry newPastry = new Pastry(PastryAmount);
      int multipleOfThree = PastryAmount / 3;
      return PastryAmount * Price - multipleOfThree;
    }

  }
}