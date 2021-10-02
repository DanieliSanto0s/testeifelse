using System;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {

          string mes;
          Console.WriteLine("Digite um mês:");
          mes = Console.ReadLine();

          if (mes == "janeiro")
          {
            Console.WriteLine("Esse mês tem 31 dias");
          }

          else if (mes == "fevereiro")
          {
            Console.WriteLine("Esse mês tem 28 ou 29 dias");
          }

          else if (mes == "março")
          {
            Console.WriteLine("Esse mês tem 31 dias");
          }

          else if (mes == "maio")
          {
            Console.WriteLine("Esse mês tem 31 dias");
          }

          else if (mes == "julho")
          {
            Console.WriteLine("Esse mês tem 31 dias");
          }

          else if (mes == "agosto")
          {
            Console.WriteLine("Esse mês tem 31 dias");
          }

          else if (mes == "outubro")
          {
            Console.WriteLine("Esse mês tem 31 dias");
          }

          else if (mes == "dezembro")
          {
            Console.WriteLine("Esse mês tem 31 dias");
          }

           else
          {
            Console.WriteLine("Esse mês tem 30 dias");
          }
 
        }
    }
}
