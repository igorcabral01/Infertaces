using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infertaces.entidades;


namespace Infertaces.Serviços
{
    public class NotasAluguel 
    {
        private IServicoDeImposto _Imposto;
      public double PrecoPorHora { get;private set; }
      public double PrecoPorDia { get;private set; }
      public NotasAluguel(double precodia, double precohora,IServicoDeImposto imposto )
      {
        PrecoPorHora = precohora;
        PrecoPorDia = precodia;
        _Imposto = imposto;
      }
      public void ProcessoInVoice(AluguelCarros aluguelCarros)
      {
        TimeSpan Duracao = aluguelCarros.Fim_.Subtract(aluguelCarros.Inicio_);
        double PagamentoBasico = 0.0;
        if (Duracao.TotalHours <= 12)
        {
            PagamentoBasico = PrecoPorHora * Math.Ceiling(Duracao.TotalHours);
        }else
        {
            PagamentoBasico = PrecoPorDia * Math.Ceiling(Duracao.TotalDays);
        }
        double tax =_Imposto.Tax(PagamentoBasico);
        aluguelCarros.inVoice = new InVoice(PagamentoBasico, tax);
      }
    }
}