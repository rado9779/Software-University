using Telephony.Interfaces;

namespace Telephony.Models
{
    public class StationaryPhone : IStationaryPhone
    {
        public string Dialing(string number)
        {
            if (IsNumberValid(number) == false)
            {
                 return "Invalid number!";
            }
            return $"Dialing... {number}";
        }
        private bool IsNumberValid(string phoneNumber)
        {
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (!char.IsDigit(phoneNumber[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
