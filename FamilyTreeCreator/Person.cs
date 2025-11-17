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
        public readonly int Id;
        public string FirstName;
        public string LastName;
        public DateTime? BirthDate;
        public DateTime? DeathDate;
        public Location BirthLocation;
        public Location DeathLocation;
        public List<Person> Parents;
        public List<Person> Children;
        public List<Wedding> Weddings;
        public List<String> Jobs;
        public string Notes;
    }
}
