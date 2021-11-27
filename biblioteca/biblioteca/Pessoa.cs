using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Pessoa
    {
       private  string nome;
        int idade;
        string cpf;

        public Pessoa(string nome, int idade, string cpf)
        {
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
        }
        public void mostraDados()
        {
            Console.WriteLine("nome: "+ this.nome+"\nIdade: "+this.idade+"\ncpf:" + this.cpf);
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
    }
}
