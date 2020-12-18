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
      int totalPastryPrice = PastryAmount * Pastry.Price;
      return totalPastryPrice;
    }

  }
}

// Pastry deal: if (pastryAmount % 3 == 0) then price = pastryAmount * 5