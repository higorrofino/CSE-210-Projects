public class Product
{
  private string _name;
  private int _productId;
  private double _price;
  private int _quant;

  public void SetProdName(string name)
  {
    _name = name;
  }
  public string GetProdName()
  {
    return _name;
  }
  
  public void SetProdId(int id)
  {
    _productId = id;
  }
  public int GetProdId()
  {
    return _productId;
  }
  
  public void SetProdPrice(double price)
  {
    _price = price;
  }
  public double GetProdPrice()
  {
    return _price;
  }

  public void SetQuant(int quant)
  {
    _quant = quant;
  }
  public int GetQuant()
  {
    return _quant;
  }

  public void TotalAmt()
  {
    double total = _quant * _price;
    Console.WriteLine(total);
  }
}