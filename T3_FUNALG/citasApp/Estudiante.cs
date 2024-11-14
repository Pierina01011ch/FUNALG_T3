using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citasApp
{
    public class Estudiante
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Universidad { get; set; }

        public override string ToString()
        {
            return $"{Nombre} ({Codigo}), Universidad: {Universidad}";
        }
    }
}