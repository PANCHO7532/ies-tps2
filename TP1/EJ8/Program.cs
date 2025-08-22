using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ8 {
    class Program {
        static void Main(string[] args) {
            const float PI = 3.1416F;
            float radio, resultadoArea;

            Console.Write("Ingrese el radio del circulo: ");
            radio = Convert.ToSingle(Console.ReadLine());

            resultadoArea = PI * (radio * radio);

            Console.WriteLine("El area del circulo es: " + resultadoArea);
        }
    }
}
