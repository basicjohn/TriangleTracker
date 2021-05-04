namespace TriangleTracker.Models
{
  public class Triangle

  {
    public string CheckType(int side1, int side2, int side3)
    {
      if ((side1 > (side2 + side3)) || (side2 > (side1 + side3)) || (side3 > (side2 + side1)))
      {
        return "That is not a triangle";
      }
      else
      {
        return "What the hell this is a triangle";
      }
    }
    // Console.WriteLine("Please enter the first side of your triangle: ");
    //   string firstSide = Console.ReadLine();
    // int parsedFirstSide(string firstSide)
    // {
    //   int.Parse(firstSide);
    //   // if (parsedFirstSide > 0)
    //   // {
    //   //   Console.WriteLine("above zero.");
    //   // }
    // }
  }
}