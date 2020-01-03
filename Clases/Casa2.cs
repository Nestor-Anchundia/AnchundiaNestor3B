using System;
using System.Collections.Generic;
using System.Text;
using VentasDeCasa.Interfaz;
namespace VentasDeCasa.Clases
{
    class Casa2:ICasas 
    {
        public void pisos()
        {
            Console.WriteLine("La casa es de un solo piso");
        }
        public void cuartos()
        {
            Console.WriteLine("La casa cuenta con 3 Habitaciones");
        }
        public void baños()
        {
            Console.WriteLine("En toda la casa hay un Baño en la habitacion principal " +
                "Y otro entre la cocina y una de las habitaciones ");

        }
        public void cocina()
        {
            Console.WriteLine("En la casa encontrara una media  Cocina");
        }
        public void garage ()
        {
            Console.WriteLine("Ela casa cuenta con un garage para un solo vehiculo");
        }
    }
}
