using System;

namespace _04._Cinema_Voucher
{
    class Program
    {
        static void Main(string[] args)
        {
            double voucher = double.Parse(Console.ReadLine());
            int tickets = 0;
            int purchases = 0;

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                else
                {
                    if (line.Length > 8)
                    {
                            double price = line[0] + line[1];
                            if (voucher - price >= 0)
                            {
                                voucher -= price;
                                tickets++;
                            }
                            else
                            {
                                break;
                            }
                    }
                    else if (line.Length <= 8)
                    {
                        double price = line[0];
                        if (voucher - price >= 0)
                        {
                            voucher -= price;
                            purchases++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(tickets);
            Console.WriteLine(purchases);
        }
    }
}
