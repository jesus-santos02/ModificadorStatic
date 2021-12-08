namespace ConstructorEstatico
{
    public class MiClase
    {
        private int valor = 20;
        private static int numero;

        static MiClase()
        {
            numero = 33;
            System.Console.WriteLine("Saludos desde el constructor");
        }

        public void SetValue(int valor)
        {
            this.valor = valor;
        }

        public void SetNumber(int number)
        {
            numero = number;
        }
        public void MostrarDatos()
        {
            System.Console.WriteLine($"Valor = {valor}, Numero = {numero}");
        }

    }
}