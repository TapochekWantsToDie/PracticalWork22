//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticalWork22
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubscriptionTable
    {
        public int Id { get; set; }
        public System.DateTime SubscriptionDate { get; set; }
        public int Months { get; set; }
        public double Discount { get; set; }
        public int Publication { get; set; }
        public int Organization { get; set; }
    
        public virtual Organizations Organizations { get; set; }
        public virtual Publications Publications { get; set; }
    }
}
