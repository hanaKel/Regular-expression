﻿using System;
using System.Text.RegularExpressions;

namespace telSt
{
    internal class MobilePhoneNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi št :");
            string stevilka = Console.ReadLine();

            Regex vzorec = new Regex(@"(^[0][40,30,31,41,70, 68,51]{2}[0-9]{6})|(^[0][40,30,31,41,70, 68,51]{2}\s[0-9]{3}\s[0-9]{3})|(^[+][386]{3}\s[40,30,31,41,70, 68,51]{2}\s[0-9]{3}\s[0-9]{3})");


            Match ujemanje = vzorec.Match(stevilka);
            if (ujemanje.Success)            
            {
            Console.WriteLine(true);
            }
            else
            {
            Console.WriteLine(false);
            }
            
        }

    }

}
