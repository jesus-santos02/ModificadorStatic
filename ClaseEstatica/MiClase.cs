namespace ClaseEstatica
{
    public static class MiClase
    {
        private static int valor = 20;
        private static int numero;

        static MiClase()
        {
            numero = 33;
            System.Console.WriteLine("Saludos desde el constructor");
        }

        public static void SetValue(int value)
        {
            valor = value;
        }

        public static void SetNumber(int number)
        {
            numero = number;
        }
        public static void MostrarDatos()
        {
            System.Console.WriteLine($"Valor = {valor}, Numero = {numero}");
        }

    }
}