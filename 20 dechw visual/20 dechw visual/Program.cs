using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace _20_dechw_visual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Notebook class yaradın ve aşağıdakı xüsusiyyətləri olsun 
           //-Name - məhsulun adını ifadə edən xüsusiyyət
          //-BrandName - Notebook - un  brand adı
         //-Price - Notebook - un qiyməti.
            Notebook notebook1 = new Notebook();
            notebook1.Name = "Digital Notebook";
            notebook1.BrandName = "Amin's notebooks";
            notebook1.Price = 14.99;

            Notebook notebook2 = new Notebook();
            notebook2.Name = "Digital Notebook";
            notebook2.BrandName = "Elcin's notebooks";
            notebook2.Price = 24.99;

            Notebook notebook3 = new Notebook();
            notebook3.Name = "Digital Notebook";
            notebook3.BrandName = "Filankes's notebooks";
            notebook3.Price = 4.99;
            
            Console.WriteLine(notebook1.GetInfo());

            //1 - ci tapşırıqda yaratdığınız Notebook classindan bir notebook array - i duzeldin
            //Layihə işə düşdükdə bizdən minPrice dəyəri daxil etməyimizi və
            //daha sonra maxPrice dəyəri daxil etməyimizi istəsin.
            //Daha sonra yaratmış olduğumuz array - də minPrice və
            //maxPrice aralığında qiyməti olan notebookların adlarını console - a yazdırsız

            Notebook[] notebooks = {notebook1, notebook2,notebook3};
            Console.WriteLine(IdealPrice(notebooks));
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
            Car car1 = new Car();
            car1.Brand = "Mercedes";
            car1.Model = "S class";
            car1.CurrentFuel = 20;
            car1.FuelFor1km = 5;
            car1.Millage = 0;

            car1.Drive(4);
            Console.WriteLine(car1.GetInfo());
            
        }
        static string IdealPrice(Notebook[] notebooks)
        {
            var min_priceStr = Console.ReadLine();
            var min_price = Convert.ToInt32(min_priceStr);

            var max_priceStr = Console.ReadLine();
            var max_price = Convert.ToInt32(max_priceStr);

            var Idealprice = "";

            for (int i = 0; i < notebooks.Length; i++)
            {
                if (notebooks[i].Price>min_price && notebooks[i].Price < max_price)
                {
                    Idealprice += notebooks[i].BrandName + " ";
                }
            }
            return Idealprice;
        }
    }
}
