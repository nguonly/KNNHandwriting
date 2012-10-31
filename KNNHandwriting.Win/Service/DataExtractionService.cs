using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace KNNHandwriting.Win.Service
{
  public class DataExtractionService
  {
    public Bitmap Extract(string text)
    {
      var bitmap = new Bitmap(32, 32, PixelFormat.Format32bppRgb);
      var lines = text.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
      for (var i = 0; i < 32; i++)
      {
        for (var j = 0; j < 32; j++)
        {
          if (lines[i][j] == '0')
            bitmap.SetPixel(j, i, Color.White);
          else bitmap.SetPixel(j, i, Color.Black);
        }
      }
      return bitmap;
    }

    public double[] Extract(Bitmap bmp)
    {
      var features = new double[32 * 32];
      for (var i = 0; i < 32; i++)
        for (var j = 0; j < 32; j++)
          features[i * 32 + j] = (bmp.GetPixel(j, i).R == 255) ? 0 : 1;

      return features;
    }

    public double[] Preprocess(Bitmap bitmap)
    {
      var features = new double[64];

      for (var m = 0; m < 8; m++)
      {
        for (var n = 0; n < 8; n++)
        {
          var c = m * 8 + n;
          for (var i = m * 4; i < m * 4 + 4; i++)
          {
            for (var j = n * 4; j < n * 4 + 4; j++)
            {
              var pixel = bitmap.GetPixel(j, i);
              if (pixel.R == 0x00) // white
                features[c] += 1;
            }
          }
        }
      }

      return features;
    }
  }
}
