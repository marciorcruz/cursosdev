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
    
    public partial class Tabela_Veiculos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tabela_Veiculos()
        {
            this.Tabela_Usuario_Veiculo = new HashSet<Tabela_Usuario_Veiculo>();
        }
    
        public int ID { get; set; }
        public int ID_Modelo { get; set; }
        public string Motor { get; set; }
        public decimal Valor_Diaria { get; set; }
        public int Quantidade { get; set; }
    
        public virtual Tabela_Modelos Tabela_Modelos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tabela_Usuario_Veiculo> Tabela_Usuario_Veiculo { get; set; }
    }
}
