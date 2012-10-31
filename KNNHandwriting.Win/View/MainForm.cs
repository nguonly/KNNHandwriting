using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using KNNHandwriting.Win.Model;
using KNNHandwriting.Win.Service;

namespace KNNHandwriting.Win.View
{
  public partial class MainForm : Form
  {
    private readonly DataExtractionService _dataExtractionService;
    private KNNService _kNNService;

    public MainForm()
    {
      InitializeComponent();

      //Initialize services
      _dataExtractionService = new DataExtractionService();
      _kNNService = new KNNService();
    }

    private void btnClassify_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      Application.DoEvents();

      _kNNService.K = (int)numK.Value;
      var hits = 0;

      foreach (DataGridViewRow row in dgvAnalysisTesting.Rows)
      {
        double[] input = (double[])row.Cells["colTestingFeatures"].Value;
        var expected = row.Cells["colTestingExpected"].Value.ToString();

        var output = _kNNService.Classify(input);
        row.Cells["colTestingOutput"].Value = output;

        if (expected.Equals(output, StringComparison.CurrentCultureIgnoreCase))
        {
          row.Cells[0].Style.BackColor = Color.LightGreen;
          row.Cells[1].Style.BackColor = Color.LightGreen;
          row.Cells[2].Style.BackColor = Color.LightGreen;
          hits++;
        }
        else
        {
          row.Cells[0].Style.BackColor = Color.White;
          row.Cells[1].Style.BackColor = Color.White;
          row.Cells[2].Style.BackColor = Color.White;
        }
      }

      tssStatus.Text = String.Format("Classification complete. Hits: {0}/{1} ({2:0%})",
                hits, dgvAnalysisTesting.Rows.Count, (double)hits / dgvAnalysisTesting.Rows.Count);

      Cursor = Cursors.Default;
    }

    private void btnLoad_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      Application.DoEvents();


      // Load optdigits dataset into the DataGridView
      var trainingReader = new StringReader(Properties.Resources.optdigits_tra);
      var testingReader = new StringReader(Properties.Resources.optdigits_test);

      var trainingCount = 500;

      var testingCount = 500;

      dgvAnalysisSource.Rows.Clear();
      dgvAnalysisTesting.Rows.Clear();

      var trainingSet = new List<DigitData>();
      
      //Load training data
      for (var i = 0; i < trainingCount;i++ )
      {
        char[] buffer = new char[(32 + 2) * 32];
        int read = trainingReader.ReadBlock(buffer, 0, buffer.Length);
        string label = trainingReader.ReadLine();

        if (read < buffer.Length || label == null) break;

        var bitmap = _dataExtractionService.Extract(new String(buffer));
        var features = _dataExtractionService.Extract(bitmap);
        var clabel = label;
        dgvAnalysisSource.Rows.Add(bitmap, clabel, features);

        if (features != null)
          trainingSet.Add(new DigitData { Label = label, Feature = features });
      }

      //Load testing data
      for (var i = 0; i < testingCount;i++ )
      {
        char[] buffer = new char[(32 + 2) * 32];
        int read = testingReader.ReadBlock(buffer, 0, buffer.Length);
        string label = testingReader.ReadLine();

        if (read < buffer.Length || label == null) break;

        var bitmap = _dataExtractionService.Extract(new String(buffer));
        var features = _dataExtractionService.Extract(bitmap);
        var clabel = label;
        dgvAnalysisTesting.Rows.Add(bitmap, clabel, null, features);
      }

      //Assign training set to KNN Service
      _kNNService.SetTrainingSet(trainingSet);
      Cursor = Cursors.Default;
    }

    #region Use

    private void btnRecognize_Click(object sender, EventArgs e)
    {
      // Get the input vector drawn
      var input = canvas.GetDigit();

      _kNNService.K = (int)numK.Value;
      var recognizedDigit = _kNNService.Classify(input);

      lblClassifiedDigit.Text = recognizedDigit;
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      canvas.Clear();
    }

    #endregion
  }
}
