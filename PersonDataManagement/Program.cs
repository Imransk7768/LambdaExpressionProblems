using System;

namespace PersonDataManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LAMBDA EXPRESSION Problems");
            PersonManagement personManage = new PersonManagement();
            personManage.AddDefaultData();
            Console.WriteLine("GetTopRecords Above Age 60.");
            personManage.GetTopRecords();
        }
    }
}
