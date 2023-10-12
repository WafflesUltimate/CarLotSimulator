using System;
using System.Collections.Generic;
using System.Linq;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> carList = new List<Car>();

        public static int nubmerOfCars = 0;
        
    }



    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            CarLot carLot = new CarLot();


            Car firstCar = new Car();

            firstCar.make = "Toyota";
            firstCar.model = "Tundra";
            firstCar.year = 2008;
            firstCar.honkNoise = "hoooonnnkkk";
            firstCar.engineNoise = "vvrroooommm";
            firstCar.isDriveAble = true;

            carLot.carList.Add(firstCar);
            CarLot.nubmerOfCars++;
            Console.WriteLine($"There is {CarLot.nubmerOfCars} car in our lot");

            Car secondCar = new Car()
            {
                make = "Jeep",
                year = 2016,
                model = "Grand Cherokee",
                honkNoise = "hoooonnnkkk",
                engineNoise = "vvrroooommm",
                isDriveAble = true

            };

            carLot.carList.Add(secondCar);
            CarLot.nubmerOfCars++;
            Console.WriteLine($"There are {CarLot.nubmerOfCars} cars in our lot");

            Car thirdCar = new Car(2023, "Hyundi", "Elantra", "hoooonnnkkk", "vvrroooommm", true);

            carLot.carList.Add(thirdCar);
            CarLot.nubmerOfCars++;
            Console.WriteLine($"There are {CarLot.nubmerOfCars} cars in our lot");

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"These are the cars in our lot: ");

            foreach (var car in carLot.carList)
            {
               Console.WriteLine($"{car.make} {car.model} {car.year}");
            }
        }
    }
}
