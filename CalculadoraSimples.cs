namespace NUnitCalculadora
{
    public class CalculadoraSimples
    {
        /* Método para Adicionar 2 números */
        public int Adicionar(int numero1, int numero2)
        {
            return (numero1 + numero2);
        }
        public int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
        public int Multiplicar(int numero1, int numero2)
        {
            return (numero1 * numero2);
        }
        public double Dividir(double numero1, double numero2)
        {
            return (numero1 / numero2);
        }
    }
}