﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Grupo
    {
        public int IdGrupo{ get; set; }

        public string Nombre { get; set; }

        public string Cantidad { get; set; }

        public ML.Carrera Carrera { get; set; }

        public List<object> Grupos { get; set; }
    }
}
