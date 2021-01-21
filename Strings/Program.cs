using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Gürkan Altunok";

            var  result1 = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Oğuz Altunok";

            bool result3 = sentence.EndsWith("k");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("name"); //Metnin baştan kaçıncı karakterden sonra başladığını söyler eğer bulamazsa -1 gönderir.
            var result6 = sentence.IndexOf(" "); //Bulduğu ilk boşluğu sayar
            var result7 = sentence.LastIndexOf(" "); //Aramaya sondan başlar baştan kaçıncı karakter olduğunu söyler.
            var result8 = sentence.Insert(0, "Hello, "); //Cümlenin 0. Karakterinden itibaren "Hello, " ekle.
            var result9 = sentence.Substring(3,4); //3. karakterden itibaren 4 karakter böl.
            var result10 = sentence.ToLower(); //Tüm karakterleri küçük harfe çevirir.
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ", "-");
            var result13 = sentence.Remove(2,4); //2. karakterden itibaren 4 karakter sil.


            Console.WriteLine(result9);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
