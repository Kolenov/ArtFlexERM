//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySqlDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class rests
    {
        public long rest_id { get; set; }
        public long supply_id { get; set; }
        public long material_id { get; set; }
        public double rest_quantity { get; set; }
        public double rest_summ { get; set; }
        public System.DateTime rest_date { get; set; }
        public System.DateTime rest_createtime { get; set; }
    
        public virtual materials materials { get; set; }
        public virtual supplies supplies { get; set; }
    }
}
