##20191004 Friday 

#Entity Core
Lab_42

Today we are going to build
		ENTITY CORE USING CODE FIRST MODEL

			TodoApp:
```cs
				ToDoItem{
					ToDoItemId
					ToDoItemName
					DateCreated
				}

				Category{
					CategoryId
					CategoryName
				}
```

					==> Add CategoryId as FOREIGN KEY

		.NET Core is in a state of Flux (change)

		.NET Core v 2.1 (Website) and Entity Libraries -v 2.1.1



===================================================================

>Things to watch out for:

	1)Initial create of database
		(NUGET) add-migration initial
				update-database

	2)Change
	3)Relationships
			FluentAPI ==> langugage to describe database fields and mandatory/interlinking columns

	??) Seeding data (automatically add initial data eg auto add categories and some initial tasks)


===================================================================



#Goal for today:

	EFCore app and start the ASP Web version of this also, depending on time


#Version 1: .NET Core: Using both Sqlserver and Sqlite. No database relationships




##ASP Core Website with Entity

Let's move our learning forwards.

	Critical learning for the course

		Basic HTML/Css ==> Done (enough)
		Javascript: minimal
				(possible upgrade)
		Bootstrap: need to play around with
		Entity with Linq: done apart from advanced LINQ
		Entity Core: started today
		Generating and migrating databases: minimal today ==> can do more
		API: started
		ASP: Simple website
		MVC:done a good but, can develop

New ASP Site v 2.1 and RFCore libraries 2.1.1



##Adding libraries using powershell 


dotnet add package microsoft.entityframeworkcore -v 2.1.1	


##Adding pages

Note:

	ASP Web ==> 2 files per page 		.cshtml as root
										.cshtml.cs with raw c# code 'behind' the page

	MVC ==> 1 file per page  			.cshtml

	Shared\_Layout page has all the sahred layout

	_means private ie: cannot view this page directly; only via another page

	Startup.cs
		set basis fro website
		Install all libraries
		Can configure global access to database (later on for our learning 'injecting context' from database into our app)

	UseStaticFiles()
		wwwroot global folder with all non-secure data

				 CSS
				 Images
				 JS Libraries eg Bootstrap

	Database Connection Strings
		1)App.Config (core only)
		2)Web.Config (a bit older)
		3)appsetiings.json (a bit newer)

	Pages
		index.cshtml
		..

	Models
		Customer.cs
		..

	C# in the Webpage is called RAZOR

	@page is required first line ==> makes it a RAZOR page other wise its just RAW HTML

	@model referes to Data in C# TWIN PAGE

	@Model is then used in the RAZOR to access the data

	ViewData/ViewBag are ARRAY OF STRINGS to push trivial data on any page