using System;

namespace ShadowLines.Classes
{
    internal class CalculoValorServico
    {
        public string Servico { get; set; }
        public double Valor { get; set; }

        public CalculoValorServico(string servico, double valor)
        {
            Servico = servico;
            Valor = valor;
        }

        public CalculoValorServico()
        {
        }

        public void ValorFinal(string servico, double valor) 
        { 
            if (servico == "Tatto") 
            { 
                valor = 200.00;
                double valorFinal = valor + (valor * 0.20);
            }
            else if (servico == "Remoção") 
            { 
                valor = 500.00;
                double valorFinal = valor + (valor * 0.15);
            }
            else if (servico == "Reconstrução" || servico == "Cobertura de tatuagem") 
            { 
                valor = 80.00;
                double valorFinal = valor + (valor * 0.10);
            }
            else if(servico == "Tatuagem Personalizada") 
            {
                valor = 600.00;
                double valorFinal = valor + (valor * 0.25);
            }
            else if (servico == "Consultoria") 
            {
                valor = 30.00;
                double valorFinal = valor + (valor * 0.01);
            }
            else
            {
                throw new ArgumentException("Serviço desconhecido.");
            }

        }
    }
}
