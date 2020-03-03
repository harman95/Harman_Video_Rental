using Microsoft.VisualStudio.TestTools.UnitTesting;
using Harman_Video_Master_Dec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harman_Video_Master_Dec.Tests
{
    [TestClass()]
    public class DatabaseTests
    {

        Database obj_Test = new Database();

        [TestMethod()]
        public void InsDelUpdtTest()
        {
            Database obj = new Database();
            int rslt = 1;
            int result = obj.data();
            Assert.AreEqual(rslt,1);
            
        }

        
        [TestMethod]
        public void dbtest() {

            var prDb = obj_Test.connection_String;
            var exConn = "Data Source=SIMRAN;Initial Catalog=Video_Rental_Sys;Integrated Security=True";
            Assert.AreEqual(prDb, exConn);
        }

        
    }
}