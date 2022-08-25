using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjHeranca
{
    internal class Aluno : Pessoa
    {
        long RA;
        DateTime DataMatricula;
        public Aluno()
        {

        }
        public Aluno(string nome, DateTime dataNascimento, long cpf, long ra, DateTime dataMatricula)
            : base(nome, dataNascimento, cpf)
        {
            RA = ra;
            DataMatricula = dataMatricula;
        }
        public void setRA(long ra)
        {
            RA = ra;
        }
        public void setDataMatricula(DateTime dataMatricula)
        {
            DataMatricula = dataMatricula;
        }
        public long getRA()
        {
            return this.RA;
        }
        public DateTime getDataMatricula()
        {
            return this.DataMatricula;
        }
        public override string ToString()
        {
            return base.ToString() + "\nRA: " + getRA() + "\nData Matricula: " + getDataMatricula();
        }
    }
}
