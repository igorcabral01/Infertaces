using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infertaces.entidades
{
    public class AluguelCarros
    {
        public DateTime Inicio_ { get; set; }
        public DateTime Fim_ { get; set; }
        public Veiculos veiculo { get; set; }
        public  InVoice inVoice { get; set; }
        public AluguelCarros(DateTime inicio, DateTime fim, Veiculos veiculos)
        {
           Inicio_ = inicio;
           Fim_ = fim;
           veiculo= veiculos;
        }
        
      
    }
}