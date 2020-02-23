namespace Telephony.Interfaces
{
    public interface ISmartphone 
    {
        string Calling(string number);
        string Browsing(string site);
    }
}
