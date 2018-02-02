using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int a = Convert.ToInt32(line);

            CalculatorInt CI = new CalculatorInt();
            Console.WriteLine(CI.Add(a, 5));


            CalculatorFloat CF = new CalculatorFloat();
            Console.WriteLine(CF.Multiply(5.3f,7.1f));
            float result = CF.Add(10.86f, 11.28f);
            Console.WriteLine("Vysledok druheho floatu je: {0:0.00}", result); //formatovanie na dve desatinne miesta: { 0.00 }

            CalculatorFloatInterface CFI = new CalculatorFloatInterface();
            Console.WriteLine(CF.Add(5, 8));

            string naformatovanyString = String.Format("vysledok je {0}", result);

            // novy Csharp postup na formatovanie stringu
            string novyCSharpFormat = $"vysledok je{result} a dalsi vysledok je {result}";


            //pred ridici znaky davam lomitko, aby sm mu povedal, ze nechcem napr /t co je tab - vyescapovanie
            string cestaKSuboru = "C:\\temp\\log.txt";


            //nebo pred cely retazec uvadim zavinac, aby ignoroval riadiace znaky
            string cestaKSuboru1 = @"C:\temp\log.txt";

            string dobryDen = "\"Dobry den\"";
            Console.WriteLine(dobryDen);

            //escape sequence pozret na Stackowerflow al googli

            Console.ReadLine();
            
        }
    }
}
