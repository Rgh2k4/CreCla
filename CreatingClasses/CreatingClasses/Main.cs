using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace CreatingClasses
{
    public class Main
    {
        
            static string Young(List<Person> personlist, int[] ageArray)
            {
                var youngQuery = from person in personlist where person.Age == ageArray.Min() select person.FirstName;
                var youngPerson = youngQuery.First().ToString();
                return youngPerson;
            }

            static string Old(List<Person> personList, int[] ageArray)
            {
                var oldQuery = from person in personList where person.Age == ageArray.Max() select person.FirstName;
                var oldPerson = oldQuery.First().ToString();
                return oldPerson;
            }

            static double AvgAge(int[] ageArray)
            {
            double ageTot = 0;
                foreach (int age in ageArray)
                {
                    ageTot += age;
                }
                double avgAge = ageTot / ageArray.Count();
                return avgAge;
            }

        static void Maine(string[] args)
        {
            Person Ian = new Person(1, "Ian", "Brooks", "Red", 30, "True");
            Person Gina = new Person(2, "Gina", "James", "Green", 18, "False");
            Person Mike = new Person(3, "Mike", "Briscoe", "Blue", 45, "True");
            Person Mary = new Person(4, "Mary", "Beals", "Yellow", 28, "True");

            List<Person> personlist = new List<Person>();
            personlist.Add(Ian);
            personlist.Add(Gina);
            personlist.Add(Mike);
            personlist.Add(Mary);

            Gina.DisplayPersonInfo();

            Mike.ToString();

            Ian.ChangeFavoriteColour();

            Ian.DisplayPersonInfo();

            Mary.GetAgeInTenYears();

            Relation Brother = new Relation("Bro");
            Brother.ShowRelationship(Ian, Mike);
            Relation Sister = new Relation("Sis");
            Sister.ShowRelationship(Gina, Mary);

            var ageQuery = from person in personlist select person.Age;
            int[] ageArray = ageQuery.ToArray();

            Console.WriteLine($"The average age is: {AvgAge}");

            Console.WriteLine($"The youngest person is: {Young(personlist, ageArray)}");
            Console.WriteLine($"The oldest person is: {Old(personlist, ageArray)}");

            var MQuery = from person in personlist where person.FirstName.StartsWith("M") select person;
            foreach (var person in MQuery)
            {
                Console.WriteLine(person.FirstName);
            }

            var bluQuery = from person in personlist where person.FavoriteColour.Contains("Blue") select person;
            foreach (var person in bluQuery)
            {
                Console.WriteLine(person.FavoriteColour);
            }

            Console.ReadKey();
            

        }
    }
}
