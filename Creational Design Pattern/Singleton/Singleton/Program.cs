using System;

public class Singleton
{
    // Private static variable to hold the single instance of the class.
    private static Singleton _instance;

    // Private constructor to prevent instantiation from other classes.
    private Singleton()
    {
    }

    // Public static method to provide a global point of access to the instance.
    public static Singleton Instance
    {
        get
        {
            // If the instance doesn't exist yet, create it.
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

    // Example method that can be called on the singleton instance.
    public void DoSomething()
    {
        Console.WriteLine("Singleton instance is working.");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        // Access the singleton instance and call a method on it.
        Singleton singleton = Singleton.Instance;
        singleton.DoSomething();

        // Attempting to create another instance will still return the same instance.
        Singleton anotherSingleton = Singleton.Instance;
        anotherSingleton.DoSomething();

        // Verify that both instances are indeed the same.
        Console.WriteLine(Object.ReferenceEquals(singleton, anotherSingleton)); // Outputs: True
    }
}

