using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a separate class file called Car: Completed in Car Class!!!
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable: Completed in Car Class!!
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars

            // Standard member initialization
            CarLot colville = new CarLot();
            

            var car1 = new Car();

            colville.CarList.Add(car1);

            car1.Make = "Tesla";
            car1.Model = "Model S";
            car1.Year = 2019;
            car1.IsDriveable = true;
            car1.EngineNoise = "None";
            car1.HonkNoise = "Beethoven";

            car1.MakeEngineNoise();
            car1.MakeHonkNoise();


            
            // Standard member initialization
            var car2 = new Car();
            car2.Make = "Lexus";
            car2.Model = "GX 460";
            car2.Year = 2016;
            car2.IsDriveable = true;
            car2.EngineNoise = "Gra Vroom";
            car2.HonkNoise = "Honk";

            car2.MakeEngineNoise();
            car2.MakeHonkNoise();

            // Standard member initialization
            var car3 = new Car();
            car3.Make = "Audi";
            car3.Model = "Etron";
            car3.Year = 2021;
            car3.IsDriveable = true;
            car3.EngineNoise = "Low Hum";
            car3.HonkNoise = "Beep, Beep";

            car3.MakeEngineNoise();
            car3.MakeHonkNoise();

            //Object initialization 

            var car4 = new Car() { Year = 2021, Make = "Toyota", Model = "4Runner", EngineNoise = "Vroom", HonkNoise = "Beep", IsDriveable = true };
            colville.CarList.Add(car2);

            //Constructor Initialzation

            var car5 = new Car(2021, "Toyota", "4Runner", "Vroom", "Beep", true);

            car5.MakeEngineNoise();
            car5.MakeHonkNoise();
            Console.WriteLine("--------------------------");

            colville.CarList.Add(car3);
            //Call each of the methods for each car

            foreach (var car in colville.CarList)
            {
                
                Console.WriteLine();
                Console.WriteLine($"Car Make: {car.Make}, Car Model: {car.Model}, Car Year: {car.Year}" );
            }

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
