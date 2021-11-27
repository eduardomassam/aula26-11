using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Motor
    {
        private string nomeFabricante;
        //private int potencia;
        private string tipo;

        //public Motor(string nome, int potencia, string tipo)
        //{
        //    this.nomeFabricante = nome;
        //    this.potencia = potencia;
        //    this.tipo = tipo;
        //}
        //public void setDados(string nome,int potencia,string tipo)
        //{
        //    this.nomeFabricante = nome;
        //    this.potencia = potencia;
        //    this.tipo = tipo;
        //}
        //public void getDados()
        //{
        //    Console.WriteLine("Fabricante: "+this.nomeFabricante);
        //    Console.WriteLine("Potencia: " + this.potencia);
        //    Console.WriteLine("Tipo: " + this.tipo);
        //}

        //public int potencia
        //{
        //    get { return _potencia; }
        //    set { _potencia = value; }
        //}

        public int potencia { get; set; }
    }
}
