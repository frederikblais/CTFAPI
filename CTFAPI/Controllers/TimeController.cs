using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CTFAPI.Controllers
{
    public class TimeController : ControllerBase
    {
        string time = DateTime.Now.ToString("h:mm:ss tt");

        [HttpGet("/api/time")]
        [AllowAnonymous]
        public string GetTime() => time;
    }
}
