﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilao
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }

        public Usuario(String nome) : this(0, nome)
        {
        }
        public Usuario(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
    }
}
