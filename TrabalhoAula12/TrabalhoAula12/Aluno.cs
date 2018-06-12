using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAula12
{
    public class Aluno
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataNasc { get; set; }


        public int idade()
        {
            int idade = DateTime.Today.Year - this.DataNasc.Year;

            return DataNasc;
        }
           
        public string nomeCompleto()
        {// Deverá retornar o nome concatenado com o sobrenome
            return "oi";
        }

        public int validaNome()
        {//Deverá validar o nome do Aluno com caracteres divergentes
            return 1;
        }

        public string erroValidacao(int i)
        {
            string m;

            if (validaNome() == 1)
            {
                m = "ERROR POR Ç";
                return m;
            }
            else if (validaNome() == 2)
            {
                m = "ERROR POR '@'";
                return m;
            }
            return "";
        }
    }
}
