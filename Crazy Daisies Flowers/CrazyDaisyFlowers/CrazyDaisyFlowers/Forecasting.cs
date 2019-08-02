using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Data.OleDb;


// Import Database(DB) Objects 

namespace CrazyDaisyFlowers
{
    public partial class Forecasting : Form
    {
        public OleDbCommand command;
        public OleDbDataReader reader;
        string directory = System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString();

        // Objects for Database(DB) objects instantiated 
        

        // variable for DB file
        
        double totalAverage = 0;

        double january_Average = 0;
        double february_Average = 0;
        double march_Average = 0;
        double april_Average = 0;
        double may_Average = 0;
        double june_Average = 0;
        double july_Average = 0;
        double august_Average = 0;
        double september_Average = 0;
        double october_Average = 0;
        double november_Average = 0;
        double december_Average = 0;

        // Variables for the the months and averages 

        double[] seasonalIndex = new double[12];
        double[] currentdata = new double[12];

        // Seasonal Index variables 

        double calcTest1 = 0;



        // Variables for Seaonalized Post- data

        //###############################// 

        // varibales for DB queries

        OleDbConnection myDB;

        string constr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";

        // Create and instantiate connection 

        public Forecasting()
        {
            InitializeComponent();

            comboBox1Forecast.SelectedIndex = 0;

            myDB = new OleDbConnection(constr + directory + @"\ITRW 325.accdb");
            // Opening the DB File
        }



        //#########################################  CALCULATES THE YEAR AVERAGE FROM JANUARY 2015 - SEPTEMBER 2018 #################// 

        public void averageAmount_Year()
        {
            try
            {
               myDB.Open();

                OleDbCommand cmd = new OleDbCommand(@"SELECT AVG(Amount) FROM Forecasting WHERE Forecast_Year > 2014 and Forecast_Year < 2019 ", myDB);
                OleDbDataReader read = cmd.ExecuteReader();
                
                if (read.Read())
                {
                    totalAverage = read.GetDouble(0);
                }
                myDB.Close();
            }
            catch { }

        }

        public void averageAmounts()
        {
            try
            {
                myDB.Open();

                OleDbCommand cmd = new OleDbCommand(@"SELECT AVG(Amount), Forecast_Month FROM Forecasting GROUP BY Forecast_Month", myDB);
                OleDbDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    try
                    {
                        switch (reader.GetValue(1).ToString())
                        {

                            case "January":
                                january_Average = reader.GetDouble(0);
                                break;
                            case "February":
                                february_Average = reader.GetDouble(0);
                                break;
                            case "March":
                                march_Average = reader.GetDouble(0);
                                break;
                            case "April":
                                april_Average = reader.GetDouble(0);
                                break;
                            case "May":
                                may_Average = reader.GetDouble(0);
                                break;
                            case "June":
                                june_Average = reader.GetDouble(0);
                                break;
                            case "July":
                                july_Average = reader.GetDouble(0);
                                break;
                            case "August":
                                august_Average = reader.GetDouble(0);
                                break;
                            case "September":
                                september_Average = reader.GetDouble(0);
                                break;
                            case "October":
                                october_Average = reader.GetDouble(0);
                                break;
                            case "November":
                                november_Average = reader.GetDouble(0);
                                break;
                            case "December":
                                december_Average = reader.GetDouble(0);
                                break;
                        }
                    } catch (Exception) { }
                }
                myDB.Close();
            }
            catch (Exception e)
            {
                myDB.Close(); MessageBox.Show(e.Message); }
        }
        


        public void calculateSeasonalIndex()

        {

            seasonalIndex[0] = january_Average / totalAverage;

            seasonalIndex[1] = february_Average / totalAverage;

            seasonalIndex[2] = march_Average / totalAverage;

            seasonalIndex[3] = april_Average / totalAverage;

            seasonalIndex[4] = may_Average / totalAverage;

            seasonalIndex[5] = june_Average / totalAverage;

            seasonalIndex[6] = july_Average / totalAverage;

            seasonalIndex[7] = august_Average / totalAverage;

            seasonalIndex[8] = september_Average / totalAverage;

            seasonalIndex[9] = october_Average / totalAverage;

            seasonalIndex[10] = november_Average / totalAverage;

            seasonalIndex[11] = december_Average / totalAverage;

            // Calculate the SeasonalIndex for each mmonth 

            //..... SEASONALIZED INDEX

            // ....................

            // ..............

            // .........
        }



        // ######################### DESEAONLIZED DATA W/ CALCULATIONS #############################//

        double[,] deseasonalizedData = new double[12,4];

        public void calculateDeSeasonalizedData()
        {
            try
            {
                for (int i = 0; i < 12; i++)
                    for (int j = 0; j < 4; j++)
                        deseasonalizedData[i, j] = 0;

                myDB.Open();
                OleDbCommand cmd = new OleDbCommand(@"SELECT (Amount), Forecast_Year, Forecast_Month FROM Forecasting ORDER BY Forecast_Year, Forecast_Month", myDB);
                OleDbDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    //MessageBox.Show($@"Year: {reader.GetValue(1)} Month: {reader.GetValue(2)}, Value: {reader.GetValue(0)}");
                    try
                    {
                        int m = 0;
                        switch (reader.GetValue(2).ToString())
                        {
                            case "January":
                                m = 0;
                                break;
                            case "February":
                                m = 1;
                                break;
                            case "March":
                                m = 2;
                                break;
                            case "April":
                                m = 3;
                                break;
                            case "May":
                                m = 4;
                                break;
                            case "June":
                                m = 5;
                                break;
                            case "July":
                                m = 6;
                                break;
                            case "August":
                                m = 7;
                                break;
                            case "September":
                                m = 8;
                                break;
                            case "October":
                                m = 9;
                                break;
                            case "November":
                                m = 10;
                                break;
                            case "December":
                                m = 11;
                                break;
                        }
                        if (Convert.ToInt32(reader.GetValue(1).ToString()) == 2018)
                            currentdata[m] = Convert.ToDouble(reader.GetValue(0).ToString());
                        deseasonalizedData[m, (Convert.ToInt32(reader.GetValue(1).ToString()) - 2015)] = (Convert.ToDouble(reader.GetValue(0).ToString()) / seasonalIndex[m]);
                    } catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                myDB.Close();
            }
            catch (Exception) { }
        }
        







        //######################### CALCULATE FORECAST JANUARY 2019 ###############################//

        public void calc(int val)
        {
            // Linear Regression 

            double[] values = new double[deseasonalizedData.Length];

            try
            {
                for (int p = 0; p < 4; p++)
                    for (int q = 0; q < 12; q++)
                    {
                        if (deseasonalizedData[q, p] == 0)
                            throw new Exception();
                        values[12 * p + q] = deseasonalizedData[q, p];
                    }
            } catch (Exception ex) { MessageBox.Show(ex.Message); }

            double x_average = 0;
            double y_average = 0;

            for (int x = 0; x < values.Length; x++)
            {
                x_average += x;
                y_average += values[x];
            }

            x_average = x_average / values.Length;
            y_average = y_average / values.Length;

            double zl1 = 0;

            double zl2 = 0;

            for (int x = 0; x < values.Length; x++)
            {
                zl1 += (x - x_average) * (values[x] - y_average);
                zl2 += Math.Pow(x - x_average, 2);
            }

            double s = zl1 / zl2;

            double i = y_average - s * x_average;



            lblAverage.Text = "The Intercept is: " + Convert.ToString(Math.Round(i,2));

            lblTest.Text = "The Slope is: " + Convert.ToString(Math.Round(s,2));

            // double deseasonalizedDataJanuary2019 = 0;
            calcTest1 = i + (s * (48+ val));

            //MessageBox.Show(Convert.ToString("Sales Forecast: " + calcTest1));

            label2.Text = "Sales Forecast: " + Math.Round(calcTest1,2);
        }


        //######################### CALCULATE FORECAST Per Month from 0 to 11 ###############################//
        

        // ################## New Seasonalized Calculations ### ////////////////////

        public void newSeason(int period)
        {
            string temp = "Seasonalized data for ";
            switch (period+1)
            {
                case 1: temp += "January 2019";
                    break;
                case 2: temp += "February 2019";
                    break;
                case 3: temp += "March 2019";
                    break;
                case 4: temp += "April 2019";
                    break;
                case 5: temp += "May 2019";
                    break;
                case 6: temp += "June 2019";
                    break;
                case 7: temp += "July 2019";
                    break;
                case 8: temp += "August 2019";
                    break;
                case 9: temp += "September 2019";
                    break;
                case 10: temp += "October 2019";
                    break;
                case 11: temp += "November 2019";
                    break;
                case 12: temp += "December 2019";
                    break;
                case 13: temp += "January 2020";
                    break;
            }
            label3.Text = temp + ": " + Math.Round(calcTest1 * seasonalIndex[period%12], 2);
       
        }
        

        //#####################################################################//

        private void btnCalcForecast_Click(object sender, EventArgs e)
        {
            try
            {

                averageAmount_Year();

                /// ### Average for the year ## ///

                averageAmounts();

                /// ### Average for each independent month ### ///
                calculateSeasonalIndex();
                /// ### SEASONAL INDEX ### ////
                calculateDeSeasonalizedData();

                calc(comboBox1Forecast.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured!\n"+ex);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            lblTest.Text = null;
            lblAverage.Text = null;

            label1.Text = null;
            label2.Text = null;
            label3.Text = null;
            label4.Text = null;

        }


        // ############# SEASONALIZED DATA NEW #### ///////////////////////

        private void btnCalcForecast2_Click(object sender, EventArgs e)
        {

            try
            {
                averageAmount_Year();

                /// ### Average for the year ## ///

                averageAmounts();

                /// ### Average for each independent month ### ///
                calculateSeasonalIndex();
                /// ### SEASONAL INDEX ### ////
                /// 
                calculateDeSeasonalizedData();

                // December DE - SEASONALIZED DATA


                calc(comboBox1Forecast.SelectedIndex);
                newSeason(comboBox1Forecast.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured!\n"+ex);
            }
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            try
            {
                averageAmount_Year();

                /// ### Average for the year ## ///

                averageAmounts();

                /// ### Average for each independent month ### ///
                calculateSeasonalIndex();
                /// ### SEASONAL INDEX ### ////
                /// 
                calculateDeSeasonalizedData();

                // December DE - SEASONALIZED DATA
            } catch (Exception) { }


            double[] forecasts = new double[12];
            for (int i = 0; i < 12; i++)
            {
                calc(i);
                forecasts[i] = calcTest1;
            }
            Graph showGraph = new Graph(currentdata, forecasts, seasonalIndex);
            showGraph.Show();
        }
    }
}