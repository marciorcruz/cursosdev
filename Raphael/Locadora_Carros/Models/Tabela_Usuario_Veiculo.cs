//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Locadora_Carros.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tabela_Usuario_Veiculo
    {
        public int ID_Veiculo { get; set; }
        public int ID_Usuario { get; set; }
        public Nullable<int> Dias { get; set; }
        public Nullable<decimal> Valor_Total { get; set; }
        public int ID { get; set; }
    
        public virtual Tabela_Usuario Tabela_Usuario { get; set; }
        public virtual Tabela_Veiculos Tabela_Veiculos { get; set; }
    }
}
