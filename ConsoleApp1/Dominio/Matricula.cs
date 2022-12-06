using System;

namespace ConsoleApp1.Dominio
{
    public class Matricula
    {
        public Aluno Aluno { get; private set; }
        public DateTime Data { get; private set; }

        public Matricula(Aluno aluno)
        {
            ValidarIdadeMinima(aluno);

            Aluno = aluno;
            Data = DateTime.Now;
        }

        private void ValidarIdadeMinima(Aluno aluno)
        {
            const int idadeMinimaEmAnos = 5;

            if (aluno.Idade < idadeMinimaEmAnos)
            {
                throw new Exception($"A idade mínima para a matrícula é {idadeMinimaEmAnos} anos!");
            }
        }
    }
}