using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double a, b, x;
            Console.WriteLine("Podaj a do równania ax+b=0");
             a = double.Parse(Console.ReadLine());
             Console.WriteLine("Podaj b do równania ax+b=0");
             b = double.Parse(Console.ReadLine());
            if (a == 0 || b == 0)
            {
                Console.WriteLine("SHIT HAPPENZ A i B NIE MOŻE RÓWNAć 0");
            }
            else
            {
                x = -b / a;
                Console.WriteLine("W Równaniu {0}x+{1}=0  x wynosi {2}",a,b,x);
            }
            */
            /*double a, b, c, d, x0, x1, x2;
            Console.WriteLine("Podaj a do równania ax^2+bx+c=0");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b do równania ax^2+bx+c=0");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c do równania ax^2+bx+c=0");
            c = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("A nie może się równać 0 :)");
            }
            else
            {
                d = b * b - (4 * a * c);
                Console.WriteLine(d);
                if(d>0)
                {
                    x1 = (-b - Math.Sqrt(d)) / (2 * a);
                    x2 = (-b + Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("X1 = {0} X2 = {1}",x1,x2);
                }
                else if(d==0)
                {
                    x0 = -b / (2 * a);
                    Console.WriteLine("Ma tylko jeden pierwiastek {0}", x0);
                }
                else if(d<0)
                {
                    Console.WriteLine("Brak pierwiastków");
                }
            }*/
            /* if (a < b)
 {
     while (a < b)
     {

         a++;
         Console.WriteLine(a);
     }


 }
 else
 {

     while (a > b)
     {
         int wynik;


         wynik = ;
         Console.WriteLine(wynik);
     }
 }*/

            /*int a = 2, b = 42, c = 0, i = 0, j=0;

            if (a < b)
            {
                for (i = a; i < b+1; i++)
                {
                    c += i;
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (i = b; i <a+1; i++)
                {
                    c += i;
                    Console.WriteLine(i);
                }
            }
            
            Console.WriteLine(c);*/
            // 4 zadanie //
            /*  double wynik = 0;
            while (true) 
            {
                Console.WriteLine("Podaj liczbe");
                double a = double.Parse(Console.ReadLine());
                wynik += a;
                if (a == 0)
                                    break;
               
            }
            Console.WriteLine(wynik);*/

            // Liczby parzyste od a do b
            /*int a,b,i;
            Console.WriteLine("Podaj liczbe a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe b większą od a ");
            b = int.Parse(Console.ReadLine());
            if (a < b) {
                for (i = a; i < b + 1; i++)
                {

                    if (i % 2 == 0)
                        Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Podaj liczby od A do B");
            }*/



            // Liczby podzielne przez 3 od a do b
            /*
             int a,b,i;
             Console.WriteLine("Podaj liczbe a");
             a = int.Parse(Console.ReadLine());
             Console.WriteLine("Podaj liczbe b większą od a ");
             b = int.Parse(Console.ReadLine());
             if (a < b) {
                 for (i = a; i < b + 1; i++)
                 {

                     if (i % 3 == 0)
                         Console.WriteLine(i);
                 }
             }
             else
             {
                 Console.WriteLine("Podaj liczby od A do B");
             }*/

            //Silnia z liczby a
            /* 
              int a,i,c=1;
              Console.WriteLine("Podaj liczbe a");
              a = int.Parse(Console.ReadLine());

              if(a>0)
             {
                 for (i = 1; i<=a; i++)
                 {
                     c *= i;
                 }
                 Console.WriteLine(c);
            */
            Car e36 = new Car("BMW", 1993, 5, 1.8, 9);
            Console.WriteLine("Mój samochod jest marki {0}", e36.Marka);
            Console.WriteLine("Rok Produkcji {0}", e36.Rok);
            Console.WriteLine("Ilość drzwi {0}", e36.Ilosc_drzwi);
            Console.WriteLine("Pojemność Silnika {0}l", e36.Poj_silnika);
            Console.WriteLine("Średnie spalanie tego samochodu {0}", e36.Sr_spalanie);
            Console.WriteLine("Sredni Koszt przejazdu 100KM {0} to PLN", e36.oblicz_koszt_przejazdu(100, 4.44));
            Console.WriteLine(Car.opiszTyp(1,2));
            Console.WriteLine(Car.opiszTyp(1));
            Console.WriteLine(Car.opiszTyp("jakis napis"));
          

            Console.ReadKey();
        }
    }
}
