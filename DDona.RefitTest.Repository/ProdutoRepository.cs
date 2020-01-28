using DDona.RefitTest.Domain.Entities;
using DDona.RefitTest.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDona.RefitTest.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private List<Produto> _produtos;

        public ProdutoRepository()
        {
            _produtos = CarregarProdutos();
        }

        public IEnumerable<Produto> BuscarPorCor(int corId)
        {
            return _produtos.Where(x => x.Cor1.Id == corId || x.Cor2.Id == corId || x.Cor3.Id == corId).AsEnumerable();
        }

        public Produto CarregarPorId(int id)
        {
            return _produtos.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Produto> CarregarTodos()
        {
            return _produtos.AsEnumerable();
        }

        private List<Produto> CarregarProdutos()
        {
            return new List<Produto>
            {
                new Produto(){ Id = 1, Nome = "Tênis Alpha", Cor1 = new Cor(){ Id = 1, Nome = "Preto" } },
                new Produto(){ Id = 1, Nome = "Tênis Alpha RX", Cor1 = new Cor(){ Id = 2, Nome = "Vermelho" }, Cor2 = new Cor(){ Id = 3, Nome = "Verde" } },
                new Produto(){ Id = 1, Nome = "Tênis Nike", Cor1 = new Cor(){ Id = 4, Nome = "Dourado" }, Cor2 = new Cor(){ Id = 5, Nome = "Branco" } },
                new Produto(){ Id = 1, Nome = "Tênis Nike FT", Cor1 = new Cor(){ Id = 4, Nome = "Dourado" }, Cor2 = new Cor(){ Id = 2, Nome = "Vermelho" }, Cor3 = new Cor(){ Id = 1, Nome = "Preto" } },
                new Produto(){ Id = 1, Nome = "Tênis Xapa", Cor1 = new Cor(){ Id = 3, Nome = "Verde" } },
                new Produto(){ Id = 1, Nome = "Tênis Mala", Cor1 = new Cor(){ Id = 5, Nome = "Branco" } },
            };
        }
    }
}
