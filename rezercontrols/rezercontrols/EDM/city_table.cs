//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rezercontrols.EDM
{
    using System;
    using System.Collections.Generic;
    
    public partial class city_table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public city_table()
        {
            this.hospital_TABLE = new HashSet<hospital_TABLE>();
        }
    
        public int city_id { get; set; }
        public string city_name { get; set; }
        public string state_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hospital_TABLE> hospital_TABLE { get; set; }
        public virtual city_table city_table1 { get; set; }
        public virtual city_table city_table2 { get; set; }
        public virtual city_table city_table11 { get; set; }
        public virtual city_table city_table3 { get; set; }
    }
}