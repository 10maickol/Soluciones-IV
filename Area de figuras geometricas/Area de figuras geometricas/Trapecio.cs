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

        public Trapecio(string Nombre, double bmenor, double bmayor, double altura) : base(Nombre)
        {
            this.bmenor = bmenor;
            this.bmayor = bmayor;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            double area = 0;

            area = ((bmayor + bmenor) * altura) / 2;

            return area;
        }
    }
}
