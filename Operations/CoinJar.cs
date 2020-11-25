using System;
using CoinJarApp.Models;
using CoinJarApp.Storage;

namespace CoinJarApp.Operations
{
  public class CoinJar : ICoinJar
  {
    private readonly IStorage _jar;
    private readonly IRules _rules;

    public CoinJar(
      IStorage storage,
      IRules rules)
    {
      _jar = storage;
      _rules = rules;
    }

    public void AddCoin(
      ICoin coin)
    {
      if (!_rules.IsAmountValid(coin.Amount))
        throw new Exception($"Error: ${coin.Amount:F2} is not a valid coin.");

      var coinsInJar = _jar.WithdrawCoins();

      coinsInJar.Volume += coin.Volume;
      coinsInJar.Amount += coin.Amount;

      if (_rules.IsJarFull(coinsInJar.Volume))
        throw new Exception(
          $"Error: Unable to add more coins because the jar has reached max volume of {_rules.GetCapacity()} ounces.");

      _jar.SaveCoins(coinsInJar);
    }

    public decimal GetTotalAmount()
    {
      var coins = _jar.WithdrawCoins();

      return coins?.Amount ?? 0;
    }

    public void Reset()
    {
      _jar.SaveCoins(new Coin());
    }
  }
}