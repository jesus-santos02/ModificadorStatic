namespace EstaticoEnConstructor
{
    public class MiClase
    {
        private int valor;
        private static int numero;

        public MiClase()
        {
            valor = 20;
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