using DDona.RefitTest.Domain.Entities;
using System.Collections.Generic;

namespace DDona.RefitTest.Repository.Interfaces
{
    public interface ICorRepository
    {
        Cor CarregarPorId(int id);
        IEnumerable<Cor> CarregarTodos();
    }
}