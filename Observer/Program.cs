using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();

            subject.Attach(new ConcreteObserver(subject, "Object1"));
            subject.Attach(new ConcreteObserver(subject, "Object2"));
            subject.Attach(new ConcreteObserver(subject, "Object3"));

            // Change subject and notify observers
            subject.SubjectState = "NEW STATE";
            subject.Notify();

            // Wait for user
            Console.ReadKey();
        }
    }    
}
