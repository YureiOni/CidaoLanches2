using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CidaoLanches2.Models
{
    public class Produtos
    {
        [PrimaryKey, AutoIncrement, NotNull]
        public string Id { get; set; }
        [NotNull]
        public string Nome { get; set; }
        [NotNull]
        public int Preco { get; set; }
    }
}