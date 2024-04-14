using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograProducc.Semana2.ArmasInventario
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();

            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Agregar arma");
                Console.WriteLine("2. Mostrar armas en el inventario");
                Console.WriteLine("3. Eliminar arma del inventario");
                Console.WriteLine("4. Salir");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarArma(inventario);
                        break;
                    case 2:
                        inventario.MostrarArmas();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el nombre del arma que desea eliminar:");
                        string nombreArmaEliminar = Console.ReadLine();
                        inventario.EliminarArma(nombreArmaEliminar);
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void AgregarArma(Inventario inventario)
        {
            Console.WriteLine("Ingrese el nombre del arma:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el daño del arma:");
            int daño = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad de ataque del arma:");
            double velocidadAtaque = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del arma:");
            int precio = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Es un arma a distancia? (s/n)");
            string esDistancia = Console.ReadLine().ToLower();

            if (esDistancia == "s")
            {
                Console.WriteLine("Ingrese el nombre del proyectil:");
                string nombreProyectil = Console.ReadLine();
                Console.WriteLine("Ingrese el daño del proyectil:");
                int dañoProyectil = int.Parse(Console.ReadLine());
                Proyectil proyectil = new Proyectil(nombreProyectil, dañoProyectil);

                ArmaDistancia armaDistancia = new ArmaDistancia(nombre, daño, velocidadAtaque, precio, proyectil);
                inventario.AgregarArma(armaDistancia);
            }
            else
            {
                ArmaCuerpoACuerpo armaCuerpoACuerpo = new ArmaCuerpoACuerpo(nombre, daño, velocidadAtaque, precio);
                inventario.AgregarArma(armaCuerpoACuerpo);
            }
        }
    }
}
