//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppProjects
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lists
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lists()
        {
            this.Tasks = new HashSet<Tasks>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int Id_Project { get; set; }
        public string Note { get; set; }
        public Nullable<int> Id_Owner { get; set; }
    
        public virtual Persons Persons { get; set; }
        public virtual Projects Projects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}
