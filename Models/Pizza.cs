using System.Collections.Generic;

namespace WebApplication9_Pizza_json.Models
{
    public class Pizza
    {
        public int Orders { get; set; }
        public string Name
        {
            get
            {
                string name = "";
                Toppings.Sort();
                foreach (var topping in Toppings)
                {
                    name += topping.Length < 2 ? topping : topping[..2];
                }
                return name;
            }
        }
        
        public List<string> Toppings { get; set; }
    }
}
