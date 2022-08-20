using System;
using System.Text.RegularExpressions;

namespace Email
{
    internal class ValidEmail
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Vnesi e-mail :");
        string email = Console.ReadLine();
            Regex vzorec = new Regex(@"(^[a-z]{2}[0-9]{4}\@student[.]uni[-]lj[.]si)|([a-z]{6,}[.]{0,}[@]gmail[.]com)||([a-z]{6,}[.]{0,}[@]student[.]uni[-]lj[.]si)");
            Match ujemanje = vzorec.Match(email);
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
