using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace lab_50_api_todo_list_core
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }





        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TaskItemContext>();
            // options => options.UseSqlite("Data Source = ToDoDatabase.db")
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }

    //===========================================
    public class TaskItem
    {
        public int TaskItemID { get; set; }
        [Required]
        public string Description { get; set; }
        public bool TaskDone { get; set; }

        [Display(Name = "Date Due")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DateDue { get; set; }

        //FOREIGN KEY int? means NULLABLE integer so field can be null and WON'T cause exception
        public int? UserID { get; set; } // FIELD
        public virtual User User { get; set; } // TABLE

        public int? CategoryID { get; set; } // FIELD
        public virtual Category Category { get; set; } // TABLE


    }
    public class TaskItemContext : DbContext
    {
        private static bool _dbCreated = false;
        public TaskItemContext()
        {
            if (!_dbCreated)
            {
                _dbCreated = true;
                //Database.EnsureDeleted();
                //Database.EnsureCreated();
                Trace.WriteLine("Test data");
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite(@"Data Source=ToDoDatabase.db");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Category1" },
                new Category { CategoryID = 2, CategoryName = "Category2" },
                new Category { CategoryID = 3, CategoryName = "Category3" });
            builder.Entity<User>().HasData(
                new User { UserID = 1, UserName = "User1" },
                new User { UserID = 2, UserName = "User2" },
                new User { UserID = 3, UserName = "User3" },
                new User { UserID = 4, UserName = "User4" });
            builder.Entity<TaskItem>().HasData(
                new TaskItem { TaskItemID = 1, Description = "Study", DateDue = DateTime.Parse("11/10/2019"), TaskDone = false, CategoryID = 2, UserID = 1 },
                new TaskItem { TaskItemID = 2, Description = "Work", DateDue = DateTime.Parse("10/10/2019"), TaskDone = false, CategoryID = 3, UserID = 3},
                new TaskItem { TaskItemID = 3, Description = "Do nothing", DateDue = DateTime.Parse("12/10/2019"), TaskDone = false, CategoryID = 1, UserID = 4 });
        }
        public DbSet<TaskItem> TaskItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
    }



    //seed the database

    public class User
    {
        public User()
        {
            TaskItems = new HashSet<TaskItem>();
        }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public ICollection<TaskItem> TaskItems { get; set; }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<TaskItem> TaskItems { get; set; }

        public Category()
        {
            TaskItems = new HashSet<TaskItem>();


        }
    }

    
}
