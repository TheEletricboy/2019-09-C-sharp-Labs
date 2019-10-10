##Tuesday 201910 APIs

#APIs

Goal for today:
	
	.NET Core

		Build API from scratch with SQLite

	Console App ==> read data as JSON

	Website ==> read data as JSON and put on site

What is an API
	
	Application Programming Interface

			Method for transfering web data across the internet

				PLAIN TEXT

				JSON { "FIELD":"VALUE"}

				XML <root><element field="value"></element></root>

			Yesterday we looked at SERIALIZING DATA TO XML AND BACK

			Today we are going to look at similar but instead of just saving a FILE as JSON
			we are going to EXPOSE ENDPOUNTS IN HTTP where a client may OBTAIN DATA

			GET 		/customers/ 	all
			GET 		/customers/10 	one with id

																GET ==> Data sent in URL visible to all

 			POST 		/customers/10 	update
 			POST 		/customers/10 	delete

 			DELETE
 			PUT(update) but depends on application: basic HTML they dont have PUT/DELETE

#Let's start with a simple MODEL pulling in NORTHWIND and using SCAFFOLDING to build API

	install-package microsoft.entityframeworkcore -v 2.1.1
												 .sqlite
												 .sqlserver
												 .design

 	and up top of the cs file we put: using Microsoft.EntityFrameworkCore;


#Consuming an API

	We are building a console app to consume or use our api

	install-package newtonsoft.json

	Getting data from the internet

		The model in use is to get data ASYNCHRONOUSLY ie wait for it.

			Main Thread ==> ASYNC CALL generates a SUB-THREAD
													ie: as TASK

			Tasks: 2 types
				1)returns VOID
				2)returns Task<t> and get data we use myTask.result

			Also tasks returning a <t> must be declared in an Async method where we await 
			the web call

				async Task<t> MyMethod


#API from Scratch: Tasks with Users and Categories

Goal 
		SQLITE
		Build database from scratch
		Entity Core with .NET Core V2.1.1 (Entity Libraries v2.1.1)
		Build API with scaffolding (ie get help)
		Build Console App with CRUD to read/write data to API

Tables
		TaskItem
			Id 
			Description
			Date
			Done
			FOREIGN KEY User
			FOREIGN KEY Category

		User
		Category

Before Add Foreign Key Relationships, Classes Look Like

```cs
public class TaskItem
    {
        public int TaskItemId { get; set; }
        [Required]
        public string Description { get; set; }
        public bool? TaskDone { get; set; }
        [Display(Name="Date Due")]      //Displays message when runs
        [DataType(DataType.Date)]       // Bring back set date only 
        [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime? DateDue { get; set; }
    }

    public class User
    {
        public int UserID { get; set; }
        [Required]
        public string Username { get; set; }

    }



    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

```

#Goals for the Afternoon

1) Think AGILE; if something is not working then always get back to minimal code which is working first.

	Tasks
		UserId
		//User User

			Users
			Categories

A) We have done MANUAL SEEDING which you can see is quite tricky. 
	C# has got SEEDING PROPER - can you get it working? If not, no bother.
			(1 hour max then move on)

	((NUGET add-migration seed01 seed02 seed03))
			update database

B) Regardless of the database relationships (Worst case can remove) or seeding (worst case just use existing seeding which we have done)

	Console Core ==> Build CRUD APP
