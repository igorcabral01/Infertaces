using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infertaces.entidades
{
    public class Veiculos
    {
        public string Modelo { get; set; }
        public Veiculos(string modelo)
        {
            Modelo = modelo;
        }
    }
}