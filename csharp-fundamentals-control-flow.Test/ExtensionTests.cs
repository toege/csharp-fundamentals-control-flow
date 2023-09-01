using csharp_fundamentals_control_flow.Main;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_control_flow.Test
{
    public class ExtensionTests
    {     
        [Test]
        public void one()
        {
            Extension extension = new Extension();
            Assert.AreEqual("The cake is ready!", extension.timerStatus(0));
            Assert.AreEqual("The cake is still baking!", extension.timerStatus(1));
            Assert.AreEqual("The cake is still baking!", extension.timerStatus(23));
            Assert.AreEqual("The timer finished ages ago!", extension.timerStatus(-1));
            Assert.AreEqual("The timer finished ages ago!", extension.timerStatus(-25));
        }

        [Test]
        public void two()
        {
            Extension extension = new Extension();
            Assert.AreEqual(5, extension.estimatePrepTime(new String[] { "milk", "sugar", "eggs", "flour", "chocolate" }, 1));
            Assert.AreEqual(10, extension.estimatePrepTime(new String[] { "milk", "sugar", "eggs", "flour", "chocolate" }, 2));
            Assert.AreEqual(10, extension.estimatePrepTime(new String[] { "milk", "sugar", "eggs", "flour", "chocolate" }, 0));
            Assert.AreEqual(20, extension.estimatePrepTime(new String[] { "milk", "sugar" }, 10));
        } 
        
        [Test] 
        public void three()
        {
            Extension extension = new Extension();
            Assert.AreEqual(0, extension.calculateGramsOfSugar(new String[] { "milk", "flour", "eggs" }, 3));
            Assert.AreEqual(100, extension.calculateGramsOfSugar(new String[] { "milk", "flour", "sugar" }, 1));
            Assert.AreEqual(200, extension.calculateGramsOfSugar(new String[] { "milk", "sugar", "eggs" }, 2));
            Assert.AreEqual(300, extension.calculateGramsOfSugar(new String[] { "sugar", "flour", "eggs" }, 3));
            Assert.AreEqual(400, extension.calculateGramsOfSugar(new String[] { "sugar", "milk", "eggs" }, 4));
        }
    }

}
