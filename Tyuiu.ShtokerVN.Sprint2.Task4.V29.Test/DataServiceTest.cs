﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtokerVN.Sprint2.Task4.V29.Lib;

namespace Tyuiu.ShtokerVN.Sprint2.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 99.6;
            Assert.AreEqual(wait, res);
        }
    
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 16;
            double res = ds.Calculate(x, y);
            double wait = 99.875;
            Assert.AreEqual(wait, res);
        }
    }
}
