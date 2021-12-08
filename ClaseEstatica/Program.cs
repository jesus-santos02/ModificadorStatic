using System;

namespace ClaseEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            //No se puede crear una instancia de la clase
            //MiClase obj = new MiClase();

            System.Console.WriteLine("Sin cambio");
            MiClase.MostrarDatos();

            //Cambiamos
            MiClase.SetValue(400);
            MiClase.SetNumber(555);
            System.Console.WriteLine("Con cambios");
            MiClase.MostrarDatos();

        }
    }
}
