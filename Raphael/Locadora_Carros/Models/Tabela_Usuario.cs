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
    
    public partial class Tabela_Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tabela_Usuario()
        {
            this.Tabela_Usuario_Veiculo = new HashSet<Tabela_Usuario_Veiculo>();
        }
    
        public int ID { get; set; }
        public string Nome_Usuario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tabela_Usuario_Veiculo> Tabela_Usuario_Veiculo { get; set; }
    }
}
