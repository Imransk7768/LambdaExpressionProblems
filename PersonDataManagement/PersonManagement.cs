using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class PersonManagement
    {
        List<Person> personList = new List<Person>();
        public void AddDefaultData()
        {
            personList.Add(new Person { SSN = 1, Name = "Ameer", Address = "Ameerpet", Age = 20 });
            personList.Add(new Person { SSN = 2, Name = "Balu", Address = "Balanagar", Age = 30 });
            personList.Add(new Person { SSN = 3, Name = "Chandra", Address = "ChandaNagar", Age = 40 });
            personList.Add(new Person { SSN = 4, Name = "Deva", Address = " Dilsukhnagar", Age = 50 });
            personList.Add(new Person { SSN = 5, Name = "Emanuel", Address = "Erragadda", Age = 60 });
            personList.Add(new Person { SSN = 6, Name = "Farja", Address = "Falaknuma", Age = 12 });
            personList.Add(new Person { SSN = 7, Name = "Gaurav", Address = "Gandipet", Age = 10 });
            personList.Add(new Person { SSN = 8, Name = "Harish", Address = " Hitec City", Age = 70 });
            personList.Add(new Person { SSN = 9, Name = "Inayat", Address = "Ibrahimpatnam", Age = 44 });
            personList.Add(new Person { SSN = 10, Name = "Jasmine", Address = "Jamia Osmania", Age = 30 });
            Display(personList);
        }
        public void Display(IEnumerable<Person> list)
        {
            foreach (var person in list)
            {
                Console.WriteLine("Persons Data : {0}, {1}, {2}, {3}", person.SSN, person.Name, person.Address, person.Age);
            }
        }
    }
}