//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zvonochek.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class RepairCertificate
    {
        public int Id { get; set; }
        public Nullable<int> Id_Client { get; set; }
        public Nullable<int> Id_Phone { get; set; }
        public Nullable<int> Id_CategoryRepair { get; set; }
        public Nullable<int> Money { get; set; }
        public Nullable<int> Id_Cons { get; set; }
    
        public virtual CategoryRepair CategoryRepair { get; set; }
        public virtual Client Client { get; set; }
        public virtual Consumables Consumables { get; set; }
        public virtual Phone Phone { get; set; }
    }
}
