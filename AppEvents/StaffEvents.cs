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
    
    public partial class StaffEvents
    {
        public int IdStaffEvent { get; set; }
        public int IdStaff { get; set; }
        public int IdEvent { get; set; }
    
        public virtual Events Events { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
