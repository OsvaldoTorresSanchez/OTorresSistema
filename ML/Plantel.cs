using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Plantel
    {

        public int IdPlantel{ get; set; }

        public string Nombre { get; set; }

        public ML.Sistema Sistema { get; set; }
        public List<object> Planteles { get; set; }
    }
}
