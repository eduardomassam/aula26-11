using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Curso
    {
        public string nome;
        public Curso(string nome)
        {
            this.nome = nome;
        }
        public void exibeDisciplina()
        {
            Disciplina d1 = new Disciplina("C#", 100);
            d1.exibeDados();
        }
    }
}
