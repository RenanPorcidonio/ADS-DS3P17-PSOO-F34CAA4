using System;

namespace RegistroAluno
{
    class Pessoa
    {
        public string Nome;

        public Pessoa(string nome)
        {
            Nome = nome;
        }
    }

    class Aluno : Pessoa
    {
        public string RA;
        public string Turma;

        public Aluno(string nome, string ra, string turma) : base(nome)
        {
            RA = ra;
            Turma = turma;
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"A turma do Aluno {Nome} é {Turma}, e seu RA é {RA}");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Aluno Renan = new Aluno("Renan Porcidonio Xavier", "F34CAA4", "DS3P17");

            Renan.MostrarDetalhes();

        }
    }
}
