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
            personList.Add(new Person { SSN = 2, Name = "Balu", Address = "Balanagar", Age = 15 });
            personList.Add(new Person { SSN = 3, Name = "Chandra", Address = "ChandaNagar", Age = 40 });
            personList.Add(new Person { SSN = 4, Name = "Deva", Address = " Dilsukhnagar", Age = 50 });
            personList.Add(new Person { SSN = 5, Name = "Emanuel", Address = "Erragadda", Age = 16 });
            personList.Add(new Person { SSN = 6, Name = "Farja", Address = "Falaknuma", Age = 12 });
            personList.Add(new Person { SSN = 7, Name = "Gaurav", Address = "Gandipet", Age = 65 });
            personList.Add(new Person { SSN = 8, Name = "Harish", Address = " Hitec City", Age = 70 });
            personList.Add(new Person { SSN = 9, Name = "Inayat", Address = "Ibrahimpatnam", Age = 44 });
            personList.Add(new Person { SSN = 10, Name = "Jasmine", Address = "Jamia Osmania", Age = 30 });
            Display(personList);
        }
        public void CheckDataList()
        {
            if (personList.Count() == 0)
            {
                AddDefaultData();
            }
        }
        public void Display(IEnumerable<Person> list)
        {
            foreach (var person in list)
            {
                Console.WriteLine("Persons Data : {0}, {1}, {2}, {3}", person.SSN, person.Name, person.Address, person.Age);
            }
        }
        public void GetTopRecords()
        {
            if (personList.Count() == 0)
            {
                AddDefaultData();
            }
            Console.WriteLine("Get Top Records");
            var result = this.personList.Where(x => x.Age > 60);
            Display(result);
        }
        public void GetRecords()
        {
            var result = this.personList.Where(x => x.Age > 13 && x.Age < 18);
            Display(result);
        }
        public void AvarageAgeRecord()
        {
            if (personList.Count() == 0)
            {
                AddDefaultData();
            }
            Console.Write("\nAverage Age is : ");
            var result = this.personList.Average(x => x.Age);
            Console.WriteLine(result);
        }
        public void GetValue()
        {
            var result = this.personList.Where(x => x.Name == "Balu");
            if (result != null)
            {
                Console.WriteLine("Person Name is Present in the List");
            }
            else
            {
                Console.WriteLine("Person Name is Present in the List");
            }
            Display(result);
        }
        public void SkipTheRecords()
        {
            Console.WriteLine("Data Skiped");
            var result = this.personList.Skip(this.personList.Where(x => x.Age < 65).Count());
            Display(result);
        }
        public void RemoveRecord()
        {
            Person result = this.personList.Find(x => x.Name == "Farja");
            this.personList.Remove(result);
            Display(this.personList);
        }
    }
}