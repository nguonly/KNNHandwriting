using System;

namespace KNNHandwriting.Win.Model
{
  public class DigitData : IComparable
  {
    public double[] Feature { get; set; }

    public string Label { get; set; }

    public double Distance { get; set; }

    public int CompareTo(object obj)
    {
      return Distance.CompareTo(((DigitData)obj).Distance);
    }
  }
}
