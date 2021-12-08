namespace MetodoEstatico
{
    public class MiClase
    {
        private int valor = 50;
        private static int numero = 10;

        public void Saludar()
        {
            System.Console.WriteLine("Solo saludo si hay una instancia de la clase");
        }

        public static void Mensaje()
        {
            System.Console.WriteLine("Puedo dar el mensaje aún sin instancia");
        }

        //El metodo estatico no puede usar un valor normal
        /*public static void ImprimeValor()
        {
            System.Console.WriteLine($"El valor es {valor}");
        }*/

        //Un metodo estatico permite un dato estatico, ya que tiene vida aún sin la instancia de la clase
        public static void ImprimeNumero()
        {
            System.Console.WriteLine($"El numero es {numero}");
        }

    }
}