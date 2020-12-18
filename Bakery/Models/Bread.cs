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
      int totalBreadPrice = BreadAmount * Bread.Price; // getter and setter gets the BreadAmount from UI
      return totalBreadPrice;
    }

  }
}

// Bread deal - if (breadAmount % 3 == 0) { then 1 loaf is free. *for each 3* -- signify with a for loop, how?