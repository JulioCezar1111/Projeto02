using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaixaDeCorResistor
{
    class CalculoFaixa
    {
        private string faixa1, faixa2, faixa3;

        public CalculoFaixa(string a, string b, string c)
        {
            this.faixa1 = a;
            this.faixa2 = b;
            this.faixa3 = c;
        }

        public string calculo()
        {
            string valorResistor = faixa1 + faixa2 + faixa3;
            return valorResistor;
        }
    }
    
}
