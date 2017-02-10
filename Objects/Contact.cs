using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private static List<Contact> _instances = new List<Contact>{};
    private string _name;
    private string _phoneNumber;
    private int _id;
    private List<Address> _addresses;

    public Contact(string contactName, string contactPhoneNumber)
    {
      _name = contactName;
      _phoneNumber = contactPhoneNumber;
      _instances.Add(this);
      _id = _instances.Count;
      _addresses = new List<Address>{};
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

    public void AddAddress(Address newAddress)
    {
      _addresses.Add(newAddresses);
    }
  }
}
