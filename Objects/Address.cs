using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Address
  {
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;

    public Address(string addressStreet, string addressCity, string addressState, string addressZipCode)
    {
      _street = addressStreet;
      _city = addressCity;
      _state = addressState;
      _zipCode = addressZipCode;
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

    public string GetZipcode()
    {
      return _state;
    }

    public void SetZipcode(string aZipcode)
    {
      _zipCode = aZipcode;
    }


  }
}
