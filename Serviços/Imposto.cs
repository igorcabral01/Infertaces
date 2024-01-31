using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infertaces.Serviços
{
    public class Imposto : IServicoDeImposto
    {
        public  double Tax (double valor)
        {
            if(valor <=100.0)
            {
                return valor * 0.2;
            }else
            {
                return valor *0.15;
            }

        }
    }
} 