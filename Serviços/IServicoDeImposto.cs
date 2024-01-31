using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infertaces.Serviços
{
    public interface IServicoDeImposto
    {
        double Tax (double valor);
    }
}