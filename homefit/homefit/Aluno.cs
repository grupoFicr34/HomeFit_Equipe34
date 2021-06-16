using System;
using System.Collections.Generic;
using System.Text;

namespace homefit
{
    class Aluno
    {
        public int ID { get; set; }
        public String Nome { get; set; }
        public int Idade { get; set; }
        public String Sexo { get; set; }
        public double Peso { get; set; }
        public String Senha { get; set; }
        public double Altura { get; set; }
        public double Imc { get; set; }
        public List<Treino> listTreino = new List<Treino>();
        public List<Aluno> listAluno = new List<Aluno>();

        public Aluno(int iD, string nome, int idade, string sexo, double peso, string senha, double altura, double imc)
        {
            ID = iD;
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
            Peso = peso;
            Senha = senha;
            Altura = altura;
            Imc = imc;
        }

        public double CalcularImc(double peso, double altura)
        {
            this.Imc = peso / (altura * altura);
            return Imc;
        }

        public void AddAluno(Aluno aluno)
        {
            this.listAluno.Add(aluno);
        }

        public void AlterarAluno(int id, string nome, int idade, string sexo, double peso, string senha, double altura, double imc)
        {
            if (this.ID.Equals(ID) && this.Senha.Equals("senha"))
            {
                this.ID = id;
                this.Nome = nome;
                this.Idade = idade;
                this.Sexo = sexo;
                this.Peso = peso;
                this.Senha = senha;
                this.Altura = altura;
                this.Imc = imc;
            }
        }

        public void ExcluiAluno(Aluno aluno)
        {
            if (aluno.ID.Equals(aluno.ID) && aluno.Nome.Equals(aluno.Nome))
            {
                this.listAluno.Remove(aluno);
            }
        }

        public List<Aluno> ListarAluno()
        {
            return listAluno;
        }

        public Boolean Login(String nome, String senha)
        {
            if ((this.Nome.Equals("nome") && (this.Senha.Equals("senha"))))
            {
                this.Nome += nome;
                this.Senha += senha;
                Console.WriteLine("Login realizado com Sucesso!");
                return true;
            }
            else
            {
                Console.WriteLine("Favor verificar nome e senha, login invalido!");
                return false;
            }
        }

        public override string ToString()
        {
            return "\nID Aluno: " + this.ID +
                   "\nNome: " + this.Nome +
                   "\nIdade: " + this.Idade +
                   "\nSexo: " + this.Sexo +
                   "\nPeso: " + this.Peso +
                   "\nAltura: " + this.Altura +
                    "\nIMC: " + this.Imc;
        }
    }
}
