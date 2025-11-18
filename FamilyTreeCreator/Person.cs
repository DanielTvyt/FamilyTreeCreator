using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeCreator
{
    internal class Person
    {
        private static int nextId = 1;
        public readonly int Id        { get; }
        public string FirstName       { get; private set; }
        public string LastName        { get; private set; }
        public DateTime? BirthDate    { get; private set; }
        public DateTime? DeathDate    { get; private set; }
        public Location BirthLocation { get; private set; }
        public Location DeathLocation { get; private set; }
        public List<Person> Parents   { get; private set; }
        public List<Person> Children  { get; private set; }
        public List<Wedding> Weddings { get; private set; }
        public List<String> Jobs      { get; private set; }
        public string Notes           { get; set; }

        public Person(string firstName, string lastName)
        {
            Id = nextId++;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = null;
            DeathDate = null;
            BirthLocation = null;
            DeathLocation = null;
            Parents = new List<Person>();
            Children = new List<Person>();
            Weddings = new List<Wedding>();
            Jobs = new List<string>();
            Notes = string.Empty;
        }
        public void AddParent(Person parent)
        {
            if (!Parents.Contains(parent))
            {
                Parents.Add(parent);
                parent.Children.Add(this);
                return;
            }
            Console.WriteLine("Parent Already Added");
        }
        public void RemoveParent(Person parent)
        {
            if (Parents.Contains(parent))
            {
                Parents.Remove(parent);
                parent.Children.Remove(this);
                return;
            }
            Console.WriteLine("Parent Not Found");
        }
        public void AddChild(Person child)
        {
            if (!Children.Contains(child))
            {
                Children.Add(child);
                child.Parents.Add(this);
                return;
            }
            Console.WriteLine("Child Already Added");
        }
        public void RemoveChild(Person child)
        {
            if (Children.Contains(child))
            {
                Children.Remove(child);
                child.Parents.Remove(this);
                return;
            }
            Console.WriteLine("Child Not Found");
        }
        public void AddBirthday(DateTime? birthDate = null, Location birthLocation = null)
        {
            if (birthDate != null)
            {
                BirthDate = birthDate;
            }
            if (birthLocation != null)
            {
                BirthLocation = birthLocation;
            }
        }
        public void AddDeath(DateTime? deathDate = null, Location deathLocation = null)
        {
            if (deathDate != null)
            {
                DeathDate = deathDate;
            }
            if (deathLocation != null)
            {
                DeathLocation = deathLocation;
            }
        }
        public void AddJob(string job)
        {
            Jobs.Add(job);
        }
        public void RemoveJob(string job)
        {
            if (!Jobs.Remove(job))
            {
                Console.WriteLine("Job Not Found");
            }
        }
        public void AddWedding(Wedding wedding)
        {
            Weddings.Add(wedding);
        }
        public void RemoveWedding(Wedding wedding)
        {
            if (!Weddings.Remove(wedding))
            {
                Console.WriteLine("Wedding Not Found");
            }
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} (ID: {Id})";
        }
    }
}
