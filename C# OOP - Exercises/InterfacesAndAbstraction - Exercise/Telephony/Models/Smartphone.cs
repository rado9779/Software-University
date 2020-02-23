using Telephony.Interfaces;

namespace Telephony.Models
{
    public class Smartphone : ISmartphone
    {
        public string Browsing(string site)
        {
            if (this.IsUrlValid(site) == false)
            {
                return "Invalid URL!";
            }
            return $"Browsing: {site}!";
        }

        public string Calling(string number)
        {
            if (this.IsNumberValid(number) == false)
            {
                return "Invalid number!";
            }
            return $"Calling... {number}";

        }

        private bool IsUrlValid(string url)
        {
            for (int i = 0; i < url.Length; i++)
            {
                if (char.IsDigit(url[i]))
                {
                    return false;
                }
            }

            return true;
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
