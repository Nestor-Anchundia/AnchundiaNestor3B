using System;
using System.Collections.Generic;
using System.Text;
using VentasDeCasa.Interfaz;


namespace VentasDeCasa.Clases
{
    class Casa4:ICasas
    {
        public void pisos()
        {
            Console.WriteLine("La casa es de dos piso");
        }
        public void cuartos()
        {
            Console.WriteLine("La casa cuenta con 3 Habitaciones");
        }
        public void baños()
        {
            Console.WriteLine("En toda la casa hay un Baño por habitacion  " +
                "Y otro en el garage ");

        }
        public void cocina()
        {
            Console.WriteLine("En la casa encontrara dos Cocina" +
                "En el primer piso una cocina y en el segundo piso otra cocina");
        }
        public void garage()
        {
            Console.WriteLine("Ela casa cuenta con un garaje para varios vehiculo");
        }
    }
}
