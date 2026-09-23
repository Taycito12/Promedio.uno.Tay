using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1_de_Santiago_Tay
{
    public class Jugador
    {
        private int vida;
        private int daño;
        public Jugador(int vida, int daño)
        {
            this.vida = vida;
            this.daño = daño;
        }
        public void RecibirDaño(int cantidad)
        {
            this.vida -= cantidad;
            if (this.vida < 0)
            {
                this.vida = 0;
            }
        }
        public int ObtenerDaño()
        {
            return this.daño;
        }
        public int ObtenerVida()
        {
            return this.vida;
        }
        public bool EstaVivo()
        {
            return this.vida > 0;
        } 
    }
}
