using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_UTN
{
    public class Cuenta
    {
        private string cuenta;
        private decimal cantidad;
        /// <summary>
        /// Constructor de la clase Cuenta.
        /// </summary>
        /// <param name="cuenta">Da valor al atributo string cuenta</param>
        /// <param name="cantidad">Da valor al atributo decimal cantidad</param>
        public Cuenta(string cuenta, decimal cantidad)
        {
            this.cuenta = cuenta;
            this.cantidad = cantidad;
        }
        /// <summary>
        /// Obtiene el valor del atributo string cuenta.
        /// </summary>
        /// <returns>Devuelve un valor string.</returns>
        public string GetCuenta()
        {
            return cuenta;
        }
        /// <summary>
        /// Obtiene el valor del atributo decimal cantidad.
        /// </summary>
        /// <returns>Devuelve un valor decimal.</returns>
        public decimal GetCantidad()
        { 
            return cantidad;
        }
        /// <summary>
        /// Retorna un valor string con los datos de la cuenta.
        /// </summary>
        /// <returns>Devuelve un valor string.</returns>
        public string Mostrar()
        {
            return ($"CUENTA: {cuenta}\nSALDO: {cantidad:C2}");
        }
        /// <summary>
        /// Adiciona un valor positivo al atributo cantidad.
        /// </summary>
        /// <param name="ingreso">Valor decimal a sumar al atributo cantidad.</param>
        /// <returns>Retorna un valor "true" en caso que se haya realizado la operación con exito, de caso contrario retorna un valor "false".</returns>
        public bool Ingresar(decimal ingreso)
        {
            bool retorno = false;
            if (ingreso > 0)
            {
                cantidad += ingreso;
                retorno = true; 
            }
            return retorno;
        }
        /// <summary>
        /// Resta un valor positivo al atributo cantidad.
        /// </summary>
        /// <param name="retiro">Valor decimal a restar al atributo cantidad.</param>
        /// <returns>Retorna un valor "true" en caso que se haya realizado la operación con exito, de caso contrario retorna un valor "false".</returns>
        public bool Retirar(decimal retiro)
        {
            bool retorno = false;
            if (retiro > 0)
            {
                cantidad -= retiro;
                retorno = true;
            }
            return retorno;
        }
    }
}
