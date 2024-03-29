namespace lab_49_ToDoItems_Website
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            ToDoItems = new HashSet<ToDoItem>();
        }

        public int UserId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public DateTime LastLoggedIn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ToDoItem> ToDoItems { get; set; }
    }
}
