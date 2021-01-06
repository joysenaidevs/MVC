using System;
using MVC.Controllers;
using MVC.Models;

namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {

            //instanciar controller
            ProdutoController produtoController = new ProdutoController();
            produtoController.MostrarProdutos();

            produtoController.Cadastrar();

        }
    }
}
