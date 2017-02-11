using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["index.cshtml", allContacts];
      };

      Get["/contact/add"] = _ => {
        return View["contact_form.cshtml"];
      };

      Get["/contact/new"] = _ => {
        return View["new_contact.cshtml"];
      };

      Get["/contact/{id}"] = parameters => {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Contact contact = Contact.Find(parameters.id);
        // List<Address> allAddresses = contact.GetAddress();
        var addressList = contact.GetAddress();
        model.Add("person", contact);
        model.Add("addresses", addressList);
        return View["contact.cshtml", model];
      };

      Get["{id}/address/new"] = parameters => {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Contact contact = Contact.Find(parameters.id);
        List<Address> allAddresses = contact.GetAddress();
        model.Add("person", contact);
        model.Add("addresses", allAddresses);
        return View["add_address.cshtml", model];
      };

      Post["/contact/new_address"] = _ => {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Contact contact = Contact.Find(Request.Form["contact-id"]);
        List<Address> allAddresses = contact.GetAddress();
        string newType = Request.Form["new-type"];
        string newStreet = Request.Form["new-street"];
        string newCity = Request.Form["new-city"];
        string newState = Request.Form["new-state"];
        string newZipCode = Request.Form["new-zip-code"];
        Address newAddress = new Address(newType, newStreet, newCity, newState, newZipCode);
        allAddresses.Add(newAddress);
        model.Add("person", contact);
        model.Add("addresses", allAddresses);
        return View["contact.cshtml", model];
      };

      Post["/contact/new"] = _ => {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-phone-number"]);
        List<Address> allAddresses = newContact.GetAddress();
        string newType = Request.Form["new-type"];
        string newStreet = Request.Form["new-street"];
        string newCity = Request.Form["new-city"];
        string newState = Request.Form["new-state"];
        string newZipCode = Request.Form["new-zip-code"];
        Address newAddress = new Address(newType, newStreet, newCity, newState, newZipCode);
        allAddresses.Add(newAddress);
        model.Add("person", newContact);
        model.Add("addresses", allAddresses);
        return View["contact.cshtml", model];
      };

      Post["/"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-phone-number"]);
        List<Contact> allContacts = Contact.GetAll();
        return View["index.cshtml", allContacts];
      };

      Post["/"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["index.cshtml", allContacts];
      };

      Get["/contacts/clear"] = _ => {
        return View["clear.cshtml"];
      };

      Post["/contacts/clear"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        allContacts.Clear();
        return View["clear.cshtml"];
      };

      Post["/contact/delete/{id}"] = parameters => {
        Contact contact = Contact.Find(parameters.id);
        contact.Delete();
        List<Contact> allContacts = Contact.GetAll();
        return View["index.cshtml",allContacts];
      };

      Get["/contact/search"] = _ => {
        return View["search_form.cshtml"];
      };

      Post["/contact/search_results"] = _ => {
        Contact selectedContact = Contact.SearchContact(Request.Form["search-name"]);
        return View["contact.cshtml", selectedContact];
      };
    }
  }
}
