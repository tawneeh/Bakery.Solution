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
      if (BreadAmount % 3 == 0) 
      {
        int multipleOfThree = BreadAmount / 3;
        int dealAmount = BreadAmount - multipleOfThree;
        return dealAmount * 5;
      }
      else
      {
      int totalBreadPrice = BreadAmount * Bread.Price;
      return totalBreadPrice;
      }
    }

  }
}