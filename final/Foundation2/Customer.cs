public class Customer
{
  private string _firstName;
  private string _lastName;

  public Customer(string fName, string lName)
  {
    _firstName = fName;
    _lastName = lName;
  }

  public string FullName()
  {
    return $"{_firstName} {_lastName}";
  }
}