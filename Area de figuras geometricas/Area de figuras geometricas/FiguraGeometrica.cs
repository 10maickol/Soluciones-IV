using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_figuras_geometricas
{
    public abstract class FiguraGeometrica
    {
        String Nombre;
        public FiguraGeometrica(String Nombre)
        {
            this.Nombre = Nombre;
        }
        
        public abstract double CalcularArea();

        public String getNombre()
        {
            return Nombre;
        }

        public override String ToString()
        {
            return "Esta figura es un: "+ Nombre;

        }

    }
}
