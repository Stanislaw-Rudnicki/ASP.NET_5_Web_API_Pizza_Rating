using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using WebApplication9_Pizza_json.Models;

namespace WebApplication9_Pizza_json.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaRatingController : ControllerBase
    {
        private readonly ILogger<PizzaRatingController> _logger;

        public PizzaRatingController(ILogger<PizzaRatingController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Post(List<Pizza> pizzas)
        {
            var watch = Stopwatch.StartNew();

            List<Pizza> rating = new();
            var groups = pizzas.GroupBy(p => p.Name).OrderByDescending(g => g.Count()).Take(10);

            foreach (var group in groups)
            {
                Pizza p = group.FirstOrDefault();
                p.Orders = group.Count();
                rating.Add(p);
            }

            watch.Stop();
            _logger.LogInformation(watch.ElapsedMilliseconds.ToString() + " ms");

            return Ok(rating);
        }
    }
}
