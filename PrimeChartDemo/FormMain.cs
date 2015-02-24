using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PrimeChartDemo
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private Chart chart1;

    private void Form1_Load(object sender, EventArgs e)
    {
      tabControl1.SelectedIndex = 3;
    }

    private void buttonCreateChartDynamically_Click(object sender, EventArgs e)
    {
      // Create a Chart
      chart1 = new Chart();

      // Create Chart Area
      ChartArea chartArea1 = new ChartArea();

      // Add Chart Area to the Chart
      chart1.ChartAreas.Add(chartArea1);

      // Create a data series
      Series series1 = new Series();
      //Series series2 = new Series();

      // Add data points to the first series
      series1.Points.Add(2);
      series1.Points.Add(3);
      series1.Points.Add(5);
      series1.Points.Add(7);
      series1.Points.Add(11);
      series1.Points.Add(13);

      // Add data points to the second series
      //series2.Points.Add(14);
      //series2.Points.Add(44);
      //series2.Points.Add(24);
      //series2.Points.Add(32);
      //series2.Points.Add(28);

      // Add series to the chart
      chart1.Series.Add(series1);
      //chart1.Series.Add(series2);

      // Set chart control location
      chart1.Location = new System.Drawing.Point(16, 48);

      // Set Chart control size
      chart1.Size = new System.Drawing.Size(360, 260);

      // Add chart control to the form

      Controls.AddRange(new Control[] { chart1 });

    }

    private void buttonFeedPrimeChart_Click(object sender, EventArgs e)
    {
      // Create Chart Area
      ChartArea chartArea2 = new ChartArea();

      // Add Chart Area to the Chart
      chartPrimeDistribution.ChartAreas.Add(chartArea2);

      // Create a data series
      Series series1 = new Series();

      // Add data points to the first series
      // read file and feed series1
      const string fileName = "PrimeNumbers.txt";
      var listPrimes = new List<int>();
      if (!File.Exists(fileName))
      {
        // create one with several first numbers
      }
      else
      {
        try
        {
          var sr = new StreamReader(fileName);
          while (!sr.EndOfStream)
          {
            listPrimes.Add(int.Parse(sr.ReadLine()));
          }

          sr.Close();
        }
        catch (Exception exception)
        {
          MessageBox.Show("error on reading file {0}: " + exception.Message, fileName);
        }
      }

      foreach (int item in listPrimes)
      {
        series1.Points.Add(item);
      }

      // Add series to the chart
      chartPrimeDistribution.Series.Add(series1);
    }

    private void ButtonClickFeedChartdizaines(object sender, EventArgs e)
    {
      // Create Chart Area
      ChartArea chartArea3 = new ChartArea();

      // Add Chart Area to the Chart
      chartDizaines.ChartAreas.Add(chartArea3);

      // Create a data series
      Series series3 = new Series();

      // Add data points to the first series
      // read file and feed series1
      const string fileName = "PrimeNumbers.txt";
      var listPrimes = new List<int>();
      if (!File.Exists(fileName))
      {
        // create one file with several first prime numbers
      }
      else
      {
        try
        {
          var sr = new StreamReader(fileName);
          while (!sr.EndOfStream)
          {
            listPrimes.Add(int.Parse(sr.ReadLine()));
          }

          sr.Close();
        }
        catch (Exception exception)
        {
          MessageBox.Show("error on reading file {0}: " + exception.Message, fileName);
        }
      }

      //counting dizaines
      Dictionary<int, int> dizaines = new Dictionary<int, int>();
      dizaines = InitDizaineDico(listPrimes[listPrimes.Count - 1]);
      dizaines = CountPrimeNumber(listPrimes, dizaines);
      foreach (var item in dizaines)
      {
        series3.Points.Add(item.Value);
      }

      // Add series to the chart
      chartDizaines.Series.Add(series3);
    }

    private Dictionary<int, int> CountPrimeNumber(List<int> listPrimes, Dictionary<int, int> dizaines)
    {
      Dictionary<int, int> resultDico = new Dictionary<int, int>();
      resultDico = dizaines;
      foreach (int item in listPrimes)
      {
        resultDico[item / 10]++;
      }

      return resultDico;
    }

    private Dictionary<int, int> InitDizaineDico(int maxNumber)
    {
      Dictionary<int, int> resultDico = new Dictionary<int, int>();
      for (int i = 0; i < maxNumber / 10; i++)
      {
        resultDico.Add(i, 0);
      }

      return resultDico;
    }
  }
}