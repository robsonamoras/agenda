using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CadastroPessoaTxtApp
{
    public class Pessoa
    {
        private string nome;
        private long telefone;
        private string rg;
        private string email;

        // Displays samedi 1 mars 2008 07:00:00
        public DateTime date1 = new DateTime();
        
        
        //Colocando o endereço físico (caminho do arquivo texto)
        string CaminhoNome = "C:\\Users\\Scorpion\\Desktop\\BD_Arquivo\\contato.txt";

        //Métodos acessores GET/SET
        public string Nome
        {
            //Abreviação de {} é mesma coisa =>
            get => this.nome;
            set
            {
                if ((value != null) && (value != string.Empty))
                {
                    this.nome = value;
                }
            }
        }
        public long Telefone
        {
            get => telefone;
            set
            {
                if (value != 0)
                {
                    this.telefone = value;
                }
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if ((value != null) && (value != string.Empty))
                {
                    this.email = value;
                }
            }
        }
        public string Rg
        {
            get => this.rg;
            set
            {
                this.rg = value;
            }
        }

        //Construtores
        public Pessoa() { }

        public Pessoa(string nome, long telefone, string email, string rg)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.rg = rg;
        }
    
        public void ExibirLista()
        {
            StreamReader reader = new StreamReader(CaminhoNome);
            string linha;
            while ((linha = reader.ReadLine()) != null)
            {
                string[] dados = linha.Split(',');
                this.nome = dados[0];
                this.telefone= long.Parse(dados[1]);
                this.email = dados[2];
                this.rg = dados[3];

                Console.Write(dados[0]+"\n"+dados[1] + "\n" + dados[2] + "\n" + dados[3]);
            }
            reader.Close();
        }
        
        public void PesquisarNome(string nome)
        {
            StreamReader reader = new StreamReader(CaminhoNome);
            string linha;
            while ((linha = reader.ReadLine()) != null)
            {
                string[] dados = linha.Split(',');
                this.nome = dados[0];
                this.telefone = long.Parse(dados[1]);
                this.email = dados[2];
                this.rg = dados[3];
                if (dados[0] == nome)
                {
                    Console.Write(dados[0] + "\n" + dados[1] + "\n" + dados[2] + "\n" + dados[3] +"\n");
                }
                
            }
            reader.Close();
        }

        public void PesquisarPelaPrimeiraLetra(string letra)
        {
            StreamReader reader = new StreamReader(CaminhoNome);
            string linha;
            while ((linha = reader.ReadLine()) != null)
            {
                string[] dados = linha.Split(',');
                this.nome = dados[0];
                this.telefone = long.Parse(dados[1]);
                this.email = dados[2];
                this.rg = dados[3];

                string primeiraLetra = dados[0].Substring(0, 1);
                if (primeiraLetra == letra)
                {
                    Console.Write(dados[0] + "\n" + dados[1] + "\n" + dados[2] + "\n" + dados[3] + "\n");
                }

            }
            reader.Close();
        }

        public void Cadastrar(string nome, long telefone, string email, string rg)
        {
            ////declarando a variável do tipo StreamReader para
            //abrir ou criar um arquivo para leitura           
            StreamReader reader = new StreamReader(CaminhoNome);
            //Verificando se a linha esta vazia
            string linha = reader.ReadLine();

            if (linha == null)
            {
                reader.Close();
                ////declarando a variável do tipo StreamWriter para
                //abrir ou criar um arquivo para escrita
                StreamWriter gravar = new StreamWriter(CaminhoNome);
                gravar.WriteLine(nome + "," + telefone + "," + email + "," + rg);
                gravar.Close();
            }
            else
            {
                reader.Close();
                ////declarando a variável do tipo StreamWriter para
                //abrir ou criar um arquivo para escrita
                StreamWriter gravar;
               
                //usando o metodo e abrindo o arquivo texto
                gravar = File.AppendText(CaminhoNome);
                
                gravar.WriteLine(nome + "," + telefone + "," + email + "," + rg);
                gravar.Close();

            }
        }
    }
}