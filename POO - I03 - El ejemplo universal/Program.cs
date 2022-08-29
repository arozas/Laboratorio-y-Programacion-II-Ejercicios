using System;
using Biblioteca_UTN;

namespace POO___I03___El_ejemplo_universal
{
    /*ALEJANDRO ALBERTO MARTÍN ROZAS
   * Ejercicio I03 - El ejemplo universal
   * El enunciado pide que 2 alumnos figuren aprobados y 1 desaprobado, pero estoy jugando con los aleatorios y con cada "run" al programa genera un resultado distinto.
   */
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante[] estudiantes = new Estudiante[3];
            for (int i = 0; i < estudiantes.Length; i++)
            {
                estudiantes[i] = new Estudiante($"{GeneradorDeDatos.GenerarNombreAleatorio()}", $"{GeneradorDeDatos.GenerarApellidoAleatorio()}", $"{Convert.ToString(GeneradorDeDatos.GenerarNumeroAleatorio(30000000, 50000000))}");
                estudiantes[i].SetNotaPrimerPacial = GeneradorDeDatos.GenerarNumeroAleatorio(1, 10);
                estudiantes[i].SetNotaSegundoParcial = GeneradorDeDatos.GenerarNumeroAleatorio(1, 10);
                Console.WriteLine(estudiantes[i].Mostrar());
            }

        }
    }
}
