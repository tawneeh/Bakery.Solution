namespace Bakery.Models

{
  public class Bread
  {
    public int BreadAmount { get; set; }
    public static int Price { get; set; } = 5; 
    public Bread(int breadAmount)
    {
      Price = 5;
      BreadAmount = breadAmount;
    }

    public int GetBreadPrice()
    {
      Bread newBread = new Bread(BreadAmount);
      if (BreadAmount == 2) 
      {
        int dealAmount = BreadAmount + 1;
        int dealPrice = dealAmount * Bread.Price - Bread.Price;
        return dealPrice;
      }
      else
      {
      int totalBreadPrice = BreadAmount * Bread.Price;
      return totalBreadPrice;
      }
    }

  }
}