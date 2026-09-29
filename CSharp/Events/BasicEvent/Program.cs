using System;

class Publisher
{
    public event EventHandler MessageSent;

    public void Send()
    {
        MessageSent?.Invoke(this, EventArgs.Empty);
    }
}

class Program
{
    static void Main()
    {
        var p = new Publisher();
        p.MessageSent += (s, e) => Console.WriteLine("Event received.");
        p.Send();
    }
}
