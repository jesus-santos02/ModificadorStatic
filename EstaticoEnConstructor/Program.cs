using System;

namespace EstaticoEnConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos dos instancias
            MiClase obj1 = new MiClase();
            MiClase obj2 = new MiClase();        

            System.Console.WriteLine("Sin cambios");
            obj1.MostrarDatos();
            obj2.MostrarDatos();

            //Cambiamos
            obj1.SetValue(400);
            obj2.SetNumber(555);
            System.Console.WriteLine("Imprimimos con cambios");
            obj1.MostrarDatos();
            obj2.MostrarDatos();

            //Creamos otra instancia
            //Se resetea el datos estatico
            MiClase obj3 = new MiClase();
            System.Console.WriteLine("Despues de la instancia");
            obj1.MostrarDatos();
            obj2.MostrarDatos();
            obj3.MostrarDatos();
        }
    }
}
