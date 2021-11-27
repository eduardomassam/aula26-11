using System;

namespace biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Livro l1 = new Livro(1, "Livro 1", "Autor 1", "Editora 1");
            //Livro l2 = new Livro(2, "Livro 2", "Autor 2", "Editora 1");
            //Disciplina d1 = new Disciplina("Matematica",10);
            //Pessoa p1 = new Pessoa("Eduardo",30,"021393029");
            //Curso c1 = new Curso("Java");
            //Motor m1 = new Motor();
            //m1.potencia = 100;
            //Console.WriteLine(m1.potencia);
            //m1.potencia = 200;
            //Console.WriteLine(m1.potencia);

            Carro c1 = new Carro();
            Console.WriteLine(c1.vAtual);
            c1.aceleraCarro();
            Console.WriteLine(c1.vAtual);
            c1.aceleraCarro();
            Console.WriteLine(c1.vAtual);
            c1.freiaCarro();
            Console.WriteLine(c1.vAtual);
            //d1.exibeDados();
            //c1.exibeDisciplina();
            //Console.WriteLine(c1.nome); 
            //  p1.mostraDados();
            //  Console.WriteLine(p1.getNome());
            // l1.mostraTitulo();
            //Console.WriteLine("Codigo: "+l1.cod+"\nLivro: "+l1.name+"\nAutor: "
            //    +l1.author+"\nEditora: "+l1.edit+"\nAcabou o código");

        }

    }
}