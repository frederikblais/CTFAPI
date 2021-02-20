using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CTFAPI.Controllers
{
    public class CoinFlipController : ControllerBase
    {
        [HttpGet("/api/coin")]
        [AllowAnonymous]
        public string GetCoin()
        {
            string coin = "" ;
            Random rand = new Random();

            if (rand.Next(0, 2) == 0)
                coin = "Heads";

            else
                coin = "Tails";

            return coin;
        }
    }
}
