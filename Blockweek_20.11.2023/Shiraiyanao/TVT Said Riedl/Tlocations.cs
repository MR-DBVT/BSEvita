//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TVT_Said_Riedl
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tlocations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tlocations()
        {
            this.rooms = new HashSet<rooms>();
        }
    
        public int loc_id { get; set; }
        public string name { get; set; }
        public Nullable<int> address_id { get; set; }
    
        public virtual addresses addresses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rooms> rooms { get; set; }
    }
}
