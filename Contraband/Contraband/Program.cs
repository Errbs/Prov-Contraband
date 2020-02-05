using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class Program

    {
        static Random carType = new Random();//Random to randomize the type of car.
        static void Main(string[] args)
        {
            bool success = false;
            Console.WriteLine("How many cars should be created ? ");
            string input = Console.ReadLine();
            List<Car> cars = new List<Car>();// Empty list of the class Car called cars
            int inputResult;
            int carIDNumber;// int for the type of car
            success = int.TryParse(input, out inputResult);
            while (success == false|| inputResult < 0 || inputResult == 0)
            {
                //While the user answer with an invalid input the game can't continue, invalid input is anything that isn't a number or a number below or equal to 0.
                Console.WriteLine("Please answer with numbers with a higher value than 0.");
                input = Console.ReadLine();
                success = int.TryParse(input, out inputResult);
               
            }
            for(int i=0; i < inputResult; i++)
            {
                //for loop that repeats until it has added as many cars as the player inputs into the cars list
                carIDNumber = carType.Next(10); //Randomizes which subclass of car is added
                if(carIDNumber <5)
                {
                    cars.Add(new CleanCar());
                    Console.WriteLine(i + "clean cars added");//Check that it runs the code
                }
                else if (carIDNumber>5)
                {
                    cars.Add(new ContrabandCar());
                    Console.WriteLine(i + "contraband cars added");//Check that it runs the code
                }
                
            }
            Console.WriteLine("What car would you like to examine?");
            input = Console.ReadLine();
            success = int.TryParse(input, out inputResult);
            if (success==true)
            {
                //My thought of continuing this was to access the list index and then run the examination method on it.
            }
            Console.ReadKey();
        }
    }
}
