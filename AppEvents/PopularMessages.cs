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
    
    public partial class PopularMessages
    {
        public int IdPopularMessages { get; set; }
        public int IdMessage { get; set; }
        public int IdPopularGroup { get; set; }
        public int Vote { get; set; }
    
        public virtual Messages Messages { get; set; }
        public virtual PopularGroups PopularGroups { get; set; }
    }
}
