using DDona.RefitTest.Domain.Entities;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDona.RefitTest.WebApiInterface
{
    public interface ICorApi
    {
        [Get("/api/cor")]
        Task<IEnumerable<Cor>> CarregarTodos();
    }
}
