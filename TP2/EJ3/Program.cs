using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ3 {
    class Program {
        static void Main(string[] args) {
            bool clientePremium = false;
            float montoCompra;

            Console.Write("Cliente premium? (S/N): ");
            clientePremium = Console.ReadLine().ToUpper() == "S" ? true : false;
            
            Console.Write("Ingrese el monto de compra: ");
            montoCompra = Convert.ToSingle(Console.ReadLine());

            if (clientePremium) {
                if (montoCompra >= 150.0F) {
                    montoCompra = montoCompra - ((montoCompra * 25.0F) / 100.0F);
                }
            } else {
                if (montoCompra >= 300.0F) {
                    montoCompra = montoCompra - ((montoCompra * 15.0F) / 100.0F);
                }
            }
            Console.WriteLine("Monto final: $" + montoCompra);
        }
    }
}
