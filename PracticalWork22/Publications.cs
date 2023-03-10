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
    using System.IO;

    public partial class Publications
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Publications()
        {
            this.SubscriptionTable = new HashSet<SubscriptionTable>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Pages { get; set; }
        public double Price { get; set; }
        public string Photo { get; set; }
        public string PhotoFull
        {
            get
            {
                string namePhoto;
                if (this.Photo == null)
                    namePhoto = Directory.GetCurrentDirectory() + "\\img\\unknown.png";
                else
                    namePhoto = Directory.GetCurrentDirectory() + "\\img\\" + Photo;
                return namePhoto;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubscriptionTable> SubscriptionTable { get; set; }
    }
}
