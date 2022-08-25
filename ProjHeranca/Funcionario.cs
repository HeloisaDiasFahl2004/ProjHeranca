using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjHeranca
{
    internal class Funcionario : Pessoa
    {
        long Pis;
        double Salario;
        string Setor;


        public Funcionario()
        {

        }
        public Funcionario(string nome, DateTime dataNascimento, long cpf, long pis, double salario, string setor)
            :base(nome,dataNascimento,cpf)
        {
            Pis = pis;
            Salario = salario;
            Setor = setor;
        }
        public void setPis(long pis)
        {
            Pis = pis;
        }
        public void setSalario(double salario)
        {
            Salario = salario;

        }
        public void setSetor(string setor)
        {
            Setor = setor;
        }
        public long getPis()
        {
            return Pis;
        }
        public double getSalario()
        {
            return Salario;
        }
        public string getSetor()
        {
            return Setor;
        }

        public override string ToString()
        {
            return base.ToString() + "\nPis: " + getPis() + "\nSalario: " + getSalario() + "\nSetor: " + getSetor();
        }

    }
}
