using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ2 {
    class Program {
        static void Main(string[] args) {
            for (int a = 2; a <= 16; a++) {
                if (a % 2 == 0) {
                    Console.WriteLine(a);
                }
            }
            for (int b = 15; b >= 5; b--) {
                if (b % 2 != 0) {
                    Console.WriteLine(b);
                }
            }
        }
    }
}
