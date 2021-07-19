using System;

namespace CadastroPessoaTxtApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pessoa p1 = new Pessoa
            {
                Nome = "João da Silva",
                Telefone = 11964565451,
                Email = "joaomaria@gmail.com",
                Rg = "32.545.545-6"
            };

            p1.Cadastrar(p1.Nome, p1.Telefone, p1.Email, p1.Rg);
                        
           
            p1.PesquisarPelaPrimeiraLetra("A");

            p1.Nome = "Maria da Silva";
            p1.Telefone = 11545331541;
            p1.Email = "mariajose@gmail.com";
            p1.Rg = "54.654.654-5";
            
            p1.Cadastrar(p1.Nome, p1.Telefone, p1.Email, p1.Rg);
        }
    }
}
