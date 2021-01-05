using System.Collections.Generic;
using MVC.Models;
using MVC.Views;

namespace MVC.Controllers
{
    public class ProdutoController
    {
        //CRIAR UMA INSTACIA
        //ACESSAR OS DOIS
        //chamar o método que vai listar
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();
        public void MostrarProdutos()
        {
            //chamar esses metodos
            //capturo as informacoes do csv
            List<Produto> todos = produto.Ler();
            produtoView.ListarTodos(todos);

        }
    }
}