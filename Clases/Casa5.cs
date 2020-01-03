using System;
using System.Collections.Generic;
using System.Text;
using VentasDeCasa.Interfaz;

namespace VentasDeCasa.Clases
{
    class Casa5:ICasas
    {
        public void pisos()
        {
            Console.WriteLine("La casa es de un piso");
        }
        public void cuartos()
        {
            Console.WriteLine("La casa cuenta con 1 Habitaciones");
        }
        public void baños()
        {
            Console.WriteLine("En toda la casa hay un Baño   ");

        }
        public void cocina()
        {
            Console.WriteLine("En la casa encontrara una  Cocina  ");
        }
        public void garage()
        {
            Console.WriteLine("No Cuenta con garaje");
        }
    }
}
