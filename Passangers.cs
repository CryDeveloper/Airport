//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airport
{
    using System;
    using System.Collections.Generic;
    
    public partial class Passangers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Passangers()
        {
            this.BookedTickets = new HashSet<BookedTickets>();
        }
    
        public int ID_Passenger { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int ID_TypeDocument { get; set; }
        public string SerialrDocument { get; set; }
        public string NumberDocument { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookedTickets> BookedTickets { get; set; }
        public virtual TypesDocuments TypesDocuments { get; set; }
    }
}
