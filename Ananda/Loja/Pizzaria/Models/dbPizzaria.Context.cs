﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pizzaria.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_PizzariaEntities : DbContext
    {
        public db_PizzariaEntities()
            : base("name=db_PizzariaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Composicao> Composicao { get; set; }
        public virtual DbSet<Itens> Itens { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Produtos> Produtos { get; set; }
    }
}