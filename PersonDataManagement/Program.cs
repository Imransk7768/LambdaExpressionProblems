using System;

namespace PersonDataManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LAMBDA EXPRESSION Problems");
            PersonManagement personManage = new PersonManagement();

            bool end = true;
            Console.WriteLine("1. Add Default Values\n2. GetTopRecords");
            while (end)
            {
                Console.Write("\nChoose Option For Execute The Program\n");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        personManage.AddDefaultData();
                        break;
                    case 2:
                        personManage.GetTopRecords();
                        break;                   
                    default:
                        end = false;
                        Console.WriteLine("Program Ends.");
                        break;
                }
            }
        }
    }
}
