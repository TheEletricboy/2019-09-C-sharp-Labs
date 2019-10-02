## Monday 20190930 Revision

#Sprint: short period of time to do work 1-4 weeks
#Sprint mettings: 

	Sprint plan: take project backlog and from it create a SPRINT BACKLOG
				 Work for future! (define tasks and 'done')
	Sprint standup: Yesterday, TODAY, Blockers
	Sprint review: (1) display result of sprint as working version

						a)MVP minimum viable product
						b)V1.0
						c)v1.1 non breaking change
						d)v2.0 breaking change
					(2) definition of done
	Sprint retro: internal analysis of team strengths, weaknesses, future imporvements etc.

	BurnUp: List of tasks done
	BurnDown: List of tasks to be done

#Agile values:
	
	values
	working code over documentation
	people over processes
	collaboration over negotiation

#Waterfall: linear lifecycle

		Good for smaller, repeatable, military, life-threatning projects
		Bad for consumer projects where business goals may shift month to month

		#SDLC: Software Development Life Cycle

			Feasability
			Requirements gathering
			Analysis
			High level design (architecture)
			low level design(specs)
			Build
			Testing
			Release
			Maintain
			Document

		V-Model: intensive testing in each stage

					Code blocks = Module = Unit = Unit testing
					Units join ==> Integration testing
					Working product ==> system testing
					User requirements ==> UAT User Acceptance Testing

#Scrum:
	
	3 Pillars (TIA): Transparency
					 Inspection
					 Adaptation

#XP Extreme: Pair programming (older)

#Kanban: 24/7 eg car factory, data bases
	
	Kanban Board: Limits active IN TASK items
				  Backlog selected in development testing approved signed off

	
	JIT just in time: reducing waste and also unused stock held


#User Story: Scenario:
					
					As a user....when I...then....
					As a user when I log in I see list of profucts
					As an admin when i log in I see list of users

#Testing: minimize defects
			Exhaustive: not possible

			Red green refractor: 1)build tests 2)build code to pass 3)optimize

			Whitebox: inner working visible: visible: fully test with this in mind
			Blackbox: inner working invisible: bisible input/output


			ALPHA: 1st release: invitation to closed group like journalist and stake holders
			Beat: pre release free for testing

			Regression: ensure latest code does not break older code

#Error: miscalculate interest on loan: logic error
#Failure: product does not meet requirements
#Exception: code crashes
		
		Handled: try..catch..finally
					try{   //dodgy code  }
					 catch(Exception e){ // handle e  }

		Unhandled: system visibly crashes


#OOP

Class: the blueprint or object
Sealed: part of code that can be inherited by derived classes
Abstract Class:	class with one or more abstract methods
Concrete: standard class with standard methods which can be instanciated
Inheritance: a derived class inherits the base class's variables and methods but can add new ones
Encapsulation: encapsulating a variable inside a class
Abstraction: using public properties to interact with encapsulated members
Polymorphism: base class values can be overwritten in derived class
Virtual: tagging a method to be overwritten ina aderived class
override: re-using objects in other objects
abstract/override: inherit from base class
Interface: a fully abstract class with absolutely no code body in the methods
overload: additional parameters added to method

