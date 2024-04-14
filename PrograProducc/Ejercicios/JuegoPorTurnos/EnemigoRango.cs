using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EnemigoRango : Enemigo
{
    private int balas;

    public EnemigoRango(int vida, int daño, int balas) : base(vida, daño)
    {
        this.balas = balas;
    }

    public override void RecibirDaño(int cantidad)
    {
        base.RecibirDaño(cantidad);
        if (Vida > 0 && balas <= 0)
        {
            Vivo = false;
        }
    }

    public int ObtenerBalas()
    {
        return balas;
    }

    public void UsarBala()
    {
        if (Vivo)
        {
            balas--;
        }
    }
}
