using System.Drawing;

public class Shape
{
  protected string _color;

  public Shape(string color)
  {
    _color = color;
  }

  public string GetShapeColor()
  {
    return _color;
  }

  public void SetShapeColor(string color)
  {
    _color = color;
  }

  public virtual double GetArea()
  {
    return 0;
  }
}