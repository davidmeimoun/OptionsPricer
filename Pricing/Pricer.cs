using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace Pricing
{
    public class Pricer
    {
        private double stockPrice;
        private double strikePrice;
        private double timeToMaturity;
        private double standardDeviation;
        private double risk;
        private double d1;
        private double d2;

        public Pricer(double stockPrice, double strikePrice, double timeToMaturity, double standardDeviation, double risk)
        {
            this.stockPrice = stockPrice;
            this.strikePrice = strikePrice;
            this.timeToMaturity = timeToMaturity;
            this.standardDeviation = standardDeviation;
            this.risk = risk;
            this.d1 = (Math.Log(stockPrice / strikePrice) + (risk + Math.Pow(standardDeviation, 2) / 2) * timeToMaturity)
            / standardDeviation * Math.Pow(timeToMaturity, 1 / 2);
            this.d2 = d1 - standardDeviation * Math.Pow(timeToMaturity, 1 / 2);
        }

        /// <summary>
        /// Method for get call of Pricer
        /// </summary>
        /// <returns></returns>
        public double getCall()
        {
            var chart = new Chart();
            double result = stockPrice * chart.DataManipulator.Statistics.NormalDistribution(d1) - strikePrice * Math.Exp(-risk * timeToMaturity) * chart.DataManipulator.Statistics.NormalDistribution(d2);
            return Math.Round(result, 4);
        }

        /// <summary>
        /// Method for get put of Pricer
        /// </summary>
        /// <returns></returns>
        public double getPut()
        {
            var chart = new Chart();
            double result = strikePrice * Math.Exp(-risk * timeToMaturity) * chart.DataManipulator.Statistics.NormalDistribution(-d2) - stockPrice * chart.DataManipulator.Statistics.NormalDistribution(-d1);
            return Math.Round(result, 4);
        }

        /// <summary>
        /// Method for get d1 value
        /// </summary>
        /// <returns></returns>
        public double getD1()
        {
            return this.d1;
        }

        /// <summary>
        /// Method for get d2 value 
        /// </summary>
        /// <returns></returns>
        public double getD2()
        {
            return this.d2;
        }
    }
}
