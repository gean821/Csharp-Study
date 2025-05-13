using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___Learning.SintaxLearn
{ 
    public class CadastroPessoaTest01
    {
        static void Main(string[] args)
        {
            CadastroPessoa pessoa1 = new CadastroPessoa("Ana", 19, 1.59, true);
            Console.WriteLine(pessoa1.Nome); //no c# fazemos uso de get e set sem o atributo.get por conta das autoProperties.
            pessoa1.Nome = "Gean";
            Console.WriteLine(pessoa1);
        }
    }
}
