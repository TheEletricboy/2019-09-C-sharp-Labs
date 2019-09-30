## Solid Programming Principles

Theoretical overview of good programming principles. Becomes important on larger projects where up front theoretical thinking and good practice can save a ton of re-factoring work later on.

#S = Single Responsability ie: a Class should be related to ONE OBJECT ONLY

		class Rabbit 	GOOD
		class Kitchen 	TOO VAGUE AS DIFFERENT, MUTUALLY EXCLUSIVE SUBTYPES
			kitchenOpenPlan
			kitchenClosedPlan

#O = Open/Closed

	Open for EXTENSION (ie not sealed)
	Closed for modification (ie dont mess with your original work if possible)

	Class A-Class 				parent: dont modify if possible
		Class ModelA13
		Class ModelA14			both modify original parent

#L = LISKOV: ok to replace child with parent instances


#I = Interfaces: Small ie use one method per interface

	IEnumerable: GetEnumerator (countable list with numeric index): ONE METHOD ONLY


#D Depend on Abstract Classes at top of your structure rather than real classes


SUMMARY: Reference/ Value types

	STACK 	PRIMITIVES/VALUE TYPES/ POINTERS (TO HEAP) 		FAST 	INSTANT DISPOSAL

	HEAP 	REFERENCE TYPES 								SLOWER 	Garbage collection at intervals