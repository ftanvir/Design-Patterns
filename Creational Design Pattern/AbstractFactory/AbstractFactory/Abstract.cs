using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IPizza
    {
        string Eat();
    }

    class VegPizza : IPizza
    {
        public string Eat()
        {
            return "Eating Veg Pizza";
        }
    }

    class NonVegPizza : IPizza
    {
        public string Eat()
        {
            return "Eating Non Veg Pizza";
        }
    }

    public interface IBurger
    {
        string Eat();
    }

    class VegBurger: IBurger
    {
        public string Eat()
        {
            return "Eating Veg Burger";
        }
    }

    class NonVegBurger: IBurger
    {
        public string Eat()
        {
            return "Eating Non Veg Burger";
        }
    }

    interface IChef
    {
        IPizza PreparePizza();
        IBurger PrepareBurger();
    }

    class VegChef: IChef
    {
        public IBurger PrepareBurger()
        {
            return new VegBurger();
        }

        public IPizza PreparePizza()
        {
            return new VegPizza();
        }


    }

    class NonVegChef: IChef
    {
        public IBurger PrepareBurger()
        {
            return new NonVegBurger();
        }

        public IPizza PreparePizza()
        {
            return new NonVegPizza();
        }
    }

    class Waiter
    {
        private IChef foodFactory;

        public Waiter(string food)
        {
            if(food== "Veg")
            {
                foodFactory = new VegChef();
            } else
            {
                foodFactory = new NonVegChef();
            }
        }

        public IPizza GetPizza()
        {
            return foodFactory.PreparePizza();
        }
        public IBurger GetBurger()
        {
            return foodFactory.PrepareBurger();
        }
    }
}
