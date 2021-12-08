using System;

namespace MetodoEstatico
{
    class Program
    {
        static void Main(string[] args)
        {
            //No puede invocar el metodo saludar sin una instancia, marca error
            //MiClase.Saludar();

            //De esta forma sí funciona
            MiClase obj = new MiClase();
            obj.Saludar();

            //Un metodo estatico sí puede ser invocado sin instancia
            MiClase.Mensaje();
            MiClase.ImprimeNumero();
        }
    }
}
