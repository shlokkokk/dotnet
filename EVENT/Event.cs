using System;
class Publisher { public event EventHandler Happened; public void RaiseEvent(){ Happened?.Invoke(this,EventArgs.Empty); } }
class Program { static void Main(){ var p=new Publisher(); p.Happened+=OnHappened; p.RaiseEvent(); Console.ReadKey(); } static void OnHappened(object sender,EventArgs e){ Console.WriteLine("Event handled successfully."); } }

/* THEORY / VIVA NOTES
1. An event is a notification mechanism used when an action or state change occurs.
2. Events are commonly based on delegates.
3. The publisher raises the event and the subscriber handles it.
4. += subscribes a handler to an event.
5. Events are widely used in GUI programming, such as Button Click events.
6. Here Happened is raised by Publisher and handled by OnHappened().
*/
