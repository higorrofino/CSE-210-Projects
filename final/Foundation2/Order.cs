using System.Collections.Immutable;

public class Order
{
  private string _customer;
  private float _total;
  public List<Product> _prod = new List<Product>();

  public void SetCustomer(string customer)
  {
    _customer = customer;
  }
  public void PackingLabel()
  {
    Console.WriteLine("Packing Label:");
    foreach(Product prod in _prod)
    {
      Console.WriteLine($"{prod.GetProdId()} - {prod.GetProdName()}");
    }
  }

  public void ShippingLabel(string name, string address)
  {
    Console.WriteLine("Shipping Label:");
    Console.WriteLine($"{name} - {address}");
  }

  public float OrderAmt()
  {
    float amt = 0f;

    foreach(Product prod in _prod)
    {
      amt =+ prod.TotalAmt();
    }

    _total = amt;

    return _total;
  }
}