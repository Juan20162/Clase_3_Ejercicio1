
class Ejercicio1
{

    static public void Main()
    {
        nombre();
        numero();
        dirreccion();
        Email();
        cliente();

        void nombre()
        {
            Console.WriteLine("Introduce tu nombre completo: ");
            string Nombre = Console.ReadLine();
        }
        void numero()

        {
            Console.WriteLine("Introduce tu numero telefonico: ");
            double Numero = Convert.ToDouble(Console.ReadLine());

        }
        void dirreccion()
        {
            Console.WriteLine("Introduce tu dirreccion: ");
            string Dirreccion = Console.ReadLine();
        }
        void Email()
        {
            Console.WriteLine("Introduce tu Email: ");
            string Email = Console.ReadLine();
        }
        void cliente()
        {
            Console.WriteLine("Eres nuevo cliente: ");
            string Cliente = Console.ReadLine();
        }

    }
}