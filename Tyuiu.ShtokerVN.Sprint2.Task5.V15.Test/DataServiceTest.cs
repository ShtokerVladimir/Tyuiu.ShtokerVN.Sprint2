using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtokerVN.Sprint2.Task5.V15.Lib;

namespace Tyuiu.ShtokerVN.Sprint2.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(0));
            Assert.AreEqual("Вторник", ds.FindDayName(1));
            Assert.AreEqual("Среда", ds.FindDayName(2));
            Assert.AreEqual("Четверг", ds.FindDayName(3));
            Assert.AreEqual("Пятница", ds.FindDayName(4));
            Assert.AreEqual("Суббота", ds.FindDayName(5));
            Assert.AreEqual("Воскресенье", ds.FindDayName(6));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(0);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(8);
            });
        }
    }
}
