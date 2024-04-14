using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograProducc.Semana2.ArmasInventario
{
    public class Inventario
    {
        private List<Arma> armas = new List<Arma>();

        public void AgregarArma(Arma arma)
        {
            armas.Add(arma);
        }

        public void MostrarArmas()
        {
            foreach (var arma in armas)
            {
                Console.WriteLine($"Nombre: {arma.Nombre}, Daño: {arma.Daño}, Velocidad de Ataque: {arma.VelocidadAtaque}, Precio: {arma.Precio}");
            }
        }

        public void EliminarArma(string nombre)
        {
            armas.RemoveAll(arma => arma.Nombre == nombre);
        }
    }
}
