//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laymin
{
    using System;
    using System.Collections.Generic;
    
    public partial class Record
    {
        public int IdRecord { get; set; }
        public System.DateTime DateTime { get; set; }
        public int IdCabinet { get; set; }
        public int IdDoctor { get; set; }
        public int IdCard { get; set; }
    
        public virtual Cabinet Cabinet { get; set; }
        public virtual Card Card { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
