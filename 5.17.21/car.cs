using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._17._21
{
    class car
    {
        public string Marka;
        public string Model;
        public decimal CurrentFuel;
        public decimal MaxFuel;
        public decimal FuelEff;

        public car(string marka, string model, decimal currentFuel, decimal maxFuel, decimal fuelEff)
        {
            Marka = marka;
            Model = model;
            CurrentFuel = currentFuel;
            MaxFuel = maxFuel;
            FuelEff = fuelEff;
        }
        public void Go(){

        Geri:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Nece km getmek isteyirsiz?");
            string neededKm = Console.ReadLine();
            try
            {
                decimal neededKmDec = Convert.ToDecimal(neededKm);
                if(CurrentFuel>= neededKmDec * FuelEff / 100)
                {
                    CurrentFuel -= neededKmDec * FuelEff / 100;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Siz {neededKmDec}km yol getdiniz. Masinda {CurrentFuel}l benzin qaldi");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Zehmet olmasa benzin doldurun. Benzin kifayet etmedi");
                }
            }
            catch (Exception)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please, write numeric number");
                goto Geri;
            }
        }
        public void TopUp()
        {
            Geri:
            Console.WriteLine("Nece litr benzin doldurmaq isteyirsiz?");
            string neededFuel=Console.ReadLine();
            try
            {
                decimal neededFuelDec = Convert.ToDecimal(neededFuel);
                if (MaxFuel >= neededFuelDec + CurrentFuel)
                {
                    CurrentFuel += neededFuelDec;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Siz {neededFuelDec}l benzin doldurdunuz. Masinda {CurrentFuel}l benzin var.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Maximum tutumu kecdiniz.");
                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please, write numeric number");
                goto Geri;
            }
        }
    }
}
