namespace TriangleTracker.Models
{
  public class Triangle

  {
    private int _side1;
    private int _side2;
    private int _side3;
    public string CheckType(int side1, int side2, int side3)
    {
      _side1 = side1;
      _side2 = side2;
      _side3 = side3;

      if ((_side1 > (_side2 + _side3)) || (_side2 > (_side1 + _side3)) || (_side3 > (_side2 + _side1)))
      {
        return "That is not a triangle";
      }
      else if ((_side1 != _side2) && (_side1 != _side3) && (_side2 != _side3))
      {
        return "What the hell this is a scalene triangle";
      }
      else if ((_side1 == _side2) && (_side1 == _side3))
      {
        return "What the hell this is a equalateral triangle";
      }
      else
      {
        return "What the hell this is an isosceles triangle";
      }
    }

  }
}