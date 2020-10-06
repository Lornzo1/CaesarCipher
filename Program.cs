using System;
using System.Text;
namespace Trial
{
    class Program
    {
        static string Coder(string a, int s)
        {
            string a2 = "";
            byte[] asciiBytes = Encoding.ASCII.GetBytes(a);
            foreach (int i in a)
            {
                if (i == ' ') { a2 += " "; }
                else if (90 - i - s < 0) { a2 += (Char)(-26 + i + s); }
                else if (i + s < 65) { a2 += (Char)(26 + i + s); }
                else { a2 += (Char)(i + s); }
            }
            return a2;
        }
        static string DeCoder(string a, int s)
        {
            return Coder(a, -s);
        }
        static string Vingere(string a, string key)
        {
            string OrigKey = key;
            int y = 0;
            for (int i = 0; a.Length != key.Length; i++)
            {
                if (a[key.Length] == ' ') { key += " ";
                    Console.WriteLine("hi");
                    y += 1;
                }
                else { key += OrigKey[(i-y)%3]; }
            }
            int n = 0;
            foreach (char t in a)
            {
                Console.WriteLine(Coder(Char.ToString(t),(char) key[n]-65));
                n += 1;
            }
            return "done";
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(DeCoder(Coder("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG", 3),3));
            Console.WriteLine(Vingere("MATHS IS FUN", "KEY"));
        }
    }
}
