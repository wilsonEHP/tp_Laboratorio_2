﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException:Exception
    {
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        public SinProfesorException() : base("No hay Profesor para la clase.")
        {

        }

        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="mensaje"></param>
        public SinProfesorException(string mensaje) : base(mensaje)
        {

        }
    }
}
