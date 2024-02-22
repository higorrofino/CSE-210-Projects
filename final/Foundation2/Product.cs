public class Product
{
  private string _name;
  private string _productId;
  private float _price;
  private int _quant;

  public Product(string name, string id, float price, int quant)
  {
    _name = name;
    _productId = id;
    _price = price;
    _quant = quant;
  }
  public string GetProdName()
  {
    return _name;
  }
  public string GetProdId()
  {
    return _productId;
  }
  public double GetProdPrice()
  {
    return _price;
  }
  public int GetQuant()
  {
    return _quant;
  }
  public float TotalAmt()
  {
    return _quant * _price;
  }
}