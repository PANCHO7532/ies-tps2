using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ4 {
    class Program {
        static void ordenarNumeros(int num1, int num2, int num3) {
            int _num1 = num1, _num2 = num1, _num3 = num1;
            // 1
            if (num2 < num1) { _num1 = num2; }
            if (num3 < num1) { _num1 = num3; }
            // 3
            if (num2 > num1) { _num3 = num2; }
            if (num3 > num1) { _num3 = num3; }
            // 2
            /// Si num1 es el del medio
            if (num1 > num2 && num1 < num3) { _num2 = num1; }
            if (num1 < num2 && num1 > num3) { _num2 = num1; }
            /// Si num2 es el del medio
            if (num2 > num1 && num2 < num3) { _num2 = num2; }
            if (num2 < num1 && num2 > num3) { _num2 = num2; }
            /// Si num3 es el del medio
            if (num3 > num1 && num3 < num2) { _num2 = num3; }
            if (num3 < num1 && num3 > num2) { _num2 = num3; }

            Console.WriteLine(_num1);
            Console.WriteLine(_num2);
            Console.WriteLine(_num3);
        }
        static void Main(string[] args) {
            int num1, num2, num3;

            Console.Write("Ingrese primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese tercer numero: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            ordenarNumeros(num1, num2, num3);
        }
    }
}
