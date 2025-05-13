using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C___Learning.SintaxLearn
{
    public class CadastroPessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }
        public bool TemCarteira { get; set; }

        public CadastroPessoa(string nome, int idade, double altura, bool temCarteira)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
            TemCarteira = temCarteira;
        }
        public override string ToString()
        {
            return "Nome: " + Nome + "\nIdade: " + Idade + "\nAltura: " + Altura + "\nTem Carteira: " + TemCarteira;
        }
    }
}
       