

The IObserver<T> and IObservable<T> interfaces provide a generalized mechanism for push-based notification, 
also known as the observer design pattern. The IObservable<T> interface represents the class that sends 
notifications (the provider); the IObserver<T> interface represents the class that receives them (the observer). 
T represents the class that provides the notification information. In some push-based notifications, the IObserver<T>
implementation and T can represent the same type.


The provider must implement a single method, Subscribe, that indicates that an observer wants to receive push-based 
notifications. Callers to the method pass an instance of the observer. The method returns an IDisposable implementation 
that enables observers to cancel notifications at any time before the provider has stopped sending them.


At any given time, a given provider may have zero, one, or multiple observers. The provider is responsible for storing 
references to observers and ensuring that they are valid before it sends notifications. The IObservable<T> interface 
does not make any assumptions about the number of observers or the order in which notifications are sent.

The provider sends the following three kinds of notifications to the observer by calling IObserver<T> methods:

    1) The current data. The provider can call the IObserver<T>.OnNext method to pass the observer a T object that 
	   has current data, changed data, or fresh data.

    2) An error condition. The provider can call the IObserver<T>.OnError method to notify the observer that some 
	   error condition has occurred.

    3) No further data. The provider can call the IObserver<T>.OnCompleted method to notify the observer that it 
	   has finished sending notifications.