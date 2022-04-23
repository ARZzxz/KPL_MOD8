using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modul8_1302200027.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<string> Stars1 = new List<string> {
            "Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler"
        };

        private static List<string> Stars2 = new List<string> {
            "Marlon Brando", "Heath Ledger", "Aaron Echart", "Michael Caine"
        };

        private static List<string> Stars3 = new List<string>
        {
            "Christian Bale", "Al Pacino", "James Caan", "Diana Keaton"
        };

        private readonly ILogger<MoviesController> _looger;

        List<Movie> movie1 = new List<Movie>();

        public MoviesController(ILo<MoviesController> looger)
        {
            _looger = looger;
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            movie1.Add(new Movie("Overflow", "Satoru Mikami", Stars1, "For a long time ago satoru not meet his cousin. when he meet them looks much groong from them"));
            movie1.Add(new Movie("Overflow", "Masterpiece The Animation"
        }
    }
}
