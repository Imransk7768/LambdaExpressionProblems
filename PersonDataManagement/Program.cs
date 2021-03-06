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
            Console.WriteLine("1. Add Default Values\n2. GetTopRecords\n3. Get Records Btw Age 13-18\n4. Average Age\n5. Check Record Prasent or Not" +
                "\n6. Skip the Data in List");
            while (end)
            {
                Console.Write("\nChoose Option For Execute The Program : ");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        personManage.AddDefaultData();
                        break;
                    case 2:
                        personManage.GetTopRecords();
                        break;
                    case 3:
                        personManage.AddDefaultData();
                        Console.WriteLine("\nRecords Between Age 13-18 are : ");
                        personManage.GetRecords();
                        break;
                    case 4:
                        //personManage.AddDefaultData();
                        personManage.AvarageAgeRecord();
                        break;
                    case 5:
                        personManage.CheckDataList();
                        personManage.GetValue();
                        break;
                    case 6:
                        personManage.CheckDataList();
                        personManage.SkipTheRecords();
                        break;
                    case 7:
                        personManage.CheckDataList();
                        personManage.RemoveRecord();
                        Console.WriteLine("Record Removed.");
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
