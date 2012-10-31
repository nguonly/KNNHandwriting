using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KNNHandwriting.Win.Model;

namespace KNNHandwriting.Win.Service
{
  public class KNNService
  {
    private IList<DigitData> _trainingSet;
 
    public void SetTrainingSet(IList<DigitData> trainingSet)
    {
      _trainingSet = trainingSet;
    }

    public int K { get; set; }

    public string Classify(double[] testedData)
    {
      var distanceList = new List<DigitData>();
      
      //Calculating the distance
      foreach(var trainingData in _trainingSet)
      {
        trainingData.Distance = EuclideanDistance(trainingData.Feature, testedData);

        distanceList.Add(trainingData);
      }

      //Sort based on distance
      distanceList.Sort();

      var majoritySubset = new Dictionary<string, int>();

      for(var i=0;i<K;i++)
      {
        var resultClass = distanceList[i];
        
        if(majoritySubset.ContainsKey(resultClass.Label))
        {
          majoritySubset[resultClass.Label] += 1;
        }else
        {
          majoritySubset.Add(resultClass.Label, 1);
        }

        
      }

      //Find the majority class in the K subset
      var label = majoritySubset.Max(c => c.Key);
      
      return label;
    }

    private double EuclideanDistance(double[] p, double[] q)
    {
      var distance = 0.0;

      for(var i=0;i<p.Length;i++)
      {
        distance += Math.Pow(p[i] - q[i], 2);
      }

      return Math.Sqrt(distance);
    }
  }
}
