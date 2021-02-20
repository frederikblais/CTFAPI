using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CTFAPI.Controllers
{
    public class FlagController : ControllerBase
    {
        [HttpGet("/api/flag")]
        [AllowAnonymous]
        public string GetFlag() => "{CTF-y0u-f0und-7h3-f149}";
    }
}
