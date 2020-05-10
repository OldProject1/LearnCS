using System;
using System.Text;

namespace SandBox
{
    class MyArgs : EventArgs { public int DataAboutEvent { get; set; } }

    class ForEvent
    {
        public event EventHandler<MyArgs> EventAction;
        public void Press(int data) => EventAction?.Invoke(this, new MyArgs { DataAboutEvent = data });
    }

    class Button
    {
        public int Id { get; set; }
        public void OnClick(object sender, MyArgs ea) { if (ea.DataAboutEvent == Id) { Console.WriteLine($"Id = {Id}"); } }
    }

    class MyClass
    {
        static void Main(string[] args) { 
            var e = new ForEvent();
            for (int i = 0, N = 20; i < N; i++) { e.EventAction += new Button(){ Id = i }.OnClick; }
            e.Press(5);
        }
    }
}
