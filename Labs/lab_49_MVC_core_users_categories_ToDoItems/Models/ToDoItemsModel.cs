using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace lab_49_MVC_core_users_categories_ToDoItems
{
    public partial class ToDoItemsModel : DbContext
    {
        public ToDoItemsModel(DbContextOptions<ToDoItemsModel> options)
            //: base("name=ToDoItemsModel")
            : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ToDoItem> ToDoItems { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ToDoItem>()
                .Property(e => e.Item)
                .IsUnicode(false);

            //one category relates to many items
            builder.Entity<Category>().HasMany(t => t.ToDoItems).WithOne(c => c.Category);

            //CategoryName to be seen in lookups for category : ENFORCE NAME
            builder.Entity<Category>().Property(c => c.CategoryName).IsRequired();

            //enforce user name
            builder.Entity<User>().Property(u => u.UserName).IsRequired();

            //other way round : One TODO ITEM
            builder.Entity<ToDoItem>().HasOne(c => c.Category).WithMany(t => t.ToDoItems);
            builder.Entity<ToDoItem>().HasOne(u => u.User).WithMany(t => t.ToDoItems);
        }
    }
}
