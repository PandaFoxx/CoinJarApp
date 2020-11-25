using System.Linq;

namespace CoinJarApp.Business
{
  public class Rules : IRules
  {
    private const decimal MaxVolume = 42;
    private readonly decimal[] _coinsInCirculation = {0.01m, 0.05m, 0.1m, 0.25m, 0.5m, 1.0m};

    public decimal GetCapacity()
    {
      return MaxVolume;
    }

    public bool IsJarFull(
      decimal volume)
    {
      return volume >= MaxVolume;
    }

    public bool IsAmountValid(
      decimal amount)
    {
      return _coinsInCirculation.Any(a => a == amount);
    }
  }
}