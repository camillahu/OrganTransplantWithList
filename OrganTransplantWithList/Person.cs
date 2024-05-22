using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganTransplantWithList
{
    internal class Person
    {
        public string Name;
        public List<Kidney> Kidneys;
        public bool IsDonor;

        public Person(string name, bool isHealthy, bool isDonor)
        {
            Name = name;
            Kidneys = new List<Kidney>();
            if (isHealthy)
            {
                HasHealthyKidneys();
            }
            else
            {
                HasUnhealthyKidneys();
            }
        }

        public void HasHealthyKidneys()
        {
            Kidneys.Add(new Kidney(true));
            Kidneys.Add(new Kidney(true));
        }

        public void HasUnhealthyKidneys()
        {
            Kidneys.Add(new Kidney(false));
            Kidneys.Add(new Kidney(false));
        }


        public void SetIsDonor(Person donor)
        {
            donor.IsDonor = true;
            Thread.Sleep(1000);
            Console.WriteLine($"Great choice! {Name} is now getting ready for the surgery.");
            Thread.Sleep(1000);
        }


        public void GiveKidney(Person receiver)
        {   
            receiver.ReceiveKidney(Kidneys[0]);
            Kidneys.RemoveAt(0);
            Console.WriteLine($"The surgery was successful! {Name} now has only one functioning kidney.");
            Console.WriteLine($"Tap any key to continue on to {receiver.Name}'s surgery!");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"{receiver.Name} had both his unhealthy kidneys removed to make space for the new one.");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine($"The surgery was successful! {receiver.Name} lives to see another day!");
        }

        public void ReceiveKidney(Kidney donatedKidney)
        {
            Kidneys.RemoveAt(1);
            Kidneys.RemoveAt(0);
            Kidneys.Add(donatedKidney);
        }
    }
}
