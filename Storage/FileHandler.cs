using System.IO;
using CoinJarApp.Models;
using Newtonsoft.Json;

namespace CoinJarApp.Storage
{
  public class FileHandler : IStorage
  {
    private const string DataFile = @"data.txt";

    public void SaveCoins(
      Coin data)
    {
      File.WriteAllText(DataFile, JsonConvert.SerializeObject(data));
    }

    public Coin WithdrawCoins()
    {
      var coin = new Coin();

      if (!File.Exists(DataFile))
        return coin;

      var data = File.ReadAllText(DataFile);

      if (!string.IsNullOrEmpty(data))
        coin = JsonConvert.DeserializeObject<Coin>(data);

      return coin;
    }
  }
}