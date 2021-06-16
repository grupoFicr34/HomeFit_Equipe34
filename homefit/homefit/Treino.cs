using System;
using System.Collections.Generic;
using System.Text;

namespace homefit
{
    class Treino
    {
        public int ID { get; set; }
        public double Frequencia { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public Aluno aluno { get; set; }
        public List<String> exercicio;


        public Treino(int iD, double frequencia, DateTime dataInicial, DateTime dataFinal, Aluno aluno, List<String> exercicio)
        {
            ID = iD;
            Frequencia = frequencia;
            DataInicial = dataInicial;
            DataFinal = dataFinal;
            this.aluno = aluno;
            this.exercicio = exercicio;
        }

        public void AddExercicios(String exercicio)
        {
            this.exercicio.Add(exercicio);
        }

        public void AlterarExercicio(Treino treino, String novoExercicio) 
        {
            if (treino.exercicio != null && treino.exercicio.Equals(treino.ID)) 
            {
                exercicio.Add(novoExercicio);
            }
        }

        public void RemoverExercicio(Treino treino)
        {
            foreach (var item in exercicio)
            {
                if (item != null && item.Equals(item))
                {
                    exercicio.Remove(item);
                }
            }
        }



        public Boolean GerarTreino(Aluno use)
        {
            if (use.Imc <= 18.5)
            {
                Frequencia = use.Imc;

                return true;
            }
            else if ((use.Imc > 18.5) && (use.Imc < 30))
            {
                Frequencia = use.Imc;
                return true;
            }
            else if (use.Imc >= 30)
            {
                Frequencia = use.Imc;
                return true;
            }
            else
            {
                Console.WriteLine("Imc não encontrado");
                return false;
            }
        }

        public override string ToString()
        {
            String exe = "";
            foreach (var item in exercicio)
            {
                exe += item + "\n";
            }
            return "\nID Treino: " + this.ID +
                   "\nIMC: " + this.Frequencia +
                   "\nDataInicial: " + this.DataInicial +
                   "\nDataFinal: " + this.DataFinal +
                   "\nAluno: " + this.aluno +
                   "\nExercicio: " + exe;
                    

        }
    }
}
