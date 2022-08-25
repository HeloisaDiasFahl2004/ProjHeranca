using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjHeranca
{
    internal class Pessoa
    {
        String Nome;
        DateTime DataNascimento;
        long CPF;
  
        public Pessoa()
        {

        }
        public Pessoa(string nome,DateTime dataNascimento, long cpf)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            CPF = cpf;
        }
        public void setNome(string nome)
        {
          Nome = nome;
        }
        public void setDataNascimento(DateTime dataNascimento)
        {
            DataNascimento = dataNascimento;
        }
        public void setCPF(long cpf)
        {
            CPF =cpf;
        }
        //metdos getters -> retornam um atributo
        public String getNome()
        {
            return this.Nome;
        }
        public DateTime getDataNascimento()
        {
           return this.DataNascimento;
        }
        public long getCPF()
        {
            return CPF;

        }
        //metodo ToString -> permite o reaproveitamento de codigos
        public override string ToString()
        {
            return "\nNome: " + getNome() + "\nDataNascimento: " + getDataNascimento() + "\nCPF: " + getCPF();
        }
    }
}
