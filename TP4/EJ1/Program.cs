using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Caracter\tASCII\tBinario");

            for (char a = 'a'; a <= 'z'; a++) {
                Console.WriteLine(a + "\t\t" + (int)a + "\t" + Convert.ToString(a, 2));
            }
        }
    }
}
