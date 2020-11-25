namespace CoinJarApp.Models
{
  public class Coin : ICoin
  {
    public Coin()
    {
      Amount = 0;
      Volume = 0;
    }

    public decimal Amount { get; set; }
    public decimal Volume { get; set; }
  }
}