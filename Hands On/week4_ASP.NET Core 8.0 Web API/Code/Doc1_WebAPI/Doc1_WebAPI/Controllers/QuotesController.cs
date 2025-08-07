using Microsoft.AspNetCore.Mvc;
using Doc1_WebAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace Doc1_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuotesController : ControllerBase
    {
        // Hardcoded list of quotes
        private static List<Quote> quotes = new List<Quote>
        {
            new Quote { Id = 1, Text = "Be yourself; everyone else is already taken.", Author = "Oscar Wilde" },
            new Quote { Id = 2, Text = "In the middle of every difficulty lies opportunity.", Author = "Albert Einstein" }
        };

        // GET /Quotes
        [HttpGet]
        public ActionResult<IEnumerable<Quote>> Get()
        {
            return Ok(quotes);
        }

        // POST /Quotes
        [HttpPost]
        public ActionResult AddQuote([FromBody] Quote newQuote)
        {
            newQuote.Id = quotes.Max(q => q.Id) + 1;
            quotes.Add(newQuote);
            return Ok(newQuote);
        }
    }
}
