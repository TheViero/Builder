using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Builder1.Builder;

namespace Builder1
{
    internal class Builder
    {
        public class Pizza
        {
            public string FlourType { get; set; }
            public List<string> Ingredients { get; set; }
            public int BakingTime { get; set; }
            public string Shape { get; set; }
            public int Size { get; set; }
        }

        public abstract class PizzaBuilder
        {
            protected Pizza pizza;

            public Pizza GetPizza()
            {
                return pizza;
            }

            public abstract PizzaBuilder SetFlourType(string flourType);
            public abstract PizzaBuilder AddIngredient(string ingredient);
            public abstract PizzaBuilder SetBakingTime(int bakingTime);
            public abstract PizzaBuilder SetShape(string shape);
            public abstract PizzaBuilder SetSize(int size);
        }

        public class MalaPizzaBuilder : PizzaBuilder
        {
            public MalaPizzaBuilder()
            {
                pizza = new Pizza();
            }

            public override PizzaBuilder SetFlourType(string flourType)
            {
                pizza.FlourType = flourType;
                return this;
            }
            public override PizzaBuilder AddIngredient(string ingredient)
            {
                if (pizza.Ingredients == null)
                {
                    pizza.Ingredients = new List<string>();
                }
                pizza.Ingredients.Add(ingredient);
                return this;
            }
            public override PizzaBuilder SetBakingTime(int bakingTime)
            {
                pizza.BakingTime = bakingTime;
                return this;
            }
            public override PizzaBuilder SetShape(string shape)
            {
                pizza.Shape = shape;
                return this;
            }
            public override PizzaBuilder SetSize(int size)
            {
                pizza.Size = size;
                return this;
            }
        }


        public class SriedniaPizzaBuilder : PizzaBuilder
        {
            public SriedniaPizzaBuilder()
            {
                pizza = new Pizza();
            }

            public override PizzaBuilder SetFlourType(string flourType)
            {
                pizza.FlourType = flourType;
                return this;
            }
            public override PizzaBuilder AddIngredient(string ingredient)
            {
                if (pizza.Ingredients == null)
                {
                    pizza.Ingredients = new List<string>();
                }
                pizza.Ingredients.Add(ingredient);
                return this;
            }
            public override PizzaBuilder SetBakingTime(int bakingTime)
            {
                pizza.BakingTime = bakingTime;
                return this;
            }
            public override PizzaBuilder SetShape(string shape)
            {
                pizza.Shape = shape;
                return this;
            }
            public override PizzaBuilder SetSize(int size)
            {
                pizza.Size = size;
                return this;
            }
        }



        public class DuzaPizzaBuilder : PizzaBuilder
        {
            public DuzaPizzaBuilder()
            {
                pizza = new Pizza();
            }

            public override PizzaBuilder SetFlourType(string flourType)
            {
                pizza.FlourType = flourType;
                return this;
            }
            public override PizzaBuilder AddIngredient(string ingredient)
            {
                if (pizza.Ingredients == null)
                {
                    pizza.Ingredients = new List<string>();
                }
                pizza.Ingredients.Add(ingredient);
                return this;
            }
            public override PizzaBuilder SetBakingTime(int bakingTime)
            {
                pizza.BakingTime = bakingTime;
                return this;
            }
            public override PizzaBuilder SetShape(string shape)
            {
                pizza.Shape = shape;
                return this;
            }
            public override PizzaBuilder SetSize(int size)
            {
                pizza.Size = size;
                return this;
            }
        }


        public class PizzaDirector
        {
            public Pizza MakePizza(PizzaBuilder builder)
            {
                return builder.SetFlourType("Піцца")
                              .SetBakingTime(60)
                              .SetShape("Буханець")
                              .SetSize(500)
                              .GetPizza();
            }
        }

       
    }
}
