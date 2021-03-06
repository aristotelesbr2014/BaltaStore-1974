using System.Collections.Generic;
using System.Linq;
using BaltaStore.Domain.StoreContext.ValeObject;
using FluentValidator;

namespace BaltaStore.Domain.StoreContext.Entities
{
  public class Customer : Notifiable
  {
    private readonly IList<Address> _addresses;
    private Name name;
    private Document document;
    private Email email;

    public Customer(Name name, Document document, Email email)
    {
      this.name = name;
      this.document = document;
      this.email = email;
    }

    public Customer(
      Name name,
      Document document,
      Email email,
      string phone
    )
    {
      Name = name;
      Document = document;
      Email = email;
      Phone = phone;
      _addresses = new List<Address>();
    }
    public Name Name { get; private set; }
    public Document Document { get; private set; }
    public Email Email { get; private set; }
    public string Phone { get; private set; }

    public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();

    public void AddAddresses(Address address)
    {
      _addresses.Add(address);
    }

    public override string ToString()
    {
      return Name.ToString();
    }
  }
}
