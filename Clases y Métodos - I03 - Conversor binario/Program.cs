using System;

namespace Clases_y_Métodos___I03___Conversor_binario
{
        /* ALEJANDRO ALBERTO MARTÍN ROZAS
         * Ejercicio I03 - Conversor binario
         * Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):
         * El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario:
         * public string ConvertirDecimalABinario(int numeroEntero) {}
         * El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.
         * public int ConvertirBinarioADecimal(int numeroEntero) {}
         * IMPORTANTE
         * NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.
         */
    internal class Program
    {
        static void Main(string[] args)
        {
            Conversor.ConvertirDecimalABinario(1000);
        }
    }
}
