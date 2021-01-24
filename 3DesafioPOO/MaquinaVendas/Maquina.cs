using System;
using System.Collections.Generic;
using System.Text;

namespace _3DesafioPOO.MaquinaVendas
{
    public class Maquina
    {
        public Maquina()
        {
                
        }

        public Maquina(List<Produto> produto)
        {
            Produto = produto;
        }

        public List<Produto> Produto { get; set; }

  
    }
}
