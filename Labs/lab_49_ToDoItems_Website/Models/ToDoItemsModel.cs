namespace lab_49_ToDoItems_Website
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ToDoItemsModel : DbContext
    {
        public ToDoItemsModel()
            : base("name=ToDoItemsModel")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ToDoItem> ToDoItems { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoItem>()
                .Property(e => e.Item)
                .IsUnicode(false);
        }
    }
}
