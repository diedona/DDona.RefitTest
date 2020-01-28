using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.RefitTest.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Cor Cor1 { get; set; }
        public Cor Cor2 { get; set; }
        public Cor Cor3 { get; set; }
    }
}
