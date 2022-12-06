using System;

namespace ConsoleApp1.Dominio
{
    public class Aluno
    {
        public string Nome { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public string Instrumento { get; private set; }
        public int Idade => DateTime.Today.Year - DataDeNascimento.Year;

        public Aluno(string nome, DateTime dataDeNascimento, string instrumento)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Instrumento = instrumento;
        }
    }
}