//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PastebookEntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class PB_POST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PB_POST()
        {
            this.PB_COMMENT = new HashSet<PB_COMMENT>();
            this.PB_LIKE = new HashSet<PB_LIKE>();
            this.PB_NOTIFICATION = new HashSet<PB_NOTIFICATION>();
        }
    
        public int ID { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string CONTENT { get; set; }
        public int PROFILE_OWNER_ID { get; set; }
        public int POSTER_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PB_COMMENT> PB_COMMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PB_LIKE> PB_LIKE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PB_NOTIFICATION> PB_NOTIFICATION { get; set; }
        public virtual PB_USER PB_USER { get; set; }
        public virtual PB_USER PB_USER1 { get; set; }
    }
}
