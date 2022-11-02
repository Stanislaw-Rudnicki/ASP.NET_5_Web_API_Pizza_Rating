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

            // Тут можна було б групувати по назві піци, яка складається
            // з перших двох літер кожного топінгу, що входить до складу піци,
            // але зустрічаються разні топінги, які починаються на однакові літери,
            // наприклад: cheddar cheese, chicken; salami, sausage.
            // Тому групувати необхідно по рядку утвореному з повних назв топінгів.

            var groups = pizzas
                .GroupBy(p => {
                    p.Toppings.Sort();
                    return string.Join("", p.Toppings);
                })
                .OrderByDescending(g => g.Count())
                .Take(10);

            foreach (var group in groups)
            {
                group.FirstOrDefault().Orders = group.Count();
                rating.Add(group.FirstOrDefault());
            }

            watch.Stop();
            _logger.LogInformation(watch.ElapsedMilliseconds.ToString() + " ms");

            return Ok(rating);
        }
    }
}
