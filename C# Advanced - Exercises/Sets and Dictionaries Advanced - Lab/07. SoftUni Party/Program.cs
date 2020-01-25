using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipReservationList = new HashSet<string>();
            HashSet<string> regularReservationList = new HashSet<string>();

            while (true)
            {
                string reservation = Console.ReadLine();

                if (reservation == "PARTY")
                {
                    break;
                }

                if (reservation.Length == 8)
                {
                    //Vip Or Not
                    if (char.IsDigit(reservation[0]))
                    {
                        vipReservationList.Add(reservation);
                    }
                    else
                    {
                        regularReservationList.Add(reservation);
                    }
                }

            }

            while (true)
            {
                string reservation = Console.ReadLine();

                if (reservation == "END")
                {
                    break;
                }

                if (vipReservationList.Contains(reservation))
                {
                    vipReservationList.Remove(reservation);
                }
                else
                {
                    regularReservationList.Remove(reservation);
                }
            }

            Console.WriteLine(vipReservationList.Count + regularReservationList.Count);
            foreach (var vip in vipReservationList)
            {
                Console.WriteLine(vip);
            }
            foreach (var regulars in regularReservationList)
            {
                Console.WriteLine(regulars);
            }
        }
    }
}
