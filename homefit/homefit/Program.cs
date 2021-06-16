using System;
using System.Collections.Generic;

namespace homefit
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DataIcial;
            DateTime DataFinal;
            List<String> exercicio = new List<String>();

            
            Aluno aluno = new Aluno(01, "henrique", 36, "Masculino", 66, "1234", 1.66, 18.5);
            Treino treino = new Treino(01, 18.5, DataIcial = new DateTime(2021,11,06), DataFinal = new DateTime(2021,07,12), aluno, exercicio);
            treino.AddExercicios("Superior: peito: supino reto 4x7, remada 3x12");
            treino.AddExercicios("Ombro 4x7, costa: puxada 3x12, remada 3x12");
            treino.AddExercicios("Costa: puxada 3x12, remada 3x12");


            Console.WriteLine(treino);

            Console.WriteLine(exercicio);
            //Console.WriteLine(exercicio.ToString());
        }
    }
}
