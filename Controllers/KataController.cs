using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ExplosiveKataApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KataController : ControllerBase
    {
        [HttpGet("explode")]
        public string Explode(string s)
        {
            return string.Join("", s.Select(c => new String(c, int.Parse(c.ToString()))));

        }

        [HttpGet("accum")]
        public string Accum(string s)
        {
            return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
        }
    }
}