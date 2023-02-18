using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsincronaS4.Entidades;


namespace AsincronaS4.Negocio
{

    public class ClsVariables
    {
       
        public int contador (Variables variables){
            int numero = Convert.ToInt32(variables.Numero);
            return numero;

        }
    }
}