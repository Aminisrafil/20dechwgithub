using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace _20_dechw_visual
{
    internal class Car
    {
        //Aşağıdaki parametrlərə sahib Car class yaradın
        //- Brand
        //- Model
        //- CurrentFuel - masinin hazirki benzin miqdari
        //- FuelFor1Km - masinin 1 km ucun xerclediyi benzin
        //- Millage - Masinin bu vaxtadək neçə km sürüldüyü
        //- Drive() - sürülmə metodu.Bu metod int parametr qeəbul edir (neçə km sürmək istədiyimiz)
        //Car obyekti yaradın drive metodunu işə saldıqda arqument olaraq neçə km sürmək istədyimizi daxil edirik
        //və əgər benzin kifayət edirsə maşının millage dəyəri
        //və benzini azalır, benzin kifayət etmirsə console-da xəta mesajı yazılır
        public string Brand;
        public string Model;
        public int CurrentFuel;
        public int FuelFor1km;
        public int Millage;

        public void Drive(int km)
        {
            if (CurrentFuel / FuelFor1km >= km)
            {
                Console.WriteLine("Benzin miqdari yeterlidir");
                CurrentFuel -= FuelFor1km * km;
                Millage += km;
            }
            else
            {
                Console.WriteLine("Bu mesafeni getmek ucun kifayet benzin yoxdu");
            }
            
        }
        public string GetInfo()
        {
            return $"Car Brand:{Brand}||" +
                $"Car Model:{Model}||" +
                $"Current Fuel:{CurrentFuel}||" +
                $"Fuel Per 1km:{FuelFor1km}||" +
                $"Total driven km:{Millage}";
        }
    }
}
