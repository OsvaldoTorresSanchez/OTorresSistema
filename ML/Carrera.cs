﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Carrera
    {
        public int IdCarrera { get; set; }

        public string Nombre { get; set; }
        
        public ML.Plantel Plantel { get; set; }

        public List<object> Carreras { get; set; }
    }
}
