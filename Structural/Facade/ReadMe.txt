GOF Definition: 

Use Cases:
1) When you have a class or a group of classes that are complex to work with.  Create a Facade/wrapper around all
	the complexity inorder to expose a simple API to the client code.

2) When you want to hide the implemetation of third-party libraries - especially if they may change over time.
	Many libraries are updated at least ocne a year.  Occasionally an update has breaking changes.  If there are multiple
	projects, say 10, that use the third party interface directly, all 10 of those projects need to be updated/tested vs updating a single API which
	is used across 10 projects.