####Notes

##Chapter 1

#1. Arrow Functions

Looks basically like LINQ in C#

		It went from:
```js

	const foo = function foo() {
	//...
	}

```

		to:

```js
	
	const foo = () => {
	//...
	}


```

And if the function body is a one-liner, just:

			const foo = () => doSomething()


Also, if you have a single parameter, you could write:

			const foo = param => doSomething(param)

#2. THIS Scope
The this scope with arrow functions is inherited from the context.
With regular function s this always refers to the nearest function, while with arrow functions
this problem is removed, and you won't need to write "var that = this" ever again.


#3. Promise (no idea)

#4. Generators