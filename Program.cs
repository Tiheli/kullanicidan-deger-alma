using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kullanicidan_deger_alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim;
            Console.WriteLine(" isim giriniz.. ");
            isim= Console.ReadLine();
            Console.WriteLine("merhaba, {" + isim + "}");
            Console.ReadKey();
        }

    }
}
