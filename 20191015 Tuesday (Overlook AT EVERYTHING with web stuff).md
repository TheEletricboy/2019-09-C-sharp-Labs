##20191015 Tuesday REVISION + SOLID

#SOLID

S single responsability - ONE CLASS DOES EXACTLY ONE THING (modeular code)
O open for extension,closed for modification (think plugin extends software but does not modify it)
L liskov: swap parent/child classes
I interfaces: Keep small ie single method
D dependency injection: design using abstract classes as good practice


#Stack and Heap and value types

Reference type
value type
stack memory
heap memory
primitive: these structures ie simple objects: in memory we declare, give it a 'type', and also store data with object in memory at the location in the stack.
	short: 			16bit or 2bytes
	int: 			32bits 4 bytes
	long:			64bits 8 bytes
	float: 			32
	double: 		64 use this for LARGEST NUMBERS POSSIBLE 10^300
	decimal: 		128 minimise rounding errors using decimals
	bit: 			1 or 0
	byte: 			8bits	
	byte[] buffer: 	used to store/carry data eg to MEMORY ON LOCAL COMPUTER FASTEST POSSIBLE STORAGE TYPE
	char			
	nibble: 		4bits 1010 hexadecimal 0-9 A-F

Operator:
	%			 	remainder
	int/int 	 	fractional division: taking a while number result: 12/7=1 ||| 100/8=12
	>>  << 		 	bit shift operator multiply/divide by 2: 5>>1 = 2
	&& 				AND (short circuit  (1==0)&&(1==1)   )
	|| 				OR
	^ 				XOR 	1^1 ==> 0    1^0=1    0^0=0

struct: 			mini class: contains only PRIMITIVES and stored ON STACK
strict: 			array of char[] 	myString[0] first letter
pass by reference:	work with pointer to object so no matter where you are working, if you alter the object you alter the root object
pass by value:		copy is independent of original

#Collection

	Array 			Index[0]
					Fixed Size IMMUTABLE
					Lightning fast to read or write because we know exact memory address
	
	List 			Varying length
					Index[n]
					Insert/remove from middle

	Arraylist		List of general OBJECT type: no index
	Queue			FIFO (first in first out)
					Enqueue 	add end of queue
					Dequeue		remove from the front of the queue
					PEEK inspect without remove first item
					Contains
	Stack 			LIFO (Rudby Ruck, last man on floor is last to get up) 	computing: running live application
					Push on
					Pop off
	Hashset 		Like a dictionary with no INDEX[0] (NO DUPLICATES)
	Linkedlist		Used for Storing large objects with ability to add/remove items very quickly in middle.
					Slow to parse but quick to add/remove
	IEnumerable		numeric index exists [n] eg array or list
	Dictionary 		AND 		definition....
					BUT 		definition....
					STRING 		STRING
					INT(key) 	STRING (value)
					Key is unique
	Generic <T> T is any type eg STRING, INT, MYCLASS

	Abstract Class: One or more abstract methods
	Abstract Method: abstract <t> DoThis();
	Interfaces: 	fully abstract, fully public properties (not fields) and methods. Public keywords missing but implied


			Class can inherit from one class/abstract class but IMPLEMENT (use) many interfaces


#Interfaces
	IQueryable 		linq query output: lazy loading ie: query not run until last possible moment when data is required.
	IEnumerable		Enumerate (count)
	IDisposable 	Databases, Files, streams OUTSIDE .net compiled runtime
					Disposable() method can be attached to these objects from outside (dynamic objects) so porgrammer can manually dispose of them.

					using (HERE){ //CODE....}
					//automatically disposed of HERE items

	class MyCollection : IEnumerable{
		GetEnumerator(){
			//return enumerator so count through collection
		}
	}
	[Serializable] ATTRIBUTE ABOVE CLASS


#Web terms

	Bootstrap: 							open source css javascript library for front end design
	Angular: 							Type-script based open source framework, good to connect backend data types
	React: 								React is a JavaScript library for building user interfaces, virtual DOM to repaint elements that have changed
	Redux:								Redux is an open-source JavaScript library for managing application state, global state of app and variables
	Vue: 								open-source JavaScript framework for building user interfaces and single-page applications, best of react and Angular
	Vuex:								Vuex is a state management pattern + library for Vue.js applications
	Indie project: 						Not backed by big company
	Synchronous: 						line by line
	Asynch: 					 		Calls subthread, continues with main thread. Call back method run when async task returns or completes	
	MVC: 								web app framework application with a model-view-controler
	Typescript .ts: 					designed for development of large applications and transcompiles to JavaScript, everything has a type
	Cordova: 							make mobile apps with html, css and js
	Nativescript						open source framework to develop apps on Android or IOS
	NodeJS								Javasript runtime environment that executes js code outside runtime
	NPM 								npm is a package manager for javascript
	Yarn								package manager for code, upgrade to NPM
	Bower 								package manager for web, handle library dependencies
	Webpack								js module bundler for easy deployment ie: into one big ZIP
	jQuery								js library html DOM tree, event handling css animations, standardize commands accross browsers
	CanIUse.com 						browser support tables for web, % of browsers that actually use a certain feature
	PHP 								hypertext language for web, most popular web server side rendering engine
	Ruby 								language usually for garbage collection 
	Python 								reliable general-purpose coding language
	NUget 								packet manager for microsoft
	#id 								one of them per webpage
	.class 								many per webpage
	Cookie 								text file sent to the server with personall info on it
	REGEX 								allows for pattern matching
	Session 							shopping basket with a timout
	API 								expose data across the web
	SPA 								single page app, 1 URL but the full app with different pages
	SAAS 								software as a service, 5$ a month for spotify
	WebSockets ws:// wss:// 			free way of sending real time chat data accorss the web
	Web Workers 						javascript background task
	Cloud 								Someone else is running a server where you loggin and use the software
	Virtual Desktop 					Log into any pc and receive the same visual experience (render at the server)
	Citrix 								Industry standard for virtual desktops
	IP 									web address 1.2.3.4
	Port 													:12345 channel inside the ip
	Protocol 							language which carries your data: TCP for the web or SMTP (email), DNS (name) HTTP (webpage)
	Razor 								C# in the browser: @for (item in items){}
	.cshtml 							razor page
	Blazor 								upgrade do Razor, basically c# in a browser at runtime
	IIS 								free microsoft web server 
	Azure 				 				Microsfot cloud
	AWS 								Amazon Cloud
	Apache 								Open source Web server
	LAMP Stack 							Linux Apache MySql PHP is how the world builds websites
	WAMP Stack 							windows...
	Open Source 						free
	MIT License 						open source license
	Cross Platform 						windows mac and linux
	MYSQL 								free sql database
	PHPMyAdmin 							payed software to manage your free SQL database
	CORS 								Cross Origin Response: Allows web requests between domains
	-ng 								angular prefix
	v-vor 								VUE element
	document.getElementById/Tag/ClassName      raw javascript to identify an element on a page
	Flexbox 							1D Layout
	Grid 								2D Layout
	MaterialUI 							Google presentation 
	VUEtify 							VUE + MaterialUI
	Mixin 								Modify SS
	Preprocessor 						pre-compile css before you use it
	Responsive menu 					big => small and it still looks good
	Collapsing menu 					a b c d  			---
	Carousel  							moving image on your main page to attract attention 
	Glyphicon 							Forward button >>, the '>>' very small icon image
	Modal popup 						Tiny window pop up to ask something eg: are you sure?
	<pre> 								html render raw text/code with all spaces intact


