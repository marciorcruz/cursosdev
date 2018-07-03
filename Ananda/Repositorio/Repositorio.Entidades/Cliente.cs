﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Entidades
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}
