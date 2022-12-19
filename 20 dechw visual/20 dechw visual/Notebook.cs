using System;
using System.Collections.Generic;
using System.Text;

namespace _20_dechw_visual
{
    internal class Notebook
    {
        // Notebook class yaradın ve aşağıdakı xüsusiyyətləri olsun 
        //-Name - məhsulun adını ifadə edən xüsusiyyət
        //-BrandName - Notebook - un  brand adı
        //-Price - Notebook - un qiyməti.
        public string Name;
        public string BrandName;
        public double Price;

        public string GetInfo()
        {
            return $"Product Type:{Name}||" +
                $"Product Brand:{BrandName}||" +
                $"Product Price:{Price}"; 


        }
    }
}
