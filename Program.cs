using System;
using VentasDeCasa.Clases;
using VentasDeCasa.Interfaz;


namespace VentasDeCasa
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int dinero;
            ICasas casas;
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("+++    Venta de Casas Alex     ++");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("Cuanto Dinero tienes para tu Casa");
            dato = Console.ReadLine();
            dinero = Convert.ToInt32(dato);

            //Obtener la casa de la fabrica
            casas = Creador.MetodoFabrica(dinero);
            casas.pisos();
            casas.cuartos();
            casas.cocina();
            casas.baños();
            casas.garage();

            Console.ReadKey();

        }
    }
}
