using System.Collections.Generic;
using System.IO;

namespace MVC.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        private const string PATH = "Database/Produto.csv";

        public Produto()
        {
            string pasta = PATH.Split("/") [0];

            //Verificar se a PASTA não existe, CRIAR ESTA CONDICAO

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //VERIFICAR SE O ARQUIVO PRODUTO.CSV EXISTE (CASO NAO EXISTA, CRIAMOS)

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }

            
        }
            public List <Produto> Ler()
            {
                List<Produto> produtos = new List<Produto>();

                //Pegar as informacoes do csv

                string[] linhas = File.ReadAllLines(PATH);

                foreach (string  item in linhas)
                {
                    //Separar atributos pelo ; (ponto e virgula)
                    string[] atributos = item.Split(";");

                    //Criamos um produto vazio para poder colocar na lista final de produtos
                    Produto prod        = new Produto();
                    prod.Codigo         = int.Parse( atributos[0] );
                    prod.Nome           = atributos[1];
                    prod.Preco          = float.Parse( atributos[2] );

                    produtos.Add(prod);
                }

                return produtos;
            }

            public void Inserir(Produto p)
            {
                //Preparar um array de string para o método AppendAllLines
                string[] linhas = { PrepararLinhaCSV(p) };

                //Inserir um array de linhas no arquivo CSV
                File.AppendAllLines(PATH, linhas);
            }

            public string PrepararLinhaCSV(Produto prod)
            {
                //Preparar a linha para o formato CSV
                return $"{prod.Codigo};{prod.Nome};{prod.Preco}";
            }
        
        
    }
}