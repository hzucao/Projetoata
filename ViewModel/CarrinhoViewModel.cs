using Microsoft.AspNetCore.Mvc;
using Projeto.Models;

namespace Projeto.ViewModel
{
    public class CarrinhoViewModel
    {
        public Carrinho Carrinho {get;set;}
        public double CarrinhoTotal{get;set;}
    }
}