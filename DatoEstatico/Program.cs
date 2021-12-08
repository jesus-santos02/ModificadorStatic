using System;

namespace DatoEstatico
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos tres instancias
            MiClase obj1 = new MiClase();
            MiClase obj2 = new MiClase();
            MiClase obj3 = new MiClase();

            System.Console.WriteLine("Imprimimos antes de los cambios");
            obj1.MostrarDatos();
            obj2.MostrarDatos();
            obj3.MostrarDatos();

            //Cambiamos datos e imprimimos
            obj1.SetValue(3);
            obj2.SetValue(57);
            obj3.SetValue(140);
            System.Console.WriteLine("Imprimimos con cambios a valor");
            obj1.MostrarDatos();
            obj2.MostrarDatos();
            obj3.MostrarDatos();

            //Cambiamos el numero solo en un objeto
            obj2.SetNumber(300);
            System.Console.WriteLine("Imprimimos con cambio a numero");
            obj1.MostrarDatos();
            obj2.MostrarDatos();
            obj3.MostrarDatos();
        }
    }
}
