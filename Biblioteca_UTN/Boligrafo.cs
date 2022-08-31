using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_UTN
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        /// <summary>
        /// Constructor del objeto Boligrafo.
        /// </summary>
        /// <param name="color"></param>
        /// <param name="tinta"></param>
        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor { get => color; }
        public short GetTinta { get => tinta; }
        /// <summary>
        /// Setter tinta, cambia el valor del atributo tinta.
        /// </summary>
        /// <param name="value"></param>
        private short SetTinta
        {
            set
            {
                if (value > 0 && GetTinta < cantidadTintaMaxima && GetTinta >= 0)
                {
                    tinta += value;
                    if (GetTinta > cantidadTintaMaxima)
                    {
                        tinta = 100;
                    }
                }
                else
                {
                    if (value < 0 && GetTinta > 0)
                    {
                        tinta += value;
                        if (GetTinta < 0)
                        {
                            tinta = 0;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Setea el valor tinta a su maximo.
        /// </summary>
        public void Recargar()
        { 
            SetTinta=100;
        }
        /// <summary>
        /// Devuelve una cantidad de astericos del color del boligrafo igual al valor ingresado o al maximo de su tinta.
        /// </summary>
        /// <param name="gasto"></param>
        /// <param name="dibujo"></param>
        /// <returns>Devuleve un valor string</returns>
        public bool Pintar(short gasto,out string dibujo)
        {
            bool retorno = false;
            StringBuilder auxiliarDibujo = new StringBuilder(" ");
            if (GetTinta > 0 && gasto < 0)
            {
                if (GetTinta > (gasto * -1))
                {
                    for (int i = 0; i < (gasto * -1); i++)
                    {
                        auxiliarDibujo.Append("*");
                    }
                    Console.ForegroundColor = GetColor;
                    SetTinta=gasto;
                    retorno = true;
                }
                else
                {
                    for (int i = 0; i < GetTinta; i++)
                    {
                        auxiliarDibujo.Append("*");
                    }
                    Console.ForegroundColor = GetColor;
                    SetTinta=gasto;
                    retorno = true;
                }
            }
            dibujo = auxiliarDibujo.ToString();
            return retorno;
        }
        /// <summary>
        /// Devuelve un mensaje string del color del boligrafo igual al valor ingresado o al maximo de su tinta.
        /// </summary>
        /// <param name="gasto"></param>
        /// <param name="mensaje"></param>
        /// <param name="dibujo"></param>
        /// <returns></returns>
        public bool Pintar(short gasto, string mensaje, out string dibujo)
        {
            bool retorno = false;
            StringBuilder auxiliarDibujo = new StringBuilder(" ", 100);
            StringBuilder auxiliarMensaje = new StringBuilder(mensaje);
            if (GetTinta > 0 && gasto < 0)
            {
                if (GetTinta > (gasto * -1))
                {
                    for (int i = 0; i < (gasto * -1); i++)
                    {
                        auxiliarDibujo.Append(auxiliarMensaje[i]);
                    }
                    Console.ForegroundColor = GetColor;
                    SetTinta=gasto;
                    retorno = true;
                }
                else
                {
                    for (int i = 0; i < GetTinta; i++)
                    {
                        auxiliarDibujo.Append(auxiliarMensaje[i]);
                    }
                    Console.ForegroundColor = GetColor;
                    SetTinta=gasto;
                    retorno = true;
                }
                
            }
            dibujo = auxiliarDibujo.ToString();
            return retorno;
        }
    }
}
