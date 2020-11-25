namespace CoinJarApp
{
  public interface IRules
  {
    decimal GetCapacity();
    bool IsJarFull(decimal volume);
    bool IsAmountValid(decimal coinsAmount);
  }
}