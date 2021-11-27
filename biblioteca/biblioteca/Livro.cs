using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Livro
    {
        public int cod;
        public string name, author, edit;
        public Livro(int codigo, string nome, string autor, string editora)
        {
            cod = codigo;
            name = nome;
            author = autor;
            edit = editora;
        }   
        public void mostraTitulo()
        {
            Console.WriteLine("Titulo: "+this.name);
        }
    }
}
