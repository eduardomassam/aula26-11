using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Carro
    {
        public int vMax = 100;
        public string modelo { get; set; }
        public string cor { get; set; }
        public string ano { get; set; }
        public string marca { get; set; }
        public string chassi { get; set; }
        public string proprietario { get; set; }
        public int vAtual { get; set; }
        public int nPortas { get; set; }
        public int nMarcha { get; set; }
        public int volTanque { get; set; }
        public Boolean tetoSolar { get; set; }
        public string tipoCambio { get; set; }
        
        public void aceleraCarro()
        {
            if (this.vAtual < this.vMax)
                this.vAtual = this.vAtual + 1;
            else
                this.vAtual = this.vAtual;
        }
        public void  freiaCarro()
        {
            this.vAtual = 0;
        }
        public void aumentaMarcha()
        {
            this.nMarcha = this.nMarcha + 1;
        }
        public void diminueMarcha()
        {
            this.nMarcha = this.nMarcha - 1;
        }
    }
}
