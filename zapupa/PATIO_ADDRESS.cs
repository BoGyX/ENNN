//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zapupa
{
    using System;
    using System.Collections.Generic;
    
    public partial class PATIO_ADDRESS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PATIO_ADDRESS()
        {
            this.IL_PATIO_RESTARAUNT = new HashSet<IL_PATIO_RESTARAUNT>();
        }
    
        public int ID_PATIO_ADDRESS { get; set; }
        public string PATIO_ADDRESS_STREET { get; set; }
        public string PATIO_ADDRESS_HOUSE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IL_PATIO_RESTARAUNT> IL_PATIO_RESTARAUNT { get; set; }
    }
}
