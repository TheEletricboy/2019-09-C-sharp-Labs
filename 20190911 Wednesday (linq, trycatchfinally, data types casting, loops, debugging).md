##Wednesday(Linq, try.catch.finally, Data Types, casting, loops, debugging)

#LINQ Syntax 



#
1. Customers 
	a) All Cusotmers
	b)Filter by name or city

	Double click on one customer ==> take to panel 2 to show the orders

2. A) all orders filter by ORderID
B) Orders per customer

double click on order ==> Take to panel03 and display order details for this (read only)

3. Order details showing product, stock, unit per price 

===========================================================================================================================

##Thursday (Loops)



***SPARTA Internal interviews 'Quality Gates'
	==> Write a for loop on the WALL
	==> eg write out a fizz buzz code on the wall


## Loops

# for loop:

			FIXED NUMBER of loops 
			for(int i =0, i<=10;i++){}	//GOOD FOR arrays because you get an index automatically (i)
			for(int i =0, i<=array.length;i++){}
# ForEach: 
			Collection, for each item in that collection even if we dont know how many items are in the colection

# While: 
			while(x<10)
				may never execute

#do..while:
			do{}
			while(x<10)
			minimum execution of one time

# Break 
	
	Usefull to avoid having nested loops
```c
	//NESTED
	if(condition){
		if(othercondition){
			if(otherothercondition){
				//code
			}
		}
	}

	//USING BREAK
	if(!condition)
		break;
	if(!othercondition)
		break;
	if(!otherothercondition)
		break;
	//code
```
Break will break out of a loop completely
```c
	foreach(var c in db.customers){
		if(exitcondition){
			break;
		}
	}
	//code then starts here now

```


#RETURN 

```c
//USING RETURN
	if(!condition)
		return;
	if(!othercondition)
		return;
	if(!otherothercondition)
		return;
```

#Continue

Continue will finish this loop immediately and start the next loop straight away

```c

		for (int i = 0; i < 10; ++i)
		{
			//dont process 7
			if (i==7)
			{
				Continue;
			}
			//code
			Console.WriteLine(i);
		}
```
