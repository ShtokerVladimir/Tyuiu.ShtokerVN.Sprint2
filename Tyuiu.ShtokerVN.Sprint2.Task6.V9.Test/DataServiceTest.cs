using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtokerVN.Sprint2.Task6.V9.Lib;

namespace Tyuiu.ShtokerVN.Sprint2.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("месяц: Январь\nДата: 5", ds.FindDateOfNextDay(1, 5));
            Assert.AreEqual("месяц: Февраль\nДата: 5", ds.FindDateOfNextDay(2, 7));
            Assert.AreEqual("месяц: Март\nДата: 5", ds.FindDateOfNextDay(3, 20));
            Assert.AreEqual("месяц: Апрель\nДата: 5", ds.FindDateOfNextDay(4, 15));
            Assert.AreEqual("месяц: Май\nДата: 5", ds.FindDateOfNextDay(5, 12));
            Assert.AreEqual("месяц: Июнь\nДата: 5", ds.FindDateOfNextDay(6, 22));
            Assert.AreEqual("месяц: Июль\nДата: 5", ds.FindDateOfNextDay(7, 26));
            Assert.AreEqual("месяц: Август\nДата: 5", ds.FindDateOfNextDay(8, 9));
            Assert.AreEqual("месяц: Сентябрь\nДата: 5", ds.FindDateOfNextDay(9, 6));
            Assert.AreEqual("месяц: Октябрь\nДата: 5", ds.FindDateOfNextDay(10, 17));
            Assert.AreEqual("месяц: Ноябрь\nДата: 5", ds.FindDateOfNextDay(11, 15));
            Assert.AreEqual("месяц: Декабрь\nДата: 5", ds.FindDateOfNextDay(12, 21));
        }
    }
}
