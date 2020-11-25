using System;
using System.Net;
using CoinJarApp.Models;
using CoinJarApp.Operations;
using Microsoft.AspNetCore.Mvc;

namespace CoinJarApp.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class DataController : ControllerBase
  {
    private readonly ICoinJar _coinJar;

    public DataController(
      ICoinJar coinJar)
    {
      _coinJar = coinJar;
    }

    [HttpPost]
    [Route("add")]
    public ActionResult AddCoin(
      decimal amount,
      decimal volume)
    {
      try
      {
        _coinJar.AddCoin(new Coin
        {
          Amount = amount,
          Volume = volume
        });
        return Ok("Coin added successfully.");
      }
      catch (Exception e)
      {
        return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
      }
    }

    [HttpGet]
    [Route("total")]
    public string GetTotalAmount()
    {
      var totalAmount = _coinJar.GetTotalAmount();
      return $"${totalAmount:F2}";
    }

    [HttpDelete]
    [Route("reset")]
    public void Reset()
    {
      _coinJar.Reset();
    }
  }
}