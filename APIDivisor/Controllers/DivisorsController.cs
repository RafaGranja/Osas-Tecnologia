using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using APIDivisor;
namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Divisors : ControllerBase
    {

        private readonly ILogger<Divisors> _logger;

        public Divisors(ILogger<Divisors> logger)
        {
            _logger = logger;
        }

        [HttpGet("Divisores/{number}", Name = "Divisors")]
        public IActionResult Get(int number)
        {

            try
            {
                number = int.Parse(number.ToString());

                if (number <= 0)
                {

                    throw new Exception("Valor inválido, número deve ser maior que 0");

                }
                else
                {
                    Divisores ret = new Divisores(number);

                    return Ok(ret);
                }
            }
            catch (Exception e)
            {

                return NotFound(e);

            }

        }
    }
}