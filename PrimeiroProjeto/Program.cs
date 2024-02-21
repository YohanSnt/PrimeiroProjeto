using System.Security.Cryptography.X509Certificates;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, cidade;
            int idade;

            Console.WriteLine("Digite seu nome: "); 
            nome = Console.ReadLine();
            
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite sua cidade: ");
            cidade = Console.ReadLine();
            
            
            // comentário

            Console.WriteLine("\nNome: {0}", nome);
            Console.WriteLine("Idade: {0}",idade, "anos ");
            Console.WriteLine("Cidade: {0}\n",cidade);
            
            //Console.WriteLine("Nome: {0}\nIdade: {1}\nCidade: {2}",nome, idade, cidade);
            

        }
    }
}