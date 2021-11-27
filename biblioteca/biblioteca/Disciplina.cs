using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Disciplina
    {
        string nomeDisciplina;
        int cargaHoraria;

        public Disciplina(string nome, int carga)
        {
            this.nomeDisciplina = nome;
            this.cargaHoraria = carga;
        }

        public void exibeDados()
        {
            Console.WriteLine("Disciplina:"+this.nomeDisciplina+"\nCarga Horaria:"+this.cargaHoraria);
        }
    }
}
