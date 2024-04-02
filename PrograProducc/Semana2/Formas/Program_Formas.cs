using PrograProducc.Semana2.Formas;

namespace PrograProducc.Semana2.Formas 
{
    class Program
    {
        static void Main(string[] args)
        {
            bool terminar = false;

            while (!terminar)
            {
                Console.WriteLine("Elija la figura para calcular el área:");
                Console.WriteLine("1. Rectángulo");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Círculo");
                Console.WriteLine("4. Triángulo");
                Console.WriteLine("5. Terminar");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese la base del rectángulo:");
                        double baseRectangulo = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura del rectángulo:");
                        double alturaRectangulo = double.Parse(Console.ReadLine());
                        Rectangulo rectangulo = new Rectangulo(baseRectangulo, alturaRectangulo);
                        Console.WriteLine("El área del rectángulo es: " + rectangulo.CalcularArea());
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el lado del cuadrado:");
                        double ladoCuadrado = double.Parse(Console.ReadLine());
                        Cuadrado cuadrado = new Cuadrado(ladoCuadrado);
                        Console.WriteLine("El área del cuadrado es: " + cuadrado.CalcularArea());
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el radio del círculo:");
                        double radioCirculo = double.Parse(Console.ReadLine());
                        Circulo circulo = new Circulo(radioCirculo);
                        Console.WriteLine("El área del círculo es: " + circulo.CalcularArea());
                        break;

                    case 4:
                        Console.WriteLine("Ingrese la base del triángulo:");
                        double baseTriangulo = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura del triángulo:");
                        double alturaTriangulo = double.Parse(Console.ReadLine());
                        Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo);
                        Console.WriteLine("El área del triángulo es: " + triangulo.CalcularArea());
                        break;

                    case 5:
                        terminar = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}