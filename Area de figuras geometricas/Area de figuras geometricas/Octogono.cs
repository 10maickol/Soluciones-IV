using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_figuras_geometricas
{
    public class Octogono : FiguraGeometrica
    {
        private double Lado;
        private double Radio;
        private bool isRadio;
        public Octogono(string Nombre,double Lado,bool isRadio) : base(Nombre)
        {
            this.Lado = isRadio ? 0 : Lado;
            Radio = isRadio ? Lado : 0;
            this.isRadio = isRadio;
        }

        public override double CalcularArea()
        {
            return 0;
           
        }
    }
}
