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
    
    public partial class Comments
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Id_Person { get; set; }
        public System.DateTime Create_Date { get; set; }
        public System.DateTime Edit_Date { get; set; }
        public int Id_Task { get; set; }
    
        public virtual Persons Persons { get; set; }
        public virtual Tasks Tasks { get; set; }
    }
}
