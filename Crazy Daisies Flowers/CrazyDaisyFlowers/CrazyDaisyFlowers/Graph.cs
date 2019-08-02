using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CrazyDaisyFlowers
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();            
        }

        double[] currentdata; double[] forecasts; double[] seasonalIndex;

        public Graph(double[] currentdata1, double[] forecasts1, double[] seasonalIndex1)
        {
            InitializeComponent();
            currentdata = currentdata1; forecasts = forecasts1; seasonalIndex = seasonalIndex1;
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            var Current = new Series("Current data");
            var Deseason = new Series("Deseasonalised Graph");
            var Season = new Series("Seasonalised Graph");
            chart1.Series.Add(Current);
            chart1.Series.Add(Deseason);
            chart1.Series.Add(Season);

            Current.Points.DataBindXY(new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec" }, new[] { currentdata[0], currentdata[1], currentdata[2], currentdata[3], currentdata[4], currentdata[5], currentdata[6], currentdata[7], currentdata[8], currentdata[9], currentdata[10], currentdata[11], 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            Current.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.ChartAreas[0].AxisX.Interval = 1;

            Deseason.Points.DataBindXY(new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec" }, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, forecasts[0], forecasts[1], forecasts[2], forecasts[3], forecasts[4], forecasts[5], forecasts[6], forecasts[7], forecasts[8], forecasts[9], forecasts[10], forecasts[11] });
            Deseason.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            Season.Points.DataBindXY(new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec" }, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, forecasts[0]*seasonalIndex[0], forecasts[1] * seasonalIndex[1], forecasts[2] * seasonalIndex[2], forecasts[3] * seasonalIndex[3], forecasts[4] * seasonalIndex[4], forecasts[5] * seasonalIndex[5], forecasts[6] * seasonalIndex[6], forecasts[7] * seasonalIndex[7], forecasts[8] * seasonalIndex[8], forecasts[9] * seasonalIndex[9], forecasts[10] * seasonalIndex[10], forecasts[11] * seasonalIndex[11] });
            Season.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            
        }
    }
}
