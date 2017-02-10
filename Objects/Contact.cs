using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private static List<Contact> _instances = new List<Contact>{};
    private string _name;
    private string _phoneNumber;
    private string _address;
    private int _id;

    public Contact(string contactName, string contactPhoneNumber, string contactAddress)
    {
      _name = contactName;
      _phoneNumber = contactPhoneNumber;
      _address = contactAddress;
      _instances.Add(this);
      _id = _instances.Count;
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

    public static List<Contact> GetAll()
    {
      return _instances;
    }

    public static void Clear()
    {
      _instances.Clear();
    }

    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public int GetId()
    {
      return _id;
    }

    public void Delete()
    {
      _instances.Remove(this);
    }
  }
}
