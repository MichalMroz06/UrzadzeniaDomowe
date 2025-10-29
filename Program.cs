using System;

namespace UrzadzeniaDomowe
{
    public class Narzedzia
    {
        public void wyswietlKomunikat(string text)
        {
            Console.WriteLine(text);
        }
    }

    public class Pralka : Narzedzia
    {
        private int numerPrania = 0;

        public void ustawNumerPrania(int value)
        {
            if (value >= 1 && value <= 12)
            {
                numerPrania = value;
            }
            else
            {
                numerPrania = 0;
            }
        }
    }

    public class Odkurzacz : Narzedzia
    {
        private bool stanOdkurzacza = false;

        public void on()
        {
            if (stanOdkurzacza == false)
            {
                stanOdkurzacza = true;
                wyswietlKomunikat("Odkurzacz włączony");
            }
        }

        public void off()
        {
            if (stanOdkurzacza == true)
            {
                stanOdkurzacza = false;
                wyswietlKomunikat("Odkurzacz wyłączono");
            }
        }
    }

internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}