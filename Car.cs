using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Car
    {
        private string marka;
        private int rok;
        private int ilosc_drzwi;
        private double poj_silnika;
        private double sr_spalanie;
        private static int ilosc_samochodow = 0;
        public Car() { }
        public Car(string marka, int rok, int drzwi, double pojemność_silnika, double sr_spalanie)
        {
            Marka = marka;
            Rok = rok;
            Ilosc_drzwi = drzwi;
            Poj_silnika = pojemność_silnika;
            Sr_spalanie = sr_spalanie;

        }
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        public int Rok
        {
            get { return rok; }
            set
            {
                if (value > 1880 && value < 2016) { rok = value; }
                else { Console.WriteLine("Rok niepoprawny! (Wymagany: 1880 - 2016, wprowadzony: {0})", value); }
            }
        }
        public int Ilosc_drzwi
        {
            get { return ilosc_drzwi; }
            set { ilosc_drzwi = value; }
        }
        public double Poj_silnika
        {
            get { return poj_silnika; }
            set { poj_silnika = value; }
        }
        public double Sr_spalanie
        {
            get { return sr_spalanie; }
            set { sr_spalanie = value; }
        }
        private double oblicz_spalanie(double dlugosc_trasy)
        {
            double spalanie = 0;

            spalanie = (sr_spalanie * dlugosc_trasy) / 100.0;
            return spalanie;
        }
        public double oblicz_koszt_przejazdu(double dlugosc_trasy, double cena_paliwa_za_litr)
        {
            double koszt_przejazdu = 0;
            koszt_przejazdu = oblicz_spalanie(dlugosc_trasy) * cena_paliwa_za_litr;
            return koszt_przejazdu;
        }
      
        public static int opiszTyp(int a,int b)
        {
            return a+b;
        }
        public static int opiszTyp(int a, int b,int c)
        {
            return a + b + c;
        }
        public static string opiszTyp(string napis)
        {
            return napis;
        }
        public static int opiszTyp(int a)
        {
            return a;
        }

    }
}
/// model , ilość drzwi, poj śilnika, Średnie spalanie ,diagram UML
/// utworzyć właściwości dostepowe do wszystkich pól w klasie car 
/// utworzyc w klasie car prywatnego statycznego pola typu int o nazwie ilosc samochodow przypisac mu wartosc 0
/// utworzyc prywatną metode oblicz spalanie zwracajaca wartość typu double i przyjmującej parametr dlugość trasy typu double 
/// -metoda ta ma obliczać spalanie samochodu na podstawie podanej wartosci dlugości 
/// -trasy i wartosci pola średniej spalania według wzoru spalanie=(srednieSPalanie*dlugosctrasy)/100.0
/// utworzyc publiczna metode oblicz koszt przejazdu zwracajacej wartosc typu double
/// i przyjmujacej parametry dlugosc trasy typu double i cena paliwa typu double metoda ta ma obliczac
/// -koszt przejazdu na trasie o podanej dlugosci zakładając podaną cene paliwa za 1Litr 
/// metoda ta ma wykożystywać prywatną metode oblicz spalanie koszt przejazdu oblicza sie wedlug wzoru 
/// -koszt przejazdu=spalanie *cena Paliwa;
/// zadanie stworzyc statyczna metode opisz typ ktora bedzie przeciarzona i 
/// bedzie zwracała przykladowe warosci typów w zaleznosci od rodzajów liczby argumentów 
/// git umieścić dowolny kod link z lekcji wysłać na maila kolev@matman.uwm.edu.pl