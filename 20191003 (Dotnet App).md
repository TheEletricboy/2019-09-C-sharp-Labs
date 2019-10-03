##DOT NET APP

#Which version?
Look in .csproj file

#Other Commands

dotnet build 
dotnet publish (fastest possible mode for running app)

#Equivalent of nuget

dotnet add package <<name>>

#Common
	Newtonsoft.json
	Microsoft.EntityFrameworkCore -v 2.1.1 		//stable versions
	Microsoft.EntityFrameworkCore.Sqlserver
	Microsoft.EntityFrameworkCore.Sqlite
	Microsoft.EntityFrameworkCore.Design

		==> check out .csproj file to see dependencies installed

#Using a Library

MyConsoleApp.exe

	==> get data from libraries in another place ie: myLibrary.dll

/Root/
	/Library/
		/bin/debug/library.dll
	/App/
		/bin/debug/app.exe

			from app, reference the DLL

Creating a library: 
			
			dotnet new classlib
			dotnet run //NOT ALLOWED
On the way out ==> WPF Communications

Examples:
			dotnet new wpf
			dotnet new winforms

On the way IN 

	BLAZOR ==> C# in browser

#Using Entity with .NET Core

So far we have used

	ENTITY  DATABASE FIRST ie Create database ==> pull Entity from this


We are going to now use

	ENTITY CODE FIRST ie:

		Create Models ir Customer.cs Product.cs
		Create DbContext to talk to database
		Create Connection String (location of database)

		Also optionally:

		Create Migrations (changes to our code) which can in turn cause changes to the database
		Seed the database with raw data from our C# code

Note: many companies with LEGACY CODE are using .NET Framework

But: many are using or moving to or will move to .NET Core in the future
Plus: any .NET Core work is easier in Framework

#Entity: Code First

We can use this 2 ways:

		1) Easier to get started: Code first FROM DATABASE
			a)Create SQL
			b)Create DB with data
			c)Pull into project

		2) Harder way
			a)Create models
			b)push and create database
						-from scratch initially
						-update as you go along


##Updating Database CODE FIRST:

# We run two commands
        1) NUGET
                - add-migration-initial
                - add-migration
                - update-database
        3) POWERSHELL
                - add migration
                - ...

#Lab 41 Connection String Example

	data source=(localdb)\mssqllocaldb;initial catalog=OrangeDB;integrated 
	security=True;MultipleActiveResultSets=True;App=EntityFramework

#CLASS: 
```cs
	public partial class OrangeModel : DbContext
    {
        public OrangeModel()
            : base("name=OrangeModel") 	//DATABASE NAME
        {
        }

        //DBSET NAMES THE CLASSES WHICH MATCH TABLES ie Batch class ==> Batches table
        public virtual DbSet<Batch> Batches { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Oranx> Oranges { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
```