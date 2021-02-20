using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CTFAPI.Controllers
{
    public class NameController : ControllerBase
    {
        [HttpGet("/api/name")]
        [AllowAnonymous]
        public string GetName() => "My name is: Frederik";
    }
}
