using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalTickets = 0;
            double studentsTickets = 0;
            double standartsTickets = 0;
            double kidsTickets = 0;

            while (true)
            {
                string film = Console.ReadLine();
                if (film == "Finish")
                {
                    break;
                }
                int capacity = int.Parse(Console.ReadLine());
                int temp = capacity;

                double cuurentValue = 0;
                while (true)
                {
                    string ticketType = Console.ReadLine();
                    switch (ticketType)
                    {
                        case "student":
                            studentsTickets++;
                            cuurentValue++;
                            totalTickets++;
                            capacity--;
                            break;
                        case "standard":
                            standartsTickets++;
                            cuurentValue++;
                            totalTickets++;
                            capacity--;
                            break;
                        case "kid":
                            kidsTickets++;
                            cuurentValue++;
                            totalTickets++;
                            capacity--;
                            break;
                        default:
                            break;
                    }
                    if (capacity <= 0)
                    {
                        break;
                    }
                    if (ticketType == "End")
                    {
                        
                        break;
                    }
                }
                double cuurrentPercent = (cuurentValue / temp) * 100;
                Console.WriteLine($"{film} - {cuurrentPercent:f2}% full.");
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentsTickets/totalTickets)*100:f2}% student tickets.");
            Console.WriteLine($"{(standartsTickets/totalTickets)*100:f2}% standard tickets.");
            Console.WriteLine($"{(kidsTickets/totalTickets)*100:f2}% kids tickets.");
        }
    }
}
