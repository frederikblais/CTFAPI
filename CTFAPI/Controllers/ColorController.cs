using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Drawing;

namespace CTFAPI.Controllers
{
    public class ColorController : ControllerBase
    {
        [HttpGet("/api/color")]
        [AllowAnonymous]
        public string GetColor()
        {
            var rand = new Random();
            Color c = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            return c.ToString();
        }
    }
}
