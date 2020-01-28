using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.RefitTest.Domain.Entities
{
    public class Cor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"Cor {{Id: {Id} Nome: {Nome}}}";
        }
    }
}
