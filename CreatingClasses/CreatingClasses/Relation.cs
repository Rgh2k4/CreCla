using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses
{
    public class Relation
    {
        public Relation(string RelationshipType)
        {
            this.RelationshipType = RelationshipType;
        }

        public string RelationshipType { get; set; }

        public void ShowRelationship(Person person1, Person person2)
        {
            Console.WriteLine($"The relationship between {person1.FirstName} and {person2.FirstName} is: {this.RelationshipType}");
        }
    }
}
