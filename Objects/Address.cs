using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Address
  {
    private string _type;
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;
    private static List<Address> _instances = new List<Address>{};
    private int _id;

    public Address(string addressType, string addressStreet, string addressCity, string addressState, string addressZipCode)
    {
      _type = addressType;
      _street = addressStreet;
      _city = addressCity;
      _state = addressState;
      _zipCode = addressZipCode;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetType()
    {
      return _type;
    }

    public void SetTypet(string aType)
    {
      _type = aType;
    }

    public string GetStreet()
    {
      return _street;
    }

    public void SetSteet(string aStreet)
    {
      _street = aStreet;
    }

    public string GetCity()
    {
      return _city;
    }

    public void SetCity(string aCity)
    {
      _city = aCity;
    }

    public string GetState()
    {
      return _state;
    }

    public void SetState(string aState)
    {
      _state = aState;
    }

    public string GetZipCode()
    {
      return _state;
    }

    public void SetZipcode(string aZipcode)
    {
      _zipCode = aZipcode;
    }

    public static List<Address> GetAll()
    {
      return _instances;
    }

    public int GetId()
    {
      return _id;
    }
  }
}
