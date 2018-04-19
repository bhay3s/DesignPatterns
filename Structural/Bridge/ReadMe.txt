GOF Definition: Bridge Pattern is used to decouple an abstraction from it's implementation so that both can be modifed independently.

This pattern involes an interface which acts as a bridge between the abstraction class and implementer classes and also makes the
functionality of the implementer class independent from the abstraction class.  Both types of classes can be modified without affecting
each other.

best example for where this pattern can be used is the use of plugins or drivers.

Bridge pattern has nearly the same structure as the Adapter Pattern, however it is to be used when designing new systems instead of the 
Adapter pattern (which is used with already existing systems).

The purpose of a Bridge Pattern is to provide various implementations for a task and each of those implementations can be used
in different ways.  For example, to send a SMS or email notification to a user and send them in different ways like using a web-service
or third-party tools.
