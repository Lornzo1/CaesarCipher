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
        static void Main(string[] args)
        {
            Console.WriteLine(DeCoder(Coder("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG", 3),3));
        }
    }
}
