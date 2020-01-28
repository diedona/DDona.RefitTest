using DDona.RefitTest.Domain.Entities;
using DDona.RefitTest.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDona.RefitTest.Repository
{
    public class CorRepository : ICorRepository
    {
        private List<Cor> _cores;

        public CorRepository()
        {
            _cores = CarregarCores();
        }

        public Cor CarregarPorId(int id)
        {
            return _cores.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Cor> CarregarTodos()
        {
            return _cores.AsEnumerable();
        }

        private List<Cor> CarregarCores()
        {
            return new List<Cor>()
            {
                new Cor() { Id = 1, Nome = "Preto"},
                new Cor() { Id = 2, Nome = "Vermelho"},
                new Cor() { Id = 3, Nome = "Verde"},
                new Cor() { Id = 4, Nome = "Dourado"},
                new Cor() { Id = 5, Nome = "Branco"},
            };
        }
    }
}
