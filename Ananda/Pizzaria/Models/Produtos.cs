//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Produtos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produtos()
        {
            this.Composicao = new HashSet<Composicao>();
        }
    
        public int id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public Nullable<int> id_Categoria { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Composicao> Composicao { get; set; }
    }
}