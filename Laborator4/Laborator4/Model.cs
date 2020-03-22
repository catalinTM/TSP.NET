using System;
using System.Collections.Generic;

namespace Laborator4
{
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }

    public partial class Order
    {
        public int OrderId { get; set; }
        public decimal TotalValue { get; set; }
        public System.DateTime Date { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }

}
