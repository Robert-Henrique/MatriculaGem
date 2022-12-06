using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Dominio;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var aluno1 = new Aluno("Robert", new DateTime(1992, 1, 7), "Sax Alto");
            var aluno2 = new Aluno("Mateus", new DateTime(1994, 3, 7), "Sax Tenor");
            var aluno3 = new Aluno("Pedro", new DateTime(2021, 6, 21), "Trombone");

            var matricula1 = new Matricula(aluno1);
            var matricula2 = new Matricula(aluno2);
            var matricula3 = new Matricula(aluno3);
        }
    }
}
