using CalcClassBr;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Calculator.Tests
{
    [TestClass]
    public class CalcTests
    {
        public TestContext TestContext { get; set; }

        [DataSource("System.Data.SqlClient", @"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=C:\Users\KV-User\Desktop\astpp\Calculator\CalcClassBrTest\bin\Debug\ru\test.mdf; Integrated Security=True; Connect Timeout=30", "Table", DataAccessMethod.Sequential)]
        [TestMethod]
        public void ABS_FromDB()
        {
            long a = (long)TestContext.DataRow["actual"];
            string res = (string)TestContext.DataRow["result"];
            long actual;
            try
            {
                actual = CalcClass.ABS(a);
                Assert.AreEqual(Convert.ToInt64(res), actual);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual(res, "Error");
            }
        }
    }
}
