using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_figuras_geometricas
{
    public class Trapecio : FiguraGeometrica
    {
        private double bmenor;
        private double bmayor;
        private double altura;

        public Trapecio(string Nombre) : base(Nombre)
        {
        }

        public override double CalcularArea()
        {
            throw new NotImplementedException();
        }
    }
}
