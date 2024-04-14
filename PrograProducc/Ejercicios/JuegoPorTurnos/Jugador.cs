using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Jugador
{
    public int Vida { get; private set; }
    public int Daño { get; private set; }

    public Jugador(int vida, int daño)
    {
        if (vida > 100 || daño > 100)
        {
            throw new ArgumentException("La vida y el daño no pueden superar 100.");
        }

        Vida = vida;
        Daño = daño;
    }

    public void RecibirDaño(int cantidad)
    {
        Vida -= cantidad;
    }

    public int ObtenerDaño()
    {
        return Daño;
    }
}
