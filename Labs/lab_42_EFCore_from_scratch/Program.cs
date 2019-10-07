﻿using System;
using Microsoft.EntityFrameworkCore;


namespace lab_42_EFCore_from_scratch
{





    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ToDoItemContext())
            {
                var todo = new ToDoItem()
                {
                    ToDoItemName = "first task", 
                    DateCreated = DateTime.Now
                };
                db.ToDoItems.Add(todo);
                db.SaveChanges();
            }
        }
    }


    class ToDoItem
    {
        
        public int ToDoItemId { get; set; }
        public string ToDoItemName{ get; set; }
        public DateTime DateCreated{ get; set; }
    }

    //talk to db
    //NUGET: install-package microsoft.entityframeworkcore .Sqlite .Sqlserver .Design
    //-v 2.1.1
    class ToDoItemContext : DbContext
    {
        public ToDoItemContext(){
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;" + "Initial Catalog=ToDoDatabase;" + "Integrated Security=true;" + "MultipleActiveResultSets=true;");
            builder.UseSqlite("Data Source=ToDoDatabase.db");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }






}
