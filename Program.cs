using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
          
            

            MyDictionarys<int, string> isimler = new MyDictionarys<int, string>();
            isimler.Add(1, "Taha");
            isimler.Add(2, "Ali");
            isimler.Add(3, "Hasan");
            isimler.Add(4, "Yücel");
            Console.WriteLine(isimler.Count);
            foreach (var isim in isimler.Values)
            {
                Console.WriteLine(isim);
            }
            
            Console.ReadLine();
        }
    }
}
