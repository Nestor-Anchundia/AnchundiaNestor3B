using System;
using System.Collections.Generic;
using System.Text;
using VentasDeCasa.Interfaz;
namespace VentasDeCasa.Clases
{
    class Creador
        //aqui se va a crear la fabrica 
    {
       
        public static ICasas MetodoFabrica(int Dinero)

        {
            ICasas temp = null;

            if (Dinero >= 40000)
                temp = new Casa4();
            else
                if (Dinero >= 30000)
                temp = new Casa3();
            else
                if (Dinero >= 20000)
                temp = new Casa2();
            else
                if (Dinero >= 10000)
                temp = new Casa1();
            else
                if (Dinero >= 5000)
                temp = new Casa5();
            else
                temp = new nel();
            

            return temp;

        }
    }
}
