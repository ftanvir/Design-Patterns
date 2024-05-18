using System;   


namespace AbstractFactory
{
    class Program
    {
        public static void Main(string[] args)
        {
            Waiter waiter = new Waiter("Veg");
            IPizza pizza = waiter.GetPizza();

            Console.WriteLine(pizza.Eat());
        }
    }

}
