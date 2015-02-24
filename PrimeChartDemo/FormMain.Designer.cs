namespace PrimeChartDemo
{
  partial class FormMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
      System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation2 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation3 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
      System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation4 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.buttonCreateChartDynamically = new System.Windows.Forms.Button();
      this.chartPrimeDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.buttonFeedPrimeChart = new System.Windows.Forms.Button();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPageTest = new System.Windows.Forms.TabPage();
      this.tabPageTest2 = new System.Windows.Forms.TabPage();
      this.tabPageUnit = new System.Windows.Forms.TabPage();
      this.tabPageDizaine = new System.Windows.Forms.TabPage();
      this.chartDizaines = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.tabPageCentaine = new System.Windows.Forms.TabPage();
      this.tabPageMillier = new System.Windows.Forms.TabPage();
      this.tabPagedizaineMillier = new System.Windows.Forms.TabPage();
      this.buttonFeedChartDizaines = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.chartPrimeDistribution)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPageTest.SuspendLayout();
      this.tabPageTest2.SuspendLayout();
      this.tabPageDizaine.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chartDizaines)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonCreateChartDynamically
      // 
      this.buttonCreateChartDynamically.Location = new System.Drawing.Point(16, 23);
      this.buttonCreateChartDynamically.Name = "buttonCreateChartDynamically";
      this.buttonCreateChartDynamically.Size = new System.Drawing.Size(185, 26);
      this.buttonCreateChartDynamically.TabIndex = 0;
      this.buttonCreateChartDynamically.Text = "Create chart dynamically";
      this.buttonCreateChartDynamically.UseVisualStyleBackColor = true;
      this.buttonCreateChartDynamically.Click += new System.EventHandler(this.buttonCreateChartDynamically_Click);
      // 
      // chartPrimeDistribution
      // 
      lineAnnotation1.Name = "LineAnnotation1";
      lineAnnotation2.Name = "LineAnnotation2";
      this.chartPrimeDistribution.Annotations.Add(lineAnnotation1);
      this.chartPrimeDistribution.Annotations.Add(lineAnnotation2);
      chartArea1.Name = "ChartArea1";
      this.chartPrimeDistribution.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      legend2.Name = "Legend2";
      this.chartPrimeDistribution.Legends.Add(legend1);
      this.chartPrimeDistribution.Legends.Add(legend2);
      this.chartPrimeDistribution.Location = new System.Drawing.Point(17, 75);
      this.chartPrimeDistribution.Name = "chartPrimeDistribution";
      series1.ChartArea = "ChartArea1";
      series1.Legend = "Legend1";
      series1.Name = "Series1";
      this.chartPrimeDistribution.Series.Add(series1);
      this.chartPrimeDistribution.Size = new System.Drawing.Size(1234, 708);
      this.chartPrimeDistribution.TabIndex = 1;
      this.chartPrimeDistribution.Text = "Prime Distribution";
      // 
      // buttonFeedPrimeChart
      // 
      this.buttonFeedPrimeChart.Location = new System.Drawing.Point(17, 22);
      this.buttonFeedPrimeChart.Name = "buttonFeedPrimeChart";
      this.buttonFeedPrimeChart.Size = new System.Drawing.Size(185, 26);
      this.buttonFeedPrimeChart.TabIndex = 2;
      this.buttonFeedPrimeChart.Text = "Feed Chart ";
      this.buttonFeedPrimeChart.UseVisualStyleBackColor = true;
      this.buttonFeedPrimeChart.Click += new System.EventHandler(this.buttonFeedPrimeChart_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPageTest);
      this.tabControl1.Controls.Add(this.tabPageTest2);
      this.tabControl1.Controls.Add(this.tabPageUnit);
      this.tabControl1.Controls.Add(this.tabPageDizaine);
      this.tabControl1.Controls.Add(this.tabPageCentaine);
      this.tabControl1.Controls.Add(this.tabPageMillier);
      this.tabControl1.Controls.Add(this.tabPagedizaineMillier);
      this.tabControl1.Location = new System.Drawing.Point(12, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(1316, 844);
      this.tabControl1.TabIndex = 3;
      // 
      // tabPageTest
      // 
      this.tabPageTest.Controls.Add(this.buttonCreateChartDynamically);
      this.tabPageTest.Location = new System.Drawing.Point(4, 25);
      this.tabPageTest.Name = "tabPageTest";
      this.tabPageTest.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageTest.Size = new System.Drawing.Size(1308, 815);
      this.tabPageTest.TabIndex = 0;
      this.tabPageTest.Text = "test";
      this.tabPageTest.UseVisualStyleBackColor = true;
      // 
      // tabPageTest2
      // 
      this.tabPageTest2.Controls.Add(this.buttonFeedPrimeChart);
      this.tabPageTest2.Controls.Add(this.chartPrimeDistribution);
      this.tabPageTest2.Location = new System.Drawing.Point(4, 25);
      this.tabPageTest2.Name = "tabPageTest2";
      this.tabPageTest2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageTest2.Size = new System.Drawing.Size(1308, 815);
      this.tabPageTest2.TabIndex = 1;
      this.tabPageTest2.Text = "Test2";
      this.tabPageTest2.UseVisualStyleBackColor = true;
      // 
      // tabPageUnit
      // 
      this.tabPageUnit.Location = new System.Drawing.Point(4, 25);
      this.tabPageUnit.Name = "tabPageUnit";
      this.tabPageUnit.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageUnit.Size = new System.Drawing.Size(1308, 815);
      this.tabPageUnit.TabIndex = 2;
      this.tabPageUnit.Text = "Unités";
      this.tabPageUnit.UseVisualStyleBackColor = true;
      // 
      // tabPageDizaine
      // 
      this.tabPageDizaine.Controls.Add(this.buttonFeedChartDizaines);
      this.tabPageDizaine.Controls.Add(this.chartDizaines);
      this.tabPageDizaine.Location = new System.Drawing.Point(4, 25);
      this.tabPageDizaine.Name = "tabPageDizaine";
      this.tabPageDizaine.Size = new System.Drawing.Size(1308, 815);
      this.tabPageDizaine.TabIndex = 3;
      this.tabPageDizaine.Text = "Dizaines";
      this.tabPageDizaine.UseVisualStyleBackColor = true;
      // 
      // chartDizaines
      // 
      lineAnnotation3.Name = "LineAnnotation1";
      lineAnnotation4.Name = "LineAnnotation2";
      this.chartDizaines.Annotations.Add(lineAnnotation3);
      this.chartDizaines.Annotations.Add(lineAnnotation4);
      chartArea2.Name = "ChartArea1";
      this.chartDizaines.ChartAreas.Add(chartArea2);
      legend3.Name = "Legend1";
      legend4.Name = "Legend2";
      this.chartDizaines.Legends.Add(legend3);
      this.chartDizaines.Legends.Add(legend4);
      this.chartDizaines.Location = new System.Drawing.Point(37, 53);
      this.chartDizaines.Name = "chartDizaines";
      series2.ChartArea = "ChartArea1";
      series2.Legend = "Legend1";
      series2.Name = "Series1";
      this.chartDizaines.Series.Add(series2);
      this.chartDizaines.Size = new System.Drawing.Size(1234, 708);
      this.chartDizaines.TabIndex = 2;
      this.chartDizaines.Text = "Prime Distribution";
      // 
      // tabPageCentaine
      // 
      this.tabPageCentaine.Location = new System.Drawing.Point(4, 25);
      this.tabPageCentaine.Name = "tabPageCentaine";
      this.tabPageCentaine.Size = new System.Drawing.Size(1308, 815);
      this.tabPageCentaine.TabIndex = 4;
      this.tabPageCentaine.Text = "Centaines";
      this.tabPageCentaine.UseVisualStyleBackColor = true;
      // 
      // tabPageMillier
      // 
      this.tabPageMillier.Location = new System.Drawing.Point(4, 25);
      this.tabPageMillier.Name = "tabPageMillier";
      this.tabPageMillier.Size = new System.Drawing.Size(1308, 815);
      this.tabPageMillier.TabIndex = 5;
      this.tabPageMillier.Text = "Milliers";
      this.tabPageMillier.UseVisualStyleBackColor = true;
      // 
      // tabPagedizaineMillier
      // 
      this.tabPagedizaineMillier.Location = new System.Drawing.Point(4, 25);
      this.tabPagedizaineMillier.Name = "tabPagedizaineMillier";
      this.tabPagedizaineMillier.Size = new System.Drawing.Size(1308, 815);
      this.tabPagedizaineMillier.TabIndex = 6;
      this.tabPagedizaineMillier.Text = "Dizaines de milliers";
      this.tabPagedizaineMillier.UseVisualStyleBackColor = true;
      // 
      // buttonFeedChartDizaines
      // 
      this.buttonFeedChartDizaines.Location = new System.Drawing.Point(37, 21);
      this.buttonFeedChartDizaines.Name = "buttonFeedChartDizaines";
      this.buttonFeedChartDizaines.Size = new System.Drawing.Size(185, 26);
      this.buttonFeedChartDizaines.TabIndex = 3;
      this.buttonFeedChartDizaines.Text = "Feed Chart ";
      this.buttonFeedChartDizaines.UseVisualStyleBackColor = true;
      this.buttonFeedChartDizaines.Click += new System.EventHandler(this.ButtonClickFeedChartdizaines);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1340, 868);
      this.Controls.Add(this.tabControl1);
      this.Name = "Form1";
      this.Text = "Charts demo for Prime Distribution";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.chartPrimeDistribution)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPageTest.ResumeLayout(false);
      this.tabPageTest2.ResumeLayout(false);
      this.tabPageDizaine.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.chartDizaines)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonCreateChartDynamically;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartPrimeDistribution;
    private System.Windows.Forms.Button buttonFeedPrimeChart;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPageTest;
    private System.Windows.Forms.TabPage tabPageTest2;
    private System.Windows.Forms.TabPage tabPageUnit;
    private System.Windows.Forms.TabPage tabPageDizaine;
    private System.Windows.Forms.TabPage tabPageCentaine;
    private System.Windows.Forms.TabPage tabPageMillier;
    private System.Windows.Forms.TabPage tabPagedizaineMillier;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartDizaines;
    private System.Windows.Forms.Button buttonFeedChartDizaines;
  }
}

