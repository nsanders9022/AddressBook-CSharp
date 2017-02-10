using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private static List<Contact> _instances = new List<Contact>{};
    private string _name;
    private string _phoneNumber;
    private string _address;

    public Contact(string contactName, string contactPhoneNumber, string contactAddress)
    {
      _name = contactName;
      _phoneNumber = contactPhoneNumber;
      _address - contactAddress;
    }

    public string GetName()
    {
      return _name;
    }

    public void Setname(string aName)
    {
      _name = aName;
    }

    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }

    public void SetPhoneNumber(string aPhoneNumber)
    {
      _phoneNumber = aPhoneNumber;
    }

    public string GetAddress()
    {
      return _address;
    }

    public void SetAddress(string anAddress)
    {
      _address =  anAddress;
    }
  }
}
