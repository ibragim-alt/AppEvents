//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppEvents
{
    using System;
    using System.Collections.Generic;
    
    public partial class Messages
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Messages()
        {
            this.PopularMessages = new HashSet<PopularMessages>();
            this.Processing = new HashSet<Processing>();
        }
    
        public int IdMessage { get; set; }
        public System.DateTime Datetime { get; set; }
        public int IdUser { get; set; }
        public int IdType { get; set; }
        public string Text { get; set; }
        public int IdEvent { get; set; }
        public byte[] MediaContent { get; set; }
        public bool Processed { get; set; }
        public int IdCategory { get; set; }
    
        public virtual Categories Categories { get; set; }
        public virtual Events Events { get; set; }
        public virtual Types Types { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PopularMessages> PopularMessages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Processing> Processing { get; set; }
    }
}
