using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab1;
using ConsoleApplication1;

namespace TestOfPoint
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Line l1 = new Line();
            Line l2=new Line();
            l1.a = new Point(1,1);
            
            l1.b = new Point(2,2);
            
            l2.a= new Point(1,2);
           
            l2.b= new Point(2,1);
          
            Point p = new Point(1.5,1.5);
            CalcOfPoint w = new CalcOfPoint();
            Assert.AreEqual(w.Back(l1,l2),p);
          
        }
    }
}
