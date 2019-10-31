using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_figuras_geometricas
{
    public class Trapecio : FiguraGeometrica
    {
        private double h;
        private double a;
        private double b;
        public Trapecio(string Nombre,double h,double a,double b) : base(Nombre)
        {
            this.h = h;
            this.a = a;
            this.b = b;
        }

        public override double CalcularArea()
        {
            return (h * ((a+b)/2));
        }
    }
}
