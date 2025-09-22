using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ5 {
    class Program {
        static void Main(string[] args) {
            string textoIngresado = "";
            string textoDecodificado = "";
            string[] codigos = { "01",      // A
                                 "1000",    // B
                                 "1010",    // C
                                 "100",     // D
                                 "0",       // E
                                 "0010",    // F
                                 "110",     // G
                                 "0000",    // H
                                 "00",      // I
                                 "0111",    // J
                                 "101",     // K
                                 "0100",    // L
                                 "11",      // M
                                 "10",      // N
                                 "111",     // O
                                 "0110",    // P
                                 "1101",    // Q
                                 "010",     // R
                                 "000",     // S
                                 "1",       // T
                                 "001",     // U
                                 "0001",    // V
                                 "011",     // W
                                 "1001",    // X
                                 "1011",    // Y
                                 "1100",    // Z
                                 "01111",   // 1
                                 "00111",   // 2
                                 "00011",   // 3
                                 "00001",   // 4
                                 "00000",   // 5
                                 "10000",   // 6
                                 "11000",   // 7
                                 "11100",   // 8
                                 "11110",   // 9
                                 "11111"};  // 0
            do {
                textoIngresado = Console.ReadLine();

                if (textoIngresado.Length < 2) { continue; }
                if ((textoIngresado[0] != 'X') && (textoIngresado[0] != 'x')) { continue; }
                if (textoIngresado[textoIngresado.Length-1] != '/') { continue; }
                if (textoIngresado.Substring(1, textoIngresado.Length - 2) == "") { break; }
                if (textoIngresado.Substring(1, textoIngresado.Length - 2) == " ") {
                    // espacio
                    textoDecodificado = textoDecodificado + " ";
                }

                string codigoIngresado = textoIngresado.Substring(1, textoIngresado.Length - 2);

                for (int a = 0; a < codigos.Length; a++) {
                    if (codigos[a] == codigoIngresado) {
                        if (a < 26) {
                            textoDecodificado = textoDecodificado + (char)('A' + a);
                        } else {
                            textoDecodificado = textoDecodificado + (char)('0' + (a - 26));
                        }
                    }
                }
            } while(true);
            Console.WriteLine(textoDecodificado);
        }
    }
}
