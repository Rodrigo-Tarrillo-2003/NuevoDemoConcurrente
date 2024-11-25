using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoC.oncurrencia
{
    public sealed class Singleton
    {
        private static Singleton Instancia =null;
        private static readonly object bloqueo = new();

        public Singleton()
        {
            
        }

        public static Singleton Instance
        { 
            get 
            {
                lock (bloqueo)
                {
                    if (Instancia == null)
                    {
                        Instancia = new Singleton();
                    }
                    return Instancia;
                }
            }
        }
    }
}
