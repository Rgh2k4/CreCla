using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses
{
    public class Person
    {   
        private int personid;
        private string firstName;
        private string lastName;
        private string favoriteColour;
        private int age;
        private bool isWorking;

        public Person(int v1, string v2, string v3, string v4, int v5, string v6)
        {
        }

        public int Personid
        {
            get { return personid; }
            set { personid = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FavoriteColour
        {
            get { return favoriteColour; }
            set { favoriteColour = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public bool IsWorking
        {
            get { return isWorking; }
            set { isWorking = value; }
        }
        public void DisplayPersonInfo() 
        {
            Console.WriteLine($"{this.personid}: {this.firstName} {this.lastName}'s favorite colour is {favoriteColour}");
        }

        public void ChangeFavoriteColour()
        {
            FavoriteColour = "White";
        }

        public void GetAgeInTenYears() 
        { 
            Console.WriteLine($"{this.firstName} {this.lastName}'s age in ten years is: {age + 10}"); 
        }

        public void ToString() 
        {
            Console.WriteLine(
                $"PersonId: {this.personid}\n" +
                $"Firstname: {this.firstName}\n" +
                $"LastName: {this.lastName}\n" +
                $"FavoriteColour: {this.favoriteColour}" +
                $"Age: {this.Age}\n" +
                $"IsWorking: {this.isWorking}"
            );
        }

    }
}
