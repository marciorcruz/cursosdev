//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pontosnotaveis.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class linha
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public linha()
        {
            this.conexao = new HashSet<conexao>();
            this.pontosnotaveis = new HashSet<pontosnotaveis>();
        }
    
        public int id { get; set; }
        public string nome { get; set; }
        public Nullable<int> numero { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<conexao> conexao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pontosnotaveis> pontosnotaveis { get; set; }
    }
}