using System;

namespace DrivingLicence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanuse;
            //kui kasutaja on noorem kui 18, siis kuvab programm konsoolis
            //"oled liiga noor, et juhilube saada";
            //kui kasutaja on vanem kui 18, siis kuvab programm konsoolis
            //"oled piisavalt vana, et juhilube saada";
            //kui kasutaja on 18, siis kuvab programm konsoolis
            //"palju õnne! Nüüd saad juhilube taotleda"

            Console.WriteLine("Palun sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            if(yearOfBirth > 2004)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada.");
            }
            else if(yearOfBirth < 2004)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada.");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd saad juhilube taotleda!");
            }
        }
    }
}
