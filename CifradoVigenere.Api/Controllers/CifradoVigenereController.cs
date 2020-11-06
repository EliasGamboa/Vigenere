using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CifradoVigenere.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EncriptarController : ControllerBase
    {
        private readonly ILogger<EncriptarController> _logger;
        Pokemon pokemon = new Pokemon();

        public EncriptarController(ILogger<EncriptarController> logger)
        {
            _logger = logger;
        }

        public string Encriptar = "HOLA MUNDO";

        [HttpPost]
        public IActionResult Post(string RequestEncrypt)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            Encriptar = RequestEncrypt;

            return Ok();
        }


        [HttpGet]
        public IActionResult Get()
        {
            StringBuilder text = new StringBuilder(Encriptar);
            string clave = pokemon.Keys();
            for (int i = 0; i < text.Length; i++) text[i] = char.ToUpper(text[i]);
            clave = clave.ToUpper();
            int c = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    text[i] = (char)(text[i] + clave[c] - 'A');
                    if (text[i] > 'Z') text[i] = (char)(text[i] - 'Z' + 'A' - 1);
                }
                c = c + 1 == clave.Length ? 0 : c + 1;
            }
            return Ok("Esta es la palabra encriptada: " + text.ToString());
        }
        public class Desencriptar{

            }
    }

}