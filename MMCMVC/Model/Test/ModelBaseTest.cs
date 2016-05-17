using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MMCMVC.Model.Test
{
    [TestClass]
    public class ModelBaseTest
    {
        [TestMethod]
        public void TestProperty()
        {
            ModelBase m = new ModelBase();
            m.Add(new CharField("TestField", "TestValue"));
            Assert.AreEqual("TestValue", m.Get("TestField").GetValue());
        }
    }
}
