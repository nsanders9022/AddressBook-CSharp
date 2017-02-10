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
        Contact contact = Contact.Find(parameters.id);
        return View["contact.cshtml", contact];
      };

      Post["/contact/new"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-phone-number"], Request.Form["new-address"]);
        return View["contact.cshtml", newContact];
      };

      Post["/"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-phone-number"], Request.Form["new-address"]);
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
    }
  }
}
