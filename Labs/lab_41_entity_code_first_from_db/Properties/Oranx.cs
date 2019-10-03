namespace lab_41_entity_code_first_from_db.Properties
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Oranx
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Oranx()
        {
            Batches = new HashSet<Batch>();
        }

        [Key]
        public int OrangeId { get; set; }

        [StringLength(50)]
        public string OrangeName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateHarvested { get; set; }

        public bool? isLuxuryGrade { get; set; }

        public int? CategoryId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Batch> Batches { get; set; }

        public virtual Category Category { get; set; }
    }
}
