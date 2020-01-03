using System;
using VentasDeCasa.Interfaz;
using System.Collections.Generic;
using System.Text;

namespace VentasDeCasa
{
    class Casa1: ICasas
    {
        public void pisos()
        {
            Console.WriteLine("La casa es de un solo piso");
        }
        public void cuartos()
        {
            Console.WriteLine("La casa cuenta con 2 Habitaciones");
        }
        public void baños()
        {
            Console.WriteLine("En toda la casa hay un solo Baño");
        }
        public void cocina()
        {
            Console.WriteLine("En la casa encontrara una pequeña  Cocina");
        }
        public void garage()
        {
            Console.WriteLine("La casa no cuenta con garage");
        }

    }
}
