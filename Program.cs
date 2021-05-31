using System;

namespace FastFoodOracle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fast Food Oracle!");
            MongoDBConnection connection = new MongoDBConnection();
            connection.printAllDBs();
        }
    }
}
