using System;

namespace CarLotSimulator
{

    public class Car
    {


        public Car() { }

        public Car(int Year, string Make, string Model, string HonkNoise, string EngineNoise, bool IsDriveAble)
        {
            year = Year;
             make = Make;
            model = Model;
            honkNoise = HonkNoise;
            engineNoise = EngineNoise;
            isDriveAble = IsDriveAble;

        }

        public int year {  get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string honkNoise { get; set; }
        public string engineNoise { get; set; }
        public bool isDriveAble { get; set; }

        public void MakeEngineNoise(string engineNoise) { Console.WriteLine($"{engineNoise}!!!"); }
         
        public void MakeHonkNoise(string honkNoise) { Console.WriteLine($"{honkNoise}!!!"); }

       
    }


    

}