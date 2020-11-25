using CoinJarApp.Models;

namespace CoinJarApp.Storage
{
  public interface IStorage
  {
    Coin WithdrawCoins();

    void SaveCoins(Coin data);
  }
}