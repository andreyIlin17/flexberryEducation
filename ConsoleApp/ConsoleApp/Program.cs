using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите идентификатор ведомства");
            string departId = Console.ReadLine();

            string complaintDate = DateTime.Now.ToString("d");

            int complaintId = 1;

            var cs = new IdGenerator(departId, complaintId);

            string result = cs.CreateId(cs.DepartId, complaintDate, cs.ComplaintId);

            Console.WriteLine($"Уникальный идентификатор жалобы: {result}");

        }
    }
}
