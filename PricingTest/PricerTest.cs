using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pricing;
namespace PricingTest
{

    [TestClass]
    public class PricerTest
    {
        [TestMethod]
        public void getCallTest1()
        {
            double stockPrice = 50;
            double strikePrice = 55;
            double timeToMaturity = 1;
            double standardDeviation = 0.2;
            double risk = 0.09;

            Pricer p = new Pricer(stockPrice, strikePrice, timeToMaturity, standardDeviation, risk);
            Assert.AreEqual(3.8617, p.getCall());
        }
        [TestMethod]
        public void getCallTest2()
        {
            double stockPrice = 64;
            double strikePrice = 60;
            double timeToMaturity = 180 / 365;
            double standardDeviation = 0.27;
            double risk = 0.045;

            Pricer p = new Pricer(stockPrice, strikePrice, timeToMaturity, standardDeviation, risk);
            Assert.AreEqual(7.7661, p.getCall());
        }
        [TestMethod]
        public void getPutTest1()
        {
            double stockPrice = 50;
            double strikePrice = 55;
            double timeToMaturity = 1;
            double standardDeviation = 0.2;
            double risk = 0.09;

            Pricer p = new Pricer(stockPrice, strikePrice, timeToMaturity, standardDeviation, risk);
            Assert.AreEqual(4.1279, p.getPut());
        }
        [TestMethod]
        public void getPutTest2()
        {
            double stockPrice = 64;
            double strikePrice = 60;
            double timeToMaturity = 180 / 365;
            double standardDeviation = 0.27;
            double risk = 0.045;

            Pricer p = new Pricer(stockPrice, strikePrice, timeToMaturity, standardDeviation, risk);
            Assert.AreEqual(2.4493, p.getPut());
        }
    }
}