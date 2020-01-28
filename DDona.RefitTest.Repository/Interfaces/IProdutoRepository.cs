using DDona.RefitTest.Domain.Entities;
using System.Collections.Generic;

namespace DDona.RefitTest.Repository.Interfaces
{
    public interface IProdutoRepository
    {
        Produto CarregarPorId(int id);
        IEnumerable<Produto> CarregarTodos();
        IEnumerable<Produto> BuscarPorCor(int corId);
    }
}