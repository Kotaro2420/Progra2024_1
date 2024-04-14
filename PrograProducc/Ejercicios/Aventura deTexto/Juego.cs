using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograProducc.Semana2
{
    class Juego
    {

        private Personaje jugador;

        public void Iniciar()
        {
            Console.WriteLine("¡Bienvenido a 'La búsqueda del tesoro perdido'!");
            CrearPersonaje();
            ComenzarAventura();
        }

        private void CrearPersonaje()
        {
            Console.WriteLine("Antes de comenzar tu aventura, necesitas crear a tu personaje.");

            Guerrero guerrero = new Guerrero();
            guerrero.Crear();
            jugador = guerrero;
        }

        private void ComenzarAventura()
        {
            Console.WriteLine("\nTe encuentras en un antiguo templo, buscando el legendario tesoro perdido.");
            Console.WriteLine("De repente, te enfrentas a una división en el camino.");

            
            while (jugador.Vida > 0)
            {
                MostrarOpciones();
                ProcesarSeleccion();
            }

            Console.WriteLine("¡Tu aventura ha llegado a su fin! Has perdido.");
        }

        private void MostrarOpciones()
        {
            Console.WriteLine("\n¿Qué camino deseas tomar?");
            Console.WriteLine("1. Explorar el pasillo izquierdo.");
            Console.WriteLine("2. Investigar el pasillo derecho.");
            Console.WriteLine("3. Descansar un momento para recuperar fuerzas.");
        }

        private void ProcesarSeleccion()
        {
            Console.Write("\nSelecciona una opción: ");
            int opcionSeleccionada = int.Parse(Console.ReadLine());

            switch (opcionSeleccionada)
            {
                case 1:
                    ExplorarIzquierda();
                    break;
                case 2:
                    InvestigarDerecha();
                    break;
                case 3:
                    Descansar();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida.");
                    break;
            }
        }

        private void ExplorarIzquierda()
        {
            Console.WriteLine("\nTe adentras en el oscuro pasillo izquierdo y encuentras una habitación misteriosa.");
            Console.WriteLine("Dentro de la habitación, ves una estatua antigua con un brillo en los ojos.");

            if (jugador.Destreza >= 30)
            {
                Console.WriteLine("Con tu destreza, logras esquivar una trampa y obtienes una gema valiosa.");
                Console.WriteLine("¡Tu destreza aumenta temporalmente!");
                jugador.Destreza += 10;
            }
            else
            {
                Console.WriteLine("¡Caes en una trampa y pierdes vida!");
                jugador.Vida -= 20;
            }
        }

        private void InvestigarDerecha()
        {
            Console.WriteLine("\nSigues por el pasillo derecho y te encuentras con una puerta cerrada con un extraño símbolo.");
            Console.WriteLine("Intentas abrir la puerta, pero está sellada.");

            if (jugador.Fuerza >= 40)
            {
                Console.WriteLine("Utilizas tu fuerza para derribar la puerta y encuentras una sala llena de tesoros.");
                Console.WriteLine("¡Has encontrado el tesoro perdido! ¡Has ganado la partida!");
                jugador.Vida = 0;
            }
            else
            {
                Console.WriteLine("No tienes suficiente fuerza para abrir la puerta. Deberás buscar otra manera.");
            }
        }

        private void Descansar()
        {
            Console.WriteLine("\nTe detienes un momento para recuperar fuerzas y curar tus heridas.");
            Console.WriteLine("¡Tu vida ha aumentado!");
            jugador.Vida += 20;
        }
    }
}

