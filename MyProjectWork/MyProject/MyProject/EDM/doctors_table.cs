//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyProject.EDM
{
    using System;
    using System.Collections.Generic;
    
    public partial class doctors_table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public doctors_table()
        {
            this.appointment_table = new HashSet<appointment_table>();
        }
    
        public int doctor_id { get; set; }
        public string f_name { get; set; }
        public string l_name { get; set; }
        public string qualification { get; set; }
        public string speciality { get; set; }
        public string money { get; set; }

        public Nullable<int> hospital_id { get; set; }
        public string Profile { get; set; }
        public string d_gmail { get; set; }
        public string d_password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<appointment_table> appointment_table { get; set; }
        public virtual hospital_TABLE hospital_TABLE { get; set; }
    }
}
