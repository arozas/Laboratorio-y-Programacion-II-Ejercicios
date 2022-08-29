using System;

namespace Biblioteca_UTN
{
    public class Validador
    {
        /// <summary>
        /// Valida que el valor ingresado se encuentre entre el rango establecido.
        /// </summary>
        /// <param name="valor">El valor a validar.</param>
        /// <param name="min">El rango mínimo.</param>
        /// <param name="max">El rango máximo.</param>
        /// <returns>Retorna un valor bool, "true" en el caso que el valor este en rango, "false" en caso que el valor no esté en el rango. </returns>
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno = false;
            if (valor > min && valor < max)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Valida que el valor ingresado se encuentre entre el rango establecido.
        /// </summary>
        /// <param name="valor">El valor a validar.</param>
        /// <param name="min">El rango mínimo.</param>
        /// <param name="max">El rango máximo.</param>
        /// <returns>Retorna un valor bool, "true" en el caso que el valor este en rango, "false" en caso que el valor no esté en el rango. </returns>
        public static bool Validar(ulong valor, ulong min, ulong max)
        {
            bool retorno = false;
            if (valor > min && valor < max)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Metodo que valida respuesta por el usuario por si o no.
        /// El enunciado del ejericio solicita que si no se preciona S se valide como respuesta negativa
        /// creo que para evitar errores o ingresos voluntario validar que aprete la tecla N.
        /// Por eso me desvié del enunciado.
        /// </summary>
        /// <param name="pregunta"> String conteniendo la pregunta a validar por si o no.</param>
        /// <returns>Retorna "true" en caso afirmativo, Retorna "false" en caso negativo.</returns>
        public static bool ValidarRespuesta(string pregunta)
        {
            bool retorno = false;
            ConsoleKeyInfo respuestaIngresada;
            do
            {
                Console.WriteLine($"\n{pregunta}");
                Console.WriteLine("<S/N>:");
                respuestaIngresada = Console.ReadKey();
                if (respuestaIngresada.Key == ConsoleKey.S)
                {
                    retorno = true;
                    Console.WriteLine("");
                }
                else if (respuestaIngresada.Key == ConsoleKey.N)
                {
                    retorno = false;
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("\nERROR, DEBE INGRESAR UNA RESPUESTA <S/N>");
                }
            } while (respuestaIngresada.Key is not (ConsoleKey.S or ConsoleKey.N));

            return retorno;
        }
        /// <summary>
        /// Valida que el valor ingresado sea un numero de tipo int y que no sea empty o null.
        /// </summary>
        /// <param name="valorString">String donde se guarda el valor ingresado por el enunciado</param>
        /// <param name="valor">Variable donde se devuelve el valor ingresado en el string en el caso que el parseo sea exitoso.</param>
        /// <returns>retorna "true" en el caso que el valor sea del tipo int, si no retorna "false"</returns>
        public static bool EsNumero(string valorString, out int valor)
        {
            int auxiliar = 0;
            bool retorno = !string.IsNullOrEmpty(valorString) && int.TryParse(valorString, out auxiliar);
            valor = auxiliar;
            return retorno;
        }
        /// <summary>
        /// Valida que el valor ingresado sea un numero de tipo float y que no sea empty o null.
        /// </summary>
        /// <param name="valorString">String donde se guarda el valor ingresado por el enunciado</param>
        /// <param name="valor">Variable donde se devuelve el valor ingresado en el string en el caso que el parseo sea exitoso.</param>
        /// <returns>retorna "true" en el caso que el valor sea del tipo float, si no retorna "false"</returns>
        public static bool EsNumero(string valorString, out float valor)
        {
            float auxiliar = 0;
            bool retorno = !string.IsNullOrEmpty(valorString) && float.TryParse(valorString, out auxiliar);
            valor = auxiliar;
            return retorno;
        }
        /// <summary>
        /// Valida que el valor ingresado sea un numero de tipo double y que no sea empty o null.
        /// </summary>
        /// <param name="valorString">String donde se guarda el valor ingresado por el enunciado</param>
        /// <param name="valor">Variable donde se devuelve el valor ingresado en el string en el caso que el parseo sea exitoso.</param>
        /// <returns>retorna "true" en el caso que el valor sea del tipo double, si no retorna "false"</returns>
        public static bool EsNumero(string valorString, out double valor)
        {
            double auxiliar = 0;
            bool retorno = !string.IsNullOrEmpty(valorString) && double.TryParse(valorString, out auxiliar);
            valor = auxiliar;
            return retorno;
        }
        /// <summary>
        /// Valida que el valor ingresado sea un numero de tipo long y que no sea empty o null.
        /// </summary>
        /// <param name="valorString">String donde se guarda el valor ingresado por el enunciado</param>
        /// <param name="valor">Variable donde se devuelve el valor ingresado en el string en el caso que el parseo sea exitoso.</param>
        /// <returns>retorna "true" en el caso que el valor sea del tipo long, si no retorna "false"</returns>
        public static bool EsNumero(string valorString, out long valor)
        {
            long auxiliar = 0;
            bool retorno = !string.IsNullOrEmpty(valorString) && long.TryParse(valorString, out auxiliar);
            valor = auxiliar;
            return retorno;
        }
        /// <summary>
        /// Valida que el valor ingresado sea un numero de tipo ulong y que no sea empty o null.
        /// </summary>
        /// <param name="valorString">String donde se guarda el valor ingresado por el enunciado</param>
        /// <param name="valor">Variable donde se devuelve el valor ingresado en el string en el caso que el parseo sea exitoso.</param>
        /// <returns>retorna "true" en el caso que el valor sea del tipo ulong, si no retorna "false"</returns>
        public static bool EsNumero(string valorString, out ulong valor)
        {
            ulong auxiliar = 0;
            bool retorno = !string.IsNullOrEmpty(valorString) && ulong.TryParse(valorString, out auxiliar);
            valor = auxiliar;
            return retorno;
        }
        /// <summary>
        /// Valida que el valor ingresado sea una fecha.
        /// </summary>
        /// <param name="valorString">El string a intentar validar que sea una fecha</param>
        /// <param name="valor">El valor devuelto en caso de un parseo exitoso.</param>
        /// <returns>retorna "true" en el caso que el valor sea una fecha, de lo contrario retorna "false".</returns>
        public static bool EsFecha(string valorString, out DateTime valor)
        {
            DateTime auxiliar = new DateTime();
            bool retorno = !string.IsNullOrEmpty(valorString) && DateTime.TryParse(valorString, out auxiliar);
            valor = auxiliar;
            return retorno;
        }
    }
}
