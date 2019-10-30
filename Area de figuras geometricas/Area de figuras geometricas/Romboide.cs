using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_figuras_geometricas
{
    class Romboide : FiguraGeometrica
    {
        private double Lado;
        private double altura;

        public Romboide(string Nombre, double lado, double altura) : base(Nombre)
        {
            this.Lado = lado;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            double area = 0;
            area = Lado * altura;
            return area;
        }

    }
}
