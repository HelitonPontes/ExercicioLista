using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("XXXXXXX Exercicio Lista XXXXXXXXX");
            Console.WriteLine("---------------------------------------");

            Pessoa pessoa = new Pessoa();

            //Declarando e Instaciando uma lista

            List<string> lista = new List<string>();


            //Adiconando itens na lista
            lista.Add("Heliton");
            lista.Add("Elaine");
            lista.Add("Nicoly");
            lista.Add("Lilica");
            lista.Add("Sorocaba");

            //Adicionando itens com indice
            lista.Insert(3, "Teste");
            lista.Insert(0,"toto");

            //Remover item por indice
            lista.RemoveAt(0);


            Console.WriteLine("Lista de Pessoas: ");

            foreach ( string obj in lista)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------------------");

            //Tamanho da lista

            Console.WriteLine("Lista:  " + lista.Count);
            Console.WriteLine("---------------------------------------");

            //Remover por string
            lista.Remove("Sorocaba");

            //Remover
            // lista.RemoverRanger (0,0)


            Console.WriteLine("Lista de Pessoas: ");

            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------------------");

            //Tamanho da lista

            Console.WriteLine("Lista:  " + lista.Count);
            Console.WriteLine("---------------------------------------");


            Console.WriteLine("---------------------------------------");
            Console.WriteLine("---------------------------------------");

            List<Pessoa> lista1 = new List<Pessoa>();

            //lista1.Add.pessoa1( pessoa.Nome="Heliton", pessoa.Cidade="Sorocaba", pessoa.Idade=39,pessoa.Genero='M') ;

            pessoa.Nome = "Heliton";
            pessoa.Cidade = "Sorocaba";
            pessoa.Idade = 20;
            pessoa.Genero = 'M';

            Console.WriteLine(pessoa.Nome);
            Console.WriteLine(pessoa.Cidade);
            Console.WriteLine(pessoa.Idade);
            Console.WriteLine(pessoa.Genero);











            Console.ReadKey();
        }
    }
}
