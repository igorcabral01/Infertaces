using System.Globalization;

namespace Infertaces.entidades
{
    public class InVoice
    {
        public double PagamentoBasico { get; set; } 
        public double Taxa { get; set; }
        public InVoice(double pagamentoBasico,double taxa)
        {
            PagamentoBasico=pagamentoBasico;
            Taxa=taxa;
        }
        public double PagamentoTotal {get{return PagamentoBasico + Taxa;}}

        public override string ToString()
        {
            return "Pagamento Basico: "
            +
            PagamentoBasico.ToString("F2",CultureInfo.InvariantCulture)
            +
            "\n TAXA: "
            +
            Taxa.ToString("F2",CultureInfo.InvariantCulture)
            +
            "\n Pagamento Total: "
            +
            PagamentoTotal.ToString("F2",CultureInfo.InvariantCulture);
        }


    }
}