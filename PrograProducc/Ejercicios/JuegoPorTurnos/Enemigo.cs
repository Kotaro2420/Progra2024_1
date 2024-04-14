using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Enemigo
{
    public int Vida { get; protected set; }
    public int Daño { get; protected set; }
    public bool Vivo { get; protected set; }

    public Enemigo(int vida, int daño)
    {
        Vida = vida;
        Daño = daño;
        Vivo = true;
    }

    public virtual void RecibirDaño(int cantidad)
    {
        Vida -= cantidad;
        if (Vida <= 0)
        {
            Vivo = false;
        }
    }

    public int ObtenerDaño()
    {
        return Daño;
    }
}
