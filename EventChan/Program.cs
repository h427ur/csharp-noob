using System;

class EventChan{
    //public delegate void MyEventHandler(object sender, EventArgs e);
    //event MyEventHandler MyEvent;

    public EventHandler MyEvent;

    void Method1(object sender, EventArgs e){
        Console.WriteLine("하와와왕");
    }

    public EventChan(){
        this.MyEvent += new EventHandler(Method1);
    }

    public void InvokeEvent(){
        if (MyEvent != null){
            MyEvent(this, null);
        }

    }

    public static void Main(){
        EventChan eveChan = new();
        eveChan.InvokeEvent();
    }
}