using System;

namespace ProjHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, n;

            Console.Write("Informe o número de pessoas que deseja cadastrar: ");
            n = int.Parse(Console.ReadLine());
            int[] vet = new int[n];
            for (i = 0; i < n; i++)
            {
                Pessoa pessoa = new Pessoa();
                //deixo usuario digitar
                Console.Write("Informe o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Informe sua data de nascimento: ");
                DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
                Console.Write("Informe seu cpf: ");
                long cpf = long.Parse(Console.ReadLine());
                Console.ReadKey();
                Console.Clear();
                Console.Write("Opcoes de cadastramento:\n 1-aluno\n 2-funcionario");
                int opc = int.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine("Opcao invalida");
                    Console.Write("Opcoes de cadastramento:\n 1-aluno\n 2-funcionario");
                    opc = int.Parse(Console.ReadLine());
                } while (opc != 1 && opc != 2);
                if (opc == 1)
                {

                    Console.Write("Informe seu Registro Acadêmico: ");
                    long ra = long.Parse(Console.ReadLine());
                    Console.Write("Informe a data da sua matricula: ");
                    DateTime dataMatricula = DateTime.Parse(Console.ReadLine());
                    Console.ReadKey();
                    Console.Clear();
                    Aluno aluno = new Aluno(nome, dataNascimento, cpf, ra, dataMatricula);
                    Console.Write(aluno.ToString());
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {

                    Console.Write("Informe seu Pis: ");
                    long pis = long.Parse(Console.ReadLine());
                    Console.Write("Informe seu salario: ");
                    double salario = double.Parse(Console.ReadLine());
                    Console.Write("Informe seu setor: ");
                    string setor = Console.ReadLine();
                    Console.ReadKey();
                    Console.Clear();
                    Funcionario funcionario = new Funcionario(nome, dataNascimento, cpf, pis, salario, setor);
                    Console.Write(funcionario.ToString());
                    Console.ReadKey();
                    Console.Clear();

                }



            }
        }
    }
}