namespace DatoEstatico
{
    public class MiClase
    {
        private int valor = 50;
        private static int numero = 10;

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