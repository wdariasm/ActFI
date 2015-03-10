﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EPolizas
    {
        public string nPoliza { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFinal { get; set; }
        public string empresa { get; set; }
        public string responsable { get; set; } // Agente de Contacto
        public string telefono { get; set; }  // Telefono de Contacto
        public double deducible { get; set; } 
        public double valor { get; set; } // Valor asegurado
    }
}
